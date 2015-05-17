using System;
using System.Collections.Generic;
using System.Text;

namespace GradesLab5
{
   
    class Scenario
    {
        public const int passValue = 7;
        public const int meritValue = 8;
        public const int distinctionValue = 9;
        public const int unitCreditValue = 10;

        private int courseID;

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }
        

        private int unitsLeft = 0;

        public int UnitsLeft
        {
            get { return unitsLeft; }
            set { unitsLeft = value; }
        }

        private int pointsGained = 0;

        public int PointsGained
        {
            get { return pointsGained; }
            set { pointsGained = value; }
        }

        private int pointsNeeded = 0;

        public int PointsNeeded
        {
            get { return pointsNeeded; }
            set { pointsNeeded = value; }
        }
        
        
        private int gradedPass = 0;

        public int GradedPass
        {
            get { return gradedPass; }
            set { gradedPass = value; }
        }

        private int gradedMerit = 0;

        public int GradededMerit
        {
            get { return gradedMerit; }
            set { gradedMerit = value; }
        }

        private int gradedDistinction = 0;

        public int GradedDistinction
        {
            get { return gradedDistinction; }
            set { gradedDistinction = value; }
        }


        private int targetProfileID = 0;

        public int TargetProfileID
        {
            get { return targetProfileID; }
            set { targetProfileID = value; }
        }

        private string chepeastRoute;

        public string Cheapest
        {
            get { return chepeastRoute; }
            set { chepeastRoute = value; }
        }

        private string otherRoutes;

        public string OtherRoutes
        {
            get { return otherRoutes; }
            set { otherRoutes = value; }
        }
        
        // Constructor and defaults
        public Scenario()
        {
            ResultStatus.FeasibleResult = false;
        }

        // Calculate current points gained from graded units
        public int CurrentPointsGained()
        {
            int temp = 0;

            temp = gradedPass * passValue * unitCreditValue;
            temp += gradedMerit * meritValue * unitCreditValue;
            temp += gradedDistinction * distinctionValue * unitCreditValue;

            return temp;
        }
        
        
        // Calculate the units left ungraded
        public int CourseUnitsLeft(int idCourse)
        {
            int unitsLeft = 0;
            int checkLeft = 0;
            int certificateUnits = 3;
            int subsidiaryUnits = 6;
            int ninetyUnits = 9;
            int diplomaUnits = 12;
            int extendedUnits = 18;
            int unitsGraded = gradedPass + gradedMerit + gradedDistinction;
            
            // Check course picked
            // need to resolve error feedback
            if (idCourse > -1)
            {
                #region Switch by course
		switch (idCourse)
                {
                    case 0:
                        checkLeft = certificateUnits - unitsGraded;
                        if (checkLeft >= 1)
                        {
                            unitsLeft = checkLeft;
                        }

                        break;
                    case 1:
                        checkLeft = subsidiaryUnits - unitsGraded;
                        if (checkLeft >= 1)
                        {
                            unitsLeft = checkLeft;
                        }
                        break;
                    case 2:
                        checkLeft = ninetyUnits - unitsGraded;
                        if (checkLeft >= 1)
                        {
                            unitsLeft = checkLeft;
                        }
                        break;
                    case 3:
                        checkLeft = diplomaUnits - unitsGraded;
                        if (checkLeft >= 1)
                        {
                            unitsLeft = checkLeft;
                        }
                        break;
                    case 4:
                        checkLeft = extendedUnits - unitsGraded;
                        if (checkLeft >= 1)
                        {
                            unitsLeft = checkLeft;
                        }
                        break; 
	#endregion

                    default:
                        break;
                }
            }
            return unitsLeft;
        }

