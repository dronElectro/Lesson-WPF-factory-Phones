using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
    class Smartphone : Phone
    {
        int charge;
        public Smartphone(string name, int balance, string model, int charge) : base(model, balance, name)
        {
            this.charge = charge;
        }
        public override string Charge(int time)
        {
            charge += (int)(time * 0.1);
            return $"Вы заряжали телефон {time} секунд";
        }
    }
}
