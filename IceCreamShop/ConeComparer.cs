using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    //class ConeComparer
    {
        public int Compare(Cone x, Cone y)
        {
            //return string.Compare(x.Cost, y.Cost);
            return Comparer<double>.Default.Compare(x.Cost, y.Cost);
        }
    }
}
