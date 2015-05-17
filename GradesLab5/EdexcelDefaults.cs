using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesLab5
{
    public class EdexcelDefaults
    {
        private int passPoints;

        public int PassPoints
        {
            get { return passPoints; }
            set { passPoints = value; }
        }
        private int meritPoints;

        public int MeritPoints
        {
            get { return meritPoints; }
            set { meritPoints = value; }
        }

        private int distinctionPoints;

        public int DistinctionPoints
        {
            get { return distinctionPoints; }
            set { distinctionPoints = value; }
        }

        private int defaultCredit;

        public int DefaultCredit
        {
            get { return defaultCredit; }
            set { defaultCredit = value; }
        }

        private int certificateUnits;

        public int CertificateUnits
        {
            get { return certificateUnits; }
            set { certificateUnits = value; }
        }

        private int subDipUnits;

        public int SubDipUnits
        {
            get { return subDipUnits; }
            set { subDipUnits = value; }
        }

        private int ninetyUnits;

        public int NinetyUnits
        {
            get { return ninetyUnits; }
            set { ninetyUnits = value; }
        }

        private int diplomaUnits;

        public int DiplomaUnits
        {
            get { return diplomaUnits; }
            set { diplomaUnits = value; }
        }

        private int extendedUnits;

        public int ExtendedUnits
        {
            get { return extendedUnits; }
            set { extendedUnits = value; }
        }
        
        
        // Constructor with current default values
        public EdexcelDefaults()
        {
            passPoints = 7;
            meritPoints = 8;
            distinctionPoints = 9;
            defaultCredit = 10;
            certificateUnits = 3;
            subDipUnits = 6;
            ninetyUnits = 9;
            diplomaUnits = 12;
            extendedUnits = 18;
        }
        

        // Function to return number of course units
        public int CourseUnits(int courseID)
        {
            int iTemp  = 99;

            switch (courseID)
            {
                case 0:
                    iTemp = certificateUnits;
                    break;
                case 1:
                    iTemp = subDipUnits;
                    break;
                case 2:
                    iTemp = ninetyUnits;
                    break;
                case 3:
                    iTemp = diplomaUnits;
                    break;
                case 4:
                    iTemp = extendedUnits;
                    break;
                default:
                    break;
            }

            return iTemp;
        }
        
    }
}
