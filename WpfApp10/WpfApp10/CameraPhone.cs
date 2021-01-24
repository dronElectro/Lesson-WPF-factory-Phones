using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
    class CameraPhone : Phone
    {
        public CameraPhone() : base("Самсуг", 1000, "CAM895")
        {

        }

        public string TakeAPicture()
        {
            return "Photo done!";
        }
        public override string Charge(int time)
        {
            return "Chaarged";
        }
    }
}
