using System.Threading.Tasks.Dataflow;

namespace PB503_Encapsulation_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car(1, "BMW", 100, "aa122");
            Car car2 = new Car(2, "MB", 120, "AS68");
            Car car3 = new Car(3, "MG", 130, "adf02");
            Car car4 = new Car(4, "Vaz07", 150, "ab001");


            Gallery gallery = new Gallery();

            gallery.AddCar(car1);
            gallery.AddCar(car2);
            gallery.AddCar(car3);
            gallery.AddCar(car4);

            Car wantedCar = gallery.FindCarByCarCode("as");

            if (wantedCar != null)
            {
                Console.WriteLine(wantedCar.Name);
            }
            else
            {
                Console.WriteLine("no car");
            }
           


            //gallery.ShowAllCars(gallery.Cars);

            //Car[] wantedCars = gallery.FindCarsBySpeedInterval(90,121);

            //foreach (var car in wantedCars)
            //{
            //    Console.WriteLine(car.Name);
            //}

        }


    }
}
