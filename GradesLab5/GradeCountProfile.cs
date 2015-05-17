using System;
using System.Collections.Generic;
using System.Text;

namespace GradesLab5
{
    class GradeCountProfile
    {
        private string pass = string.Empty;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private string merit = string.Empty;

        public string Merit
        {
            get { return merit; }
            set { merit = value; }
        }

        private string distinction = string.Empty;

        public string Distinction
        {
            get { return distinction; }
            set { distinction = value; }
        }

        // For display
        public string ProfileString()
        {
            string  temp = "";

            temp = "P: " + pass + " M: " + merit + " D: " + distinction;

            return temp;
        }
        
    }
}
