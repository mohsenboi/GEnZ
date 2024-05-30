using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEnZ.GEnZ
{
    public class Context
    {
        public Boolean IsInitiated { get; set; }
        public Image OriginalPictureImg { get; set; }
        public Bitmap OriginalPictureBmp { get; set; }

        public void ClearContext()
        {
            if (IsInitiated)
            {
                OriginalPictureBmp.Dispose();
                OriginalPictureImg.Dispose();
            }
        }
    }
}
