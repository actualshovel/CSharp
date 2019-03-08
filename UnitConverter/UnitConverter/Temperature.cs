using System;

namespace UnitConverter
{
    //use of this class requires instantiation.
    //user will then enter a temperature to be converted by the appropriate method
    class Temperature
    {
        // We know we're going to convert this value to Celsius,...
        // When you set Fahrenheit, this is the perfect time to
        // automatically set Celsius.
        private double _fahrenheit;

        // Keep in mind, this would only be useful if you wanted to keep
        // track of multiple instances of temperature over time
        public double Fahrenheit
        {
            get
            {
                return _fahrenheit;
            }

            set
            {
                _fahrenheit = value;
                _celsius = (value - 32) * 5 / 9;
            }
        }        

        private double _celsius;
        public double Celsius { get; set; }


        // Technique for commenting code in VS, right above the method
        // type in /// and then press tab. This will auto-comment
        // including parameters if the method has any
        // Only summarize if absolutely necessary. The method name
        // should ideally let a developer know what it does.

        //formula to get fahrenheit given celsius
        public void GetFahrenheit()
        {
            Fahrenheit = (Celsius * (9/5) + 32);
            // Perfectly fine passing text information, but you may want to make this information
            // easier to use and modify.
            Console.WriteLine("{0:00}C is equal to {1:00}F", Celsius, Fahrenheit); // Good use of the formatting!!
        }

        /// <summary>
        /// This is auto-generated, then I added some text to the line.
        /// </summary>
        public void GetCelsius()
        {
            Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("{0:00}F is equal to {1:00}C", Fahrenheit, Celsius);
        }


        //C to F (cel * (9/5) + 32);
        //F to C (((fah - 32) * 5) / 9);
    }
}
