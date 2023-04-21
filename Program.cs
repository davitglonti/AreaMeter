//third project
using System;

public class Program {
    public static void Main() {
        int length =  3;
        int width = 8;
        int height = 11;

        // Call the area method with two parameters
        int area = CalculateArea(5, 11);
        Console.WriteLine($"The area of the rectangle is {area}");

        // Call the volume method with three parameters
        int volume = CalculateVolume(length, width, height);
        Console.WriteLine($"The volume of the rectangle is {volume}");
    }

    // Method to calculate the area of a rectangle
    public static int CalculateArea(int length, int width) {
        return length * width;
    }

    // Overloaded method to calculate the volume of a rectangle
    public static int CalculateVolume(int length, int width, int height) {
        return length * width * height;
    }
}