using GEnZ.GEnZ.GenticAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEnZ.GEnZ
{
    public class GEnZContext
    {
        public Boolean IsInitiated { get; set; }
        public Image? OriginalPictureImg { get; set; }
        public Bitmap? OriginalPictureBmp { get; set; }
        public GeneticContext? GeneticContext { get; set; }

        private static Random Rnd { get; set; } = new Random();

        /// <summary>
        /// Disposes All loaded images from memory
        /// </summary>
        public void ClearContext()
        {
            if (IsInitiated)
            {
                OriginalPictureBmp?.Dispose();
                OriginalPictureImg?.Dispose();

                IsInitiated = false;
            }
        }
        public static int RandomInt(int min, int max)
        {
            lock (Rnd)
            {
                return Rnd.Next(min, max);
            }
        }
        public static Double RandomDouble(double min, double max)
        {
            lock (Rnd)
            {
                return Rnd.NextDouble() * (max - min) + min;
            }
        }
        public static Double RandomDouble()
        {
            lock (Rnd)
            {
                return Rnd.NextDouble();
            }
        }
        public static float RandomFloat(float min, float max)
        {
            lock (Rnd)
            {
                return Rnd.NextSingle() * (max - min) + min;
            }
        }
        public static float RandomFloat()
        {
            lock (Rnd)
            {
                return Rnd.NextSingle();
            }
        }

    }
}
