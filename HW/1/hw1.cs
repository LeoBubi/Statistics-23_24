/*
Statistics 2023/2024
Homework 1

Leonardo Brugnano
2128518
*/

using System;
using System.Drawing;
using System.Windows.Forms;

public class DrawingForm : Form
{
    public DrawingForm()
    {
        // Set the title of the window
        this.Text = "Drawing Shapes";

        // Set the size of the form
        this.Size = new Size(400, 200);

        // Subscribe to the Paint event to draw shapes
        this.Paint += new PaintEventHandler(DrawingForm_Paint);
    }

    private void DrawingForm_Paint(object sender, PaintEventArgs e)
    {
        // Create a Graphics object to draw on the form
        Graphics graphics = e.Graphics;

        // Create a pen to draw shapes
        Pen pen = new Pen(Color.Black, 2);

        // Define the initial position for drawing
        int x = 50;
        int y = 100;
        int spacing = 30;

        // Draw a point
        graphics.DrawRectangle(pen, x, y, 1, 1);
        x += spacing;

        // Draw a line
        graphics.DrawLine(pen, x, y, x + 100, y);
        x += 100 + spacing;  // Adjust spacing for the next shape

        // Draw a circle
        int circleRadius = 50;
        graphics.DrawEllipse(pen, x, y - circleRadius, circleRadius * 2, circleRadius * 2);
        x += 2 * circleRadius + spacing;

        // Draw a rectangle
        int rectWidth = 100;
        int rectHeight = 50;
        graphics.DrawRectangle(pen, x, y - rectHeight / 2, rectWidth, rectHeight);

        // Dispose of the pen and graphics objects
        pen.Dispose();
        graphics.Dispose();
    }

    public static void Main()
    {
        Application.Run(new DrawingForm());
    }
}