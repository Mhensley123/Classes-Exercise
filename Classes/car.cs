using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car

    {


        //Constructors
        // a special member method that has the same name as its class
        public Car()
        {

        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        //fields
        //properties
        //methods
        //Create a Make property of type string that is public
        //Create a Model property of type string that is public
        //Create a Year property of type int that is public
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }     
}
