using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    class ItalianChef : Chef {

        public void MakePasta(){
            Console.WriteLine("The Chef makes Pasta Aglio Olio");
        }

        public override void MakeSpecialDish(){
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}