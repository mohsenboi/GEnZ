using ManagedCuda;
using ManagedCuda.BasicTypes;
using ManagedCuda.VectorTypes;
using OpenCvSharp;
using System;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;


namespace GEnZ.GEnZ
{
    public class ImageCompartion
    {

        public int CompareImages(Bitmap bitmap1, Bitmap bitmap2)
        { 

            // Convert Bitmaps to byte arrays
            byte[] img1Data = BitmapToByteArray(bitmap1);
            byte[] img2Data = BitmapToByteArray(bitmap2);

            // Ensure both images are the same size
            if (bitmap1.Size != bitmap2.Size)
            {
                throw new ArgumentException("Images must be the same size for difference calculation.");
            }
            using (CudaContext context = new CudaContext())
            {
                // Allocate GPU memory and copy data
                using (CudaDeviceVariable<byte> gpuImage1 = new CudaDeviceVariable<byte>(img1Data.Length))
                using (CudaDeviceVariable<byte> gpuImage2 = new CudaDeviceVariable<byte>(img2Data.Length))
                using (CudaDeviceVariable<int> gpuDifference = new CudaDeviceVariable<int>(img1Data.Length))
                {
                    gpuImage1.CopyToDevice(img1Data);
                    gpuImage2.CopyToDevice(img2Data);

                    // Load and launch the kernel
                    CudaKernel kernel = LoadKernel(context);
                    kernel.BlockDimensions = new dim3(256);
                    kernel.GridDimensions = new dim3((img1Data.Length + 255) / 256);

                    kernel.Run(gpuImage1.DevicePointer, gpuImage2.DevicePointer, gpuDifference.DevicePointer, img1Data.Length);

                    // Copy the result back to the CPU
                    int[] difference = new int[img1Data.Length];
                    gpuDifference.CopyToHost(difference);

                    // Calculate the total difference
                    int totalDifference = 0;
                    foreach (int diff in difference)
                    {
                        totalDifference += diff;
                    }

                    return totalDifference;
                }
            }
        }

        CudaKernel LoadKernel(CudaContext context)
        {
            string ptxPath = "kernel.ptx";
            CUmodule module = context.LoadModule(ptxPath);
            CudaKernel kernel = new CudaKernel("CalculateDifference", module, context);
            return kernel;
        }
        byte[] BitmapToByteArray(Bitmap bitmap)
        {
            // Lock the bitmap's bits
            Rectangle rect = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
            BitmapData bmpData = bitmap.LockBits(rect, ImageLockMode.ReadOnly, bitmap.PixelFormat);

            // Copy the bitmap data to the byte array
            int bytes = Math.Abs(bmpData.Stride) * bitmap.Height;
            byte[] imageData = new byte[bytes];
            Marshal.Copy(bmpData.Scan0, imageData, 0, bytes);

            // Unlock the bitmap's bits
            bitmap.UnlockBits(bmpData);

            return imageData;
        }
    }
}
