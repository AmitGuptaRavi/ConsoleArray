using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    public static class ImageResize
    {
         public static string ResizeImage()
        {
            // Input and output file paths
            string inputImagePath = @"D:\pikaso_edit_20241014.png";
            string outputImagePath = @"D:\_Resize_pikaso_edit_20241014.png";

            // Custom resolution (width, height)
            int newWidth = 800;  // Set your desired width
            int newHeight = 600; // Set your desired height

            Resize(inputImagePath, outputImagePath, newWidth, newHeight);
            return outputImagePath;
        }

       public static void Resize(string inputPath, string outputPath, int width, int height)
        {
            // Load the image
            using (Image originalImage = Image.FromFile(inputPath))
            {
                // Create a new bitmap with the desired dimensions
                using (Bitmap resizedImage = new Bitmap(originalImage, width, height))
                {
                    // Save the resized image to the output path
                    resizedImage.Save(outputPath, ImageFormat.Jpeg); // You can change format as needed (e.g., PNG)
                }
            }

            Console.WriteLine("Image resized successfully!");
            Console.ReadLine();
        }
    }
}
