using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesLab5
{
    static class ResultStatus
    {
        private static bool feasibleResult;

        public static bool FeasibleResult
        {
            get { return feasibleResult; }
            set { feasibleResult = value; }
        }
        
    }
}
