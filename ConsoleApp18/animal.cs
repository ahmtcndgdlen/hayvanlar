using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class animal
    {
        public animal(string ad, int yas)
        {
            this.ad = ad;
            this.yas = yas;
        }
        public string ad { get; set; }
        public int yas { get; set; }

        public string ses { get; set; }

        public virtual void SesCikar()
        {
            Console.WriteLine("hayvan ses çıkarıyor");

        }
    }
}
