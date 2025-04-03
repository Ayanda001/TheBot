using System;
using System.Drawing;

public class ASCIIImage
{
    public static void Display()
    {
        try
        {
            int Width = 80;  // Desired width
            int Height = 40; // Desired height
            Console.ForegroundColor = ConsoleColor.White;
            Bitmap image = new Bitmap("Assets/Logo image.bmp");
            Console.WriteLine($"Original Image Loaded - Width: {image.Width}, Height: {image.Height}");

            // Resize the image to the desired width and height
            Bitmap resizedImage = new Bitmap(image, new Size(Width, Height));
            Console.WriteLine($"Resized Image - Width: {resizedImage.Width}, Height: {resizedImage.Height}");

            // Pass the resized image to ConvertToASCII
            ConvertToASCII(resizedImage);
        }
        catch (Exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CyberSecurity image not found.");
            Console.ResetColor();
        }
    }

    private static void ConvertToASCII(Bitmap image)
    {
        string asciiChars = "@#S%?*+;:,."; // Set of characters for ASCII art
        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);  // Get pixel color at (x, y)
                int gray = (pixel.R + pixel.G + pixel.B) / 3;  // Convert to grayscale
                int index = gray * (asciiChars.Length - 1) / 255;  // Map grayscale to ASCII char
                Console.Write(asciiChars[index]);  // Print corresponding ASCII char
            }
            Console.WriteLine();
        }
    }
}
