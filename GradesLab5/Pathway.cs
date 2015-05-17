using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesLab5
{
    public class Pathway
    {
        // Constructor
        public Pathway()
        {
            cheapestP = 0;
            cheapestM = 0;
            cheapestD = 0;
            courseID = 0;
            profileID = 0;
            unitsLeft = 0;
            pointsAchieved = 0;
            pointsNeeded = 0;
        }

        // fields for cheapest route
        private int courseID;

	    public int CourseID
	    {
		    get { return courseID;}
		    set { courseID = value;}
	    }
	
        private int profileID;

	    public int ProfileID
	    {
		    get { return profileID;}
		    set { profileID = value;}
	    }
	
        private int unitsLeft;

        public int UnitsLeft
        {
            get { return unitsLeft; }
            set { unitsLeft = value; }
        }

        private int pointsAchieved;

        public int PointsAchieved
        {
            get { return pointsAchieved; }
            set { pointsAchieved = value; }
        }

        private int pointsNeeded;

        public int PointsNeeded
        {
            get { return pointsNeeded; }
            set { pointsNeeded = value; }
        }
        
        
        // fields for alternative pathways
        private int cheapestP;

        public int CheapestP
        {
            get { return cheapestP; }
            set { cheapestP = value; }
        }

        private int cheapestM;

        public int CheapestM
        {
            get { return cheapestM; }
            set { cheapestM = value; }
        }

        private int cheapestD;

        public int CheapestD
        {
            get { return cheapestD; }
            set { cheapestD = value; }
        }

        // Cheapest
        public int[] Cheapest()
        {
            EdexcelDefaults defaults = new EdexcelDefaults();
            int pV = defaults.PassPoints;
            int mV = defaults.MeritPoints;
            int dV = defaults.DistinctionPoints;
            int defaultCreditValue = defaults.DefaultCredit;
            int i = 0;
            int j =0;
            int k = 0;
            int pointsValueTotal = 0;
            int passSet = 0;
            int meritSet = 0;
            int distinctionSet = 0;
            bool canMeetGrade = false;
            bool gradeSet = false;
            int x = 0;
            int y = 0;
            int z = 0;

            // Begin processing
            x = unitsLeft;
            y = pointsNeeded - pointsAchieved;
            z = defaultCreditValue;

            i = x;

            // -- check if can meet with pass
            if ((x * pV * z) > y)
            {
                canMeetGrade = true;
            }

            passSet = 0;
            meritSet = 0;
            distinctionSet = 0;

            // -- Grade not met by passes
            // -- Loop down through combinations
            if (!canMeetGrade)
            {
                for (i = x; i >= 0; i--) // i start brace
                {
                    for (j = (x - 1); j >= 0; j--) // j start brace
                    {
                        k = (x - (i + j));
                        pointsValueTotal = (i * pV * z) + (j * mV * z) + (k * dV * z); // -- current combination value
                        if (pointsValueTotal >= y)
                        {
                            // -- break? and return?

                            if (!gradeSet)
                            {
                                passSet = i;
                                meritSet = j;
                                distinctionSet = k;
                                
                                // -- set grade true
                                gradeSet = true;
                            } // -- if end brace
                            canMeetGrade = true;
                        } // -- end if
                    } // -- j end brace
                } // -- i end brace
            }
            // -- fill array values
            if (canMeetGrade)
            {
                int[] tempArray = new int[3];

                // -- try out initialised varables
                tempArray[0] = passSet;
                tempArray[1] = meritSet;
                tempArray[2] = distinctionSet;

                cheapestP = passSet;
                cheapestM = meritSet;
                cheapestD = distinctionSet;

                return tempArray;
            }
            else
            {
                // -- cannot meet grade with current grades
                // -- return fail array with marker element
                int[] tempArrayFail = new int[3];
                tempArrayFail[0] = 999;
                tempArrayFail[1] = 0;
                tempArrayFail[2] = 0;
                return tempArrayFail;
            }

        }
        
        // returns alternative profiles calculated
        // from cheapest pathway
        #region Alternative
        public string Alternative()
        {
            int p = cheapestP;
            int m = CheapestM;
            int d = cheapestD;

            StringBuilder sb = new StringBuilder();
            string pString;
            string mString;
            string dString;

            sb.Append("Alternative profiles");
            sb.AppendLine();
            sb.AppendLine();
            if (p > d)
            {
                while (d > 0)
                {
                    p = p - 1;
                    m = m + 2;
                    d = d - 1;

                    // -- format with leading zeros here
                    // -- Pass
                    if (p < 10)
                    {
                        pString = "0" + p.ToString();
                    }
                    else
                    {
                        pString = p.ToString();
                    }
                    // -- Merit
                    if (m < 10)
                    {
                        mString = "0" + m.ToString();
                    }

                    else
                    {
                        mString = m.ToString();
                    }
                    // -- Distinction
                    if (d < 10)
                    {
                        dString = "0" + d.ToString();
                    }
                    else
                    {
                        dString = d.ToString();
                    }

                    sb.Append("P: " + pString + "  M: " + mString + "  D: " + dString);
                    sb.AppendLine();
                }
            }
            else
            {
                while (p > 0)
                {
                    p = p - 1;
                    m = m + 2;
                    d = d - 1;

                    // -- format with leading zeros here
                    // -- Pass
                    if (p < 10)
                    {
                        pString = "0" + p.ToString();
                    }
                    else
                    {
                        pString = p.ToString();
                    }
                    // -- Merit
                    if (m < 10)
                    {
                        mString = "0" + m.ToString();
                    }

                    else
                    {
                        mString = m.ToString();
                    }
                    // -- Distinction
                    if (d < 10)
                    {
                        dString = "0" + d.ToString();
                    }
                    else
                    {
                        dString = d.ToString();
                    }

                    //sb.AppendLine();
                    sb.Append("P: " + pString + "  M: " + mString + "  D: " + dString);
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        } 
        #endregion
    }
}
