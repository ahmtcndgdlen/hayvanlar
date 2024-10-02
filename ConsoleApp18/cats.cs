using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class cats : animal
    {

        public cats(string ad,int yas) : base(ad,yas)
        {
        }
        public override void SesCikar()
        {
            Console.WriteLine($"{yas} + {ad}: miyav");
        }

    }
}
