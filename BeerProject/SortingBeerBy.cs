using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProject
{
    internal class SortingBeerBy : IComparer
    {
        private SortBy _sortby;

        public SortBy Sortby
        {
            get { return _sortby; }
            set { _sortby = value; }
        }

        public SortingBeerBy(SortBy sortby)
        {
            Sortby = sortby;
        }
        public int Compare(object x, object y)
        {
            if (Sortby == SortBy.Percent)
            {
                double result = (((Beer)x).Percent - ((Beer)y).Percent);
                if (result > 0)
                {
                    return -1;
                }else if (result < 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }else if (Sortby == SortBy.Unit)
            {
                return ((int)(((Beer)x).GetUnits() - ((Beer)y).GetUnits()));
            }else if (Sortby == SortBy.Volume)
            {
                return ((Beer)x).Volume - ((Beer)y).Volume;
            }else
            {
                return 0;
            }
           
        }
    }
}
