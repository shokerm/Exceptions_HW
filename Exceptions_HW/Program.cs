using System;

namespace Exceptions_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            

            string[] typesOfCars = { "Sozoki", "Renu", "Kia", "Mazda", "shevrolet" };
            Garage g1 = new Garage(typesOfCars);
            Car c1 = new Car("Sozoki", false, false);
            Car c2 = new Car("Renu", false, true);
            Car c3 = new Car("Kia", true, false);
            Car c4 = new Car("Mazda", true, true);
            Car c5 = new Car("shevrolet", true, true);
            Car c6 = new Car("jaguar", false, false);
            Car c7 = null;
            Car c8 = new Car("Kia", false, false);
            
            

            
           
          

            try
            {
                g1.AddCar(c2);
                Console.WriteLine();
            }
            catch (CarAlreadyHereException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);


            }
            catch (RepairMismatchException ex)
            {
                Console.WriteLine(ex.Message);


            }
            catch (WeDoNotFixTotalLostException ex)
            {
                Console.WriteLine(ex.Message);


            }
            catch (WrongGarageException ex)
            {
                Console.WriteLine(ex.Message);


            }

          

            try
            {
                g1.FixCar(c2);
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            catch(CarNotInGarageException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (RepairMismatchException ex)
            {
                Console.WriteLine(ex.Message);

            }

            try
            {
                g1.TakeOutCar(c6);
            }
            catch (CarNullException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (CarNotReadyException ex)
            {
                Console.WriteLine(ex.Message);


            }
            catch (WrongGarageException ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
