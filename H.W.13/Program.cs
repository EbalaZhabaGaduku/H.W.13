using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H.W._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("13", 12, 23, 21);
            MultiBuilding multiBuilding = new MultiBuilding("13", 12, 23, 21, 4);
            multiBuilding.Print();
            building.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        public string Adress { get; set; }
        public double Length { get; set; }
        public double Wigth { get; set; }
        public double Height { get; set; }

        public Building(string adress,double length,double wigth,double height)
        {
            Adress = adress;
            Length = length;
            Wigth = wigth;
            Height = height;
        }
        public void Print()
        {
            Console.WriteLine("Адрес дома {0}, Длина здания {1}, Ширина зданий {2}, Высота здания {3}", Adress, Length, Wigth, Height);
        }
       
    }
    sealed class MultiBuilding:Building
    {
        public int Floor { get; set; }
        public MultiBuilding(string adress, double length, double wigth, double height, int floor):
            base (adress,length,wigth,height)
        {
            Floor = floor;
        }
        public new void Print()
        {
            base.Print();
            Console.Write("Количество этажей {0} ", Floor) ;
        }

    }
    
}
