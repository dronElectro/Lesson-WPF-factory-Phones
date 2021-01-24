using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
    class PhoneFactory
    {
        List<Phone> list;
        public PhoneFactory(List<Phone> list)
        {
            this.list = list;   
        }
        public Phone CreatePhone(int number)
        {
            if (number < list.Count)
                return list[number];
            else
                throw new Exception("No model this number");
            /*switch(number)
            {
                case 1: return new Smartphone("Nokia", 1000, "3310", 55);
                case 2: return new Smartphone("SonyErricsson", 1200, "k740i", 24);
                case 3: return new CameraPhone();
                default: throw new Exception("No model this number");
            }*/
        }
    }
}
