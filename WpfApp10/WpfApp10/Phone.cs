using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
    abstract class Phone
    {
        string name;
        int balance;
        string model;
        public Phone(string name, int balance, string model)
        {
            this.balance = balance;
            this.name = name;
            this.model = model;
        }
        public void AddBalance(int balance)
        {
            this.balance += balance;
        }
        public string Call(int duration)
        {
            balance -= duration;
            return $"{name} {model} says: Вы проговорили {duration} минут";
        }

        abstract public string Charge(int time);  
    }
}
