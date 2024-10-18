using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Weapon
    {
        int _capacity;
        int _count;
       public string mode;

        public Weapon(int capacity, int count, string mode)
        {
            Capacity = capacity;
            Count = count;
            Mode = mode;

        }
        public int Capacity
        {
            get
            {
                return _capacity;

            }
            set
            {
                if (value > 0)
                {
                    _capacity = value;
                }
                else
                {
                    Console.WriteLine("0 dan boyuk deyer verin");
                }

            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            { if( value> Capacity)
                {
                    Console.WriteLine("Sayi duzgun verin");
                }
                else
                {
                    _count = value;
                }

            }
        }
        public string Mode
        {
            get
            {
                return mode;
            }
            set
            {
                if (value == "tekli" || value == "auto")
                {
                    mode = value;
                }
                else
                {
                    Console.WriteLine("bele mod yoxdur");
                }

            }
        }
        public void Shoot()
        {if(Count == 0)
            {
                Console.WriteLine("gulle yoxdur");
                return;
            }
        if (mode == "tekli")
            {
                Count--;
                Console.WriteLine("Atis edildi");
                Console.WriteLine("Qalan gulle sayi:" + Count);
            }
        else if(mode == "auto")
            {
                Count = 0;
                Console.WriteLine("Atis edildi");
                Console.WriteLine("Qalan gulle sayi:" + Count);
            }


        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine("Daragin dolmasi ucun lazim olan gulle sayi:" + (Capacity - Count));       
        }
        public void Reload()
        {    
            if (Count < Capacity)
            {
                
             int load = Capacity - Count;
             Count += load ;
              Console.WriteLine("Daraqdaki Gulle sayi yenilendi.Gulle sayi: " + Count);
            }
        else if( Count == Capacity)
            {
                Console.WriteLine("Daraq zaten dolu ");
                return;
            }

        }
        public void ChangeFireMode()
        { if(mode == "tekli")
            {
                mode = "auto";
                Console.WriteLine("Atis modu tekliden avtomatike kecirildi");
            }
        else if(mode == "auto")
            {
                mode = "tekli";
                Console.WriteLine("Atis modu avtomatikden tekliye kecirildi");
            }

        }
        public void ChangeCapasity(int newCapacity)
        {
            Capacity = newCapacity;
            Console.WriteLine("Daragin yeni tutumu:" + Capacity);



        }
        public void ChangeCount(int newCount)
        {
            if(Count< newCount || newCount == 0)
            {
                Console.WriteLine("yeni daxil etdiyiniz say tutumdan boyuk ve ya 0 -a beraber ola bilmez");
            }
            else
            {
                Count = newCount;
                Console.WriteLine("Daragin yeni gulle sayi:" + Count);
            }

        }
        public void GetInfo()
        {
            Console.WriteLine($"Gulle tutumu:{Capacity},Gulle sayi:{Count},Atis modu:{mode}");
        }











        








    }
}
