using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesLab5
{
    class EdexcelData
    {
        private int courseID;

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        private int targetGradeID;

        public int TargetGradeID
        {
            get { return targetGradeID; }
            set { targetGradeID = value; }
        }

        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private string targetGradeName;

        public string TargetGradeName   
        {
            get { return targetGradeName; }
            set { targetGradeName = value; }
        }

        // Constructor
        public EdexcelData()
        {
            this.courseID = 0;
            this.courseName = string.Empty;
            this.targetGradeID = 0;
            this.targetGradeName = string.Empty;
        }

        // Target Grade Threshold returns integer
        #region TargetGradeThreshold
        public int TargetGradeThreshold()
        {
            int myResult = 0;

            switch (courseID)
            { // switch courseID
                case 0:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 210;
                            break;
                        case 1:
                            myResult = 230;
                            break;
                        case 2:
                            myResult = 250;
                            break;
                        case 3:
                            myResult = 260;
                            break;
                        // Trap value
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 1:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 420;
                            break;
                        case 1:
                            myResult = 460;
                            break;
                        case 2:
                            myResult = 500;
                            break;
                        case 3:
                            myResult = 520;
                            break;
                        // trap value
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 2:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 630;
                            break;
                        case 1:
                            myResult = 660;
                            break;
                        case 2:
                            myResult = 690;
                            break;
                        case 3:
                            myResult = 720;
                            break;
                        case 4:
                            myResult = 750;
                            break;
                        case 5:
                            myResult = 770;
                            break;
                        case 6:
                            myResult = 790;
                            break;
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 3:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 840;
                            break;
                        case 1:
                            myResult = 880;
                            break;
                        case 2:
                            myResult = 920;
                            break;
                        case 3:
                            myResult = 960;
                            break;
                        case 4:
                            myResult = 1000;
                            break;
                        case 5:
                            myResult = 1030;
                            break;
                        case 6:
                            myResult = 1060;
                            break;
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 4:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 1260;
                            break;
                        case 1:
                            myResult = 1300;
                            break;
                        case 2:
                            myResult = 1340;
                            break;
                        case 3:
                            myResult = 1380;
                            break;
                        case 4:
                            myResult = 1420;
                            break;
                        case 5:
                            myResult = 1460;
                            break;
                        case 6:
                            myResult = 1500;
                            break;
                        case 7:
                            myResult = 1530;
                            break;
                        case 8:
                            myResult = 1560;
                            break;
                        case 9:
                            myResult = 1590;
                            break;

                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                default:
                    break;
            } // end switch courseID

            return myResult;
        } 
        #endregion

        public string ProfileTitle()
        {
            string myResult = string.Empty;
            switch (courseID)
            { // switch courseID
                case 0:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = "P";
                            break;
                        case 1:
                            myResult = "M";
                            break;
                        case 2:
                            myResult = "D";
                            break;
                        case 3:
                            myResult = "D*";
                            break;
                        // Trap value
                        default:
                            myResult = "X";
                            break;
                    }
                    break;
                case 1:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = "P";
                            break;
                        case 1:
                            myResult = "M";
                            break;
                        case 2:
                            myResult = "D";
                            break;
                        case 3:
                            myResult = "D*";
                            break;
                        // Trap value
                        default:
                            myResult = "X";
                            break;
                    }
                    break;
                case 2:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = "PP";
                            break;
                        case 1:
                            myResult = "MP";
                            break;
                        case 2:
                            myResult = "MM";
                            break;
                        case 3:
                            myResult = "DM";
                            break;
                        case 4:
                            myResult = "DD";
                            break;
                        case 5:
                            myResult = "D*D";
                            break;
                        case 6:
                            myResult = "D*D*";
                            break;
                        default:
                            myResult = "X";
                            break;
                    }
                    break;
                case 3:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = "PP";
                            break;
                        case 1:
                            myResult = "MP";
                            break;
                        case 2:
                            myResult = "MM";
                            break;
                        case 3:
                            myResult = "DM";
                            break;
                        case 4:
                            myResult = "DD";
                            break;
                        case 5:
                            myResult = "D*D";
                            break;
                        case 6:
                            myResult = "D*D*";
                            break;
                        default:
                            myResult = "X";
                            break;
                    }
                    break;
                case 4:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = "PPP";
                            break;
                        case 1:
                            myResult = "MPP";
                            break;
                        case 2:
                            myResult = "MMP";
                            break;
                        case 3:
                            myResult = "MMM";
                            break;
                        case 4:
                            myResult = "DMM";
                            break;
                        case 5:
                            myResult = "DDM";
                            break;
                        case 6:
                            myResult = "DDD";
                            break;
                        case 7:
                            myResult = "D*DD";
                            break;
                        case 8:
                            myResult = "D*D*D";
                            break;
                        case 9:
                            myResult = "D*D*D*";
                            break;

                        default:
                            myResult = "X";
                            break;
                    }
                    break;
                default:
                    break;
            } // end switch courseID

            return myResult;
        }

        // Target grade UCAS points as integer
        #region TargetGradeUcas
        public int TargetGradeUcas()
        {
            int myResult = 0;

            switch (courseID)
            { // switch courseID
                case 0:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 20;
                            break;
                        case 1:
                            myResult = 40;
                            break;
                        case 2:
                            myResult = 60;
                            break;
                        case 3:
                            myResult = 70;
                            break;
                        // Trap value
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 1:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 40;
                            break;
                        case 1:
                            myResult = 80;
                            break;
                        case 2:
                            myResult = 120;
                            break;
                        case 3:
                            myResult = 140;
                            break;
                        // trap value
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 2:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 60;
                            break;
                        case 1:
                            myResult = 100;
                            break;
                        case 2:
                            myResult = 120;
                            break;
                        case 3:
                            myResult = 160;
                            break;
                        case 4:
                            myResult = 180;
                            break;
                        case 5:
                            myResult = 200;
                            break;
                        case 6:
                            myResult = 210;
                            break;
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 3:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 80;
                            break;
                        case 1:
                            myResult = 120;
                            break;
                        case 2:
                            myResult = 160;
                            break;
                        case 3:
                            myResult = 200;
                            break;
                        case 4:
                            myResult = 240;
                            break;
                        case 5:
                            myResult = 260;
                            break;
                        case 6:
                            myResult = 280;
                            break;
                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                case 4:
                    switch (targetGradeID)
                    {
                        case 0:
                            myResult = 120;
                            break;
                        case 1:
                            myResult = 160;
                            break;
                        case 2:
                            myResult = 200;
                            break;
                        case 3:
                            myResult = 240;
                            break;
                        case 4:
                            myResult = 280;
                            break;
                        case 5:
                            myResult = 320;
                            break;
                        case 6:
                            myResult = 360;
                            break;
                        case 7:
                            myResult = 380;
                            break;
                        case 8:
                            myResult = 400;
                            break;
                        case 9:
                            myResult = 420;
                            break;

                        default:
                            myResult = 99;
                            break;
                    }
                    break;
                default:
                    break;
            } // end switch courseID

            return myResult;
        } 
        #endregion

        public string CourseTitle()
        {
            string courseName = string.Empty;
            switch (courseID)
            {
                case 0:
                    courseName = "BTEC Level 3 Certificate [3 units]";
                    break;
                case 1:
                    courseName = "BTEC Level 3 Subsidiary Diploma [6 units]";
                    break;
                case 2:
                    courseName = "BTEC Level 3 90 Credit Diploma [9 units]";
                    break;
                case 3:
                    courseName = "BTEC Level 3 Diploma [12 units]";
                    break;
                case 4:
                    courseName = "BTEC Level 3 Extended Diploma [18 units]";
                    break;
                default:
                    courseName = "Not recognised";
                    break;
            }
            return courseName;
        }

    }
}
