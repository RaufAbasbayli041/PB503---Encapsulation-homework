﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Encapsulation_task2_homework
{
    public class Product
    {
        private double _price;
        private int _count;

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("price can't be low than 0");
                }
            }
        }
        public int Count
        {
            get { return _count; }
            set
            {
                if (value >= 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }

        public Product(int id, string name, double price)
        {
            Name = name;
            Id = id;
            Price = price;
            
        }
    }
}