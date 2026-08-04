namespace Classes
{

    // It's internal, which means that it can only 
    // be accessed from within the same assembly.
    internal class Car
    {
        // ---------- Static Field:

        public static int NumberOfCars = 0;


        // --------- member variable ("private" hides the variable from other classes).
        // --Backing Field of the Model property

        //private string _model = "";    // model is simple and not using custom setters and getters.
        private string _brand = "";

        // private bool _isLuxury;      // isLuxury is simple is simple to.


        //----------- Properties:

        // lambda expression:
        //public string Model { get => _model; set => _model = value; }

        // simple version
        /*
        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }
        */

        // auto-property for simple data:
        public string Model { get; set; }


        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return $"{_brand}";
                }
                else
                {
                    return _brand;
                }
            }

            set
            {
                if (string.IsNullOrEmpty(value))   // "value" keyword is whatever we want to pass or assign to this property.
                {
                    System.Console.WriteLine("You entered Nothing");
                    _brand = "Default_Brand";
                }
                else
                {
                    _brand = value;
                }

            }
        }

        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        public bool IsLuxury { get; set; }


        // Constructor : it has the same name as the class itself
        // and it doesn't return type.
        // the constructor is executed whenever a new object of car is created.
        // Custom Constractor:
        public Car(string model, string brand, bool isLuxury)
        {
            NumberOfCars++;

            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;

            System.Console.WriteLine($"Your car is: {_brand} - {Model}");
        }

        // Default constructor
        public Car()
        {
            NumberOfCars++;
        }

        public void Drive()
        {
            System.Console.WriteLine($"Driving the {Model}");
        }


    }
}