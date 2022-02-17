using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_HW
{
    public class Garage : IGarage
    {
        public Car[] cars;


        public string[] carTypes { get; set; }


        public Garage(string[] carTypes)
        {
            this.carTypes = carTypes;
            cars = new Car[6];
        }


        public void AddCar(Car c1)
        {
            if (cars.Contains(c1))
            {

                throw new CarAlreadyHereException("Car already is here...");

            }
            if (c1.TotalLost == true)
            {

                throw new WeDoNotFixTotalLostException("we dont fix totallost cars");

            }


            
                
                if (!carTypes.Contains(c1.Brand))
                {

                    throw new WrongGarageException("wrong garage exception");
                }
            

            if (c1 == null)
            {
                throw new CarNullException("car is null");
            }

            if (c1.NeedsRepair == false)
            {
                throw new RepairMismatchException("not need a repair.....");
            }


            for (int j = 0; j < cars.Length; j++)
            {
                if (cars[j] == null)
                {
                    cars[j] = c1;
                   
                    break;

                }
            }
            Console.WriteLine("The car has been added");





        }

        public void TakeOutCar(Car c)
        {

            if (c is null)
            {
                throw new CarNullException("The car is null...");
            }
            else if (cars.Contains(c) && c.NeedsRepair == true)
            {

                throw new CarNotReadyException("The car is not ready yet...");
            }
            else if (!cars.Contains(c))
            {
                throw new WrongGarageException("the car does not exist...");
            }
            else
            {

                Console.WriteLine("The car is out of the garage");

                for (int i = 0; i < cars.Length; i++)
                {
                    if (this.cars[i] != null)
                        Console.WriteLine($"The garage has deleted the car : {cars[i].Brand}");

                }

            }
        }

        public void FixCar(Car c)
        {
            if (c is null)
            {
                throw new CarNullException("The car is null...");
            }
            else if (!cars.Contains(c))
            {

                throw new CarNotInGarageException("The car is not exist");
            }
            else if (c.NeedsRepair == false)
            {
                throw new RepairMismatchException("The car is not need a repair!");

            }
            else
            {
                c.NeedsRepair = false;
            }

        }


    }
}
