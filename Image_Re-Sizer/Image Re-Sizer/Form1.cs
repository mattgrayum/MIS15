using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Image_Re_Sizer
    /* I customized this from a more generic image resizing algorithm
     * I needed to be able to take a directory with over 50 files and resize each 
     * to the same dimensions without having to open each one in edit
     * mode and do each one manually. 
     * 
     * In the end I spent more time making this work, but It was a 
     * good exercise, especially in learning some about working with files. */
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;

        private static Image ResizeImage(Image image, Size newSize)
        {
            //instantiates an image object with the new desired size
            Image newImage = new Bitmap(newSize.Width, newSize.Height);

            //instantiates a Graphics object and assigns it the new image (cast from Image to Bitmap)
            using (Graphics GFX = Graphics.FromImage((Bitmap)newImage))
            {
                //draws the original image to the newly sized graphics template
                GFX.DrawImage(image, new Rectangle(Point.Empty, newSize));
            }

            return newImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //gets all the files from the source directory 
            //runs each image through the resizer 
            //then saves the resized image to a new directory

            //source directory
            string filePath = @"C:\Users\Matthew\Dropbox\MATT\SCHOOL\CSUS\FALL 2016\MIS 15\GinRummy\Cards1\";

            //gets all file names into an array
            string[] fileEntries = Directory.GetFiles(filePath);

            //iterates through the array
            foreach (string fileName in fileEntries)
            {
                //capture the right-most file name characters to be used in target directory
                string shortName = rightChars(fileName, 74);

                //sets the new image size
                Size sz = new Size(100, 146);

                //instantiates an image object from the source file
                Image image = Bitmap.FromFile(fileName);

                //resizes the image object
                image = ResizeImage(image, sz);

                //sets the target file path
                string newFileName = @"C:\Users\Matthew\Dropbox\MATT\SCHOOL\CSUS\FALL 2016\MIS 15\GinRummy\Cards\" + shortName;

                //saves the re-sized image to the new directory as a .png file
                image.Save(newFileName, System.Drawing.Imaging.ImageFormat.Png);
            }           
        }

        public static string rightChars(string str, int startPoint)
        {
            //returns the remaining, right-most characters of a string, after a given index point
            return str.Substring(startPoint, str.Length - startPoint);
        }




    }
}
