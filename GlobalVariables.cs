using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSearchPoc
{
    public static class GlobalVariables
    {
        //These are for paging
        //public static int ResultsPerPage
        //{
        //    get
        //    {
        //        return 3;
        //    }
        //}
        //public static int MaxPageRange
        //{
        //    get
        //    {
        //        return 5;
        //    }
        //}

        //public static int PageRangeDelta
        //{
        //    get
        //    {
        //        return 2;
        //    }
        //}



        //These are for infinite scroll
        public static int ResultsPerPage
        {
            get
            {
                return 3;
            }
        }
    }
}
