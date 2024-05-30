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
    }
}
