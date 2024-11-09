using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PB503_Encapsulation_homework
{
    public class Car
    {
        public int ID;
        public string Name;
        private int _speed;
        public string Carcode;

        public int Speed
        {
            get => _speed;

            set
            {
                if (value > 0)
                {
                    _speed = value;
                }
                else
                {
                    Console.WriteLine("Speed can't be less than 0");
                }
            }
        }


        public Car(int id, string name, int speed, string finishCarCode)
        {
            ID = id;
            Name = name;
            Speed = speed;
            Carcode = finishCarCode;
            //CarCode(Carcode);

        }

        //static string CarCode(string carCode)
        //{
        //    string nameresult = "";
        //    foreach (char c in carCode)
        //    {
        //        if (carCode.ToUpper().Contains(c))
        //        {
        //            nameresult = carCode;
        //        }
        //        else
        //        {
        //            break;
        //        }

        //    }

        //    int[] ints = new int[4];
        //    int[] news = new int[ints.Length];



        //    for (int i = 0; i < ints.Length; i++)
        //    {
        //        if (ints[0] == 1 && ints[1] == 0 && ints[2] == 0)
        //        {
        //            news[i] = ints[i];
        //        }

        //        else
        //        {
        //            break;
        //        }
        //    }

        //    string result = string.Join("", news);

        //    string finishCarCode = nameresult + result;
        //   return finishCarCode;










        //carCode = char.ToUpper(carCode[0]) + carCode.Substring(1);
        //carCode = carCode[0] + char.ToUpper(carCode[1]).ToString() + carCode.Substring(2);

        //int[] numbers = new int[number.Length];
        //foreach (int numberItem in number)
        //{
        //    if (number[0] != 1)
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        numbers[0] = numberItem;
        //    }
        //}

        //string result = string.Join(carCode, numbers);

        // return carCode;
    }


}