        // Calculate target points
        public int PointsNeededForProfile()
        {
            // -- Hard coded for proof of concept
            int pointsNeeded = 0;

            if (courseID > -1)
            {
                
                switch (courseID)
                {
                    #region Certificate
                    case 0: // Certificate
                        switch (targetProfileID)
                        {
                            case 0: // P
                                pointsNeeded = 210;
                                break;
                            case 1: // M
                                pointsNeeded = 230;
                                break;
                            case 2: // D
                                pointsNeeded = 250;
                                break;
                            case 3: // D*
                                pointsNeeded = 260;
                                break;
                            default:
                                break;
                        }


                        break;
                    #endregion

                    #region Subsidiary Diploma
                    case 1: // Subsidiary Diploma
                        switch (targetProfileID)
                        {
                            case 0: // P
                                pointsNeeded = 420;
                                break;
                            case 1: // M
                                pointsNeeded = 460;
                                break;
                            case 2: // D
                                pointsNeeded = 500;
                                break;
                            case 3: // D*
                                pointsNeeded = 520;
                                break;
                            default:
                                break;
                        }
                        break;
                    #endregion

                    #region 90 Credit
                    case 2: // 90 Credit Diploma
                        switch (targetProfileID)
                        {

                            case 0: // PP
                                pointsNeeded = 630;
                                break;
                            case 1: // MP
                                pointsNeeded = 660;
                                break;
                            case 2: // MM
                                pointsNeeded = 690;
                                break;
                            case 3: // DM
                                pointsNeeded = 720;
                                break;
                            case 4: // DD
                                pointsNeeded = 750;
                                break;
                            case 5: // D*D
                                pointsNeeded = 770;
                                break;
                            case 6: // D*D*
                                pointsNeeded = 790;
                                break;
                            default:
                                break;
                        } 
                    #endregion
                        break;
                   

                    #region Diploma
                    case 3: // Diploma
                        switch (targetProfileID)
                        {

                            case 0:
                                pointsNeeded = 840;
                                break;
                            case 1:
                                pointsNeeded = 880;
                                break;
                            case 2:
                                pointsNeeded = 920;
                                break;
                            case 3:
                                pointsNeeded = 960;
                                break;
                            case 4:
                                pointsNeeded = 1000;
                                break;
                            case 5:
                                pointsNeeded = 1030;
                                break;
                            case 6:
                                pointsNeeded = 1060;
                                break;
                            default:
                                break;
                        }
                        break;
                    #endregion

                    #region Extended Diploma
                    case 4: // Extended Diploma
                        switch (targetProfileID)
                        {
                            case 0: // PPP
                                pointsNeeded = 1260;
                                break;
                            case 1: // MPP
                                pointsNeeded = 1300;
                                break;
                            case 2: // MMP
                                pointsNeeded = 1340;
                                break;
                            case 3: // MMM
                                pointsNeeded = 1380;
                                break;
                            case 4: // DMM
                                pointsNeeded = 1420;
                                break;
                            case 5: // DDM
                                pointsNeeded = 1460;
                                break;
                            case 6: // DDD
                                pointsNeeded = 1500;
                                break;
                            case 7: // D*DD
                                pointsNeeded = 1530;
                                break;
                            case 8: // D*D*D
                                pointsNeeded = 1560;
                                break;
                            case 9: // D*D*D*
                                pointsNeeded = 1590;
                                break;
                            default:
                                break;
                        }
                        break;
                    #endregion

                    default:
                        break;
                }

            }

            return pointsNeeded;
        }

       
        // Algorithm to calculate path 
        // with Passes optimised.

        public int[] CheapestPath()
        {
            bool profilePossible;
            int x = unitsLeft;
            int y = pointsNeeded - CurrentPointsGained();
            int i = 0;
            int j = 0;
            int k = 0;
            int pointsValueTotal = 0;
            int pV = passValue;
            int mV = meritValue;
            int dV = distinctionValue;
            int uCV = unitCreditValue;

            int[] tempArray = new int[3];

            profilePossible = (x * dV * uCV) >= y;

            if (profilePossible)
            {
                for (i = x; i >= 0; i--)
                { // start i
                    for (j = x - i; j >= 0; j--)
                    { // j start
                        k = (x - (i + j));
                        pointsValueTotal = (i * pV * uCV) + (j * mV * uCV) + (k * dV * uCV);
                        // check if meets standard
                        if (pointsValueTotal >= y)
                        {
                            tempArray[0] = i;
                            tempArray[1] = j;
                            tempArray[2] = k;
                            ResultStatus.FeasibleResult = true;
                            return tempArray;
                        }

                    } // j end
                } // end i
            }
            else
            {
                ResultStatus.FeasibleResult = false;
                tempArray[0] = 999;
                tempArray[1] = 0;
                tempArray[2] = 0;
            }

            // return method
            
            return tempArray;
        }
        
        // Alternative paths to the target grade
        public string AllProfiles()
        {
            StringBuilder sb = new StringBuilder();
            string pString;
            string mString;
            string dString;

            sb.Append("Alternative profiles");
            sb.AppendLine();
            sb.AppendLine();

            int[] myArray = new int[3];
            myArray = CheapestPath();

            if (myArray[0] < 999)
            {
                int p = myArray[0];
                int m = myArray[1];
                int d = myArray[2];

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

            }

            return sb.ToString();
        }


        public string HighestPossibleGrade()
        {
            string tempString = string.Empty;
            // List<Utility.CertificateProfileList> myCertificateList = new List<CertificateProfileList>();



            return tempString;
        }
    }
}
