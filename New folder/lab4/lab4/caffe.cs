using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class caffe
    {
        int water;
        int coffee;
        int milk;
        int choc;

        public caffe()
        {
            water = 500;
            coffee = 500;
            milk = 500;
            choc = 500;
        }
        public bool makeBlackCoffee()
        {
            //ทำเมนูกาแฟดำ
            if (water >= 300 && coffee >= 20)
            {
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool makeMocha()
        {
            //ทำเมนูมอคค่า
            if (water >= 300 && coffee >= 20 && choc >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                choc = choc - 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool makeLatte()
        {
            //ทำเมนูลาเต้
            if (water >= 300 && coffee >= 20 && milk >= 10)
            {
                water = water - 300;
                coffee = coffee - 20;
                milk = milk - 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool makechoclate()
        {
            //ทำเมนูช็อคโกแลต
            if (water >= 300 && choc >= 20)
            {
                water = water - 300;
                choc = choc - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
