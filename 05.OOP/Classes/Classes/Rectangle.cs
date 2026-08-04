namespace Classes
{

    internal class Rectangle
    {
        // ------ const and readonly:-------
        // in C#, const and readonly are two keywords used to define non-modifiable fields,
        // but they different in terms of when they are initialized and their usage contexts.
        // Understanding the differences between these two can help in deciding which one to
        // use based on specific requirements.

        // declaration of field:
        public const int NumberOfCorners = 4;
        // declaration of field:
        public readonly string Color;

        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle(string color)
        {
            Color = color;
        }

        // Computed Property (Read-only) (only have getter)
        public double Area
        {
            get { return Width * Height; }
        }


        // Method to display the details of the rectangle
        public void DisplayDetails()
        {
            System.Console.WriteLine($"Color: {Color}, Width: {Width}\nHegit {Height}, Area: {Area}, Number of corners: {NumberOfCorners}");
        }
    }



}