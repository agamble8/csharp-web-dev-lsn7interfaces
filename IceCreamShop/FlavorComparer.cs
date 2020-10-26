using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        // sorting by name
        //public int Compare(Flavor x, Flavor y)
        //{
        //    return string.Compare(x.Name, y.Name);
        //}

        //sorting by allergens
        public int Compare(Flavor x, Flavor y)
        {
            return x.Allergens.Count.CompareTo(y.Allergens.Count);
        }
    }
}
