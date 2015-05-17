using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesLab5
{
    public class ProfileScenario
    {
        private int currentCourseID;

        public int CourseID
        {
            get { return currentCourseID; }
            set { currentCourseID = value; }
        }

        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }

        private int profileID;

        public int ProfileID
        {
            get { return profileID; }
            set { profileID = value; }
        }

        private string profileName;

        public string ProfileName
        {
            get { return profileName; }
            set { profileName = value; }
        }

        private int passesHave;

        public int PassesHave
        {
            get { return passesHave; }
            set { passesHave = value; }
        }

        private int meritsHave;

        public int MeritsHave
        {
            get { return meritsHave; }
            set { meritsHave = value; }
        }

        private int distinctionsHave;

        public int DistinctionsHave
        {
            get { return distinctionsHave; }
            set { distinctionsHave = value; }
        }

        // Default constructor
        public ProfileScenario()
        {
            this.currentCourseID = 0;
            this.courseName = string.Empty;
            this.profileID = 0;
            this.profileName = string.Empty;
            this.passesHave = 0;
            this.meritsHave = 0;
            this.distinctionsHave = 0;
        }

        public int CoursePointsEarned()
        {
            EdexcelDefaults myDefaults = new EdexcelDefaults();
            return (passesHave * myDefaults.PassPoints * myDefaults.DefaultCredit) + (meritsHave * myDefaults.MeritPoints * myDefaults.DefaultCredit) + (distinctionsHave * myDefaults.DistinctionPoints * myDefaults.DefaultCredit);
        }

        public int UnitsGraded()
        {
            return passesHave + meritsHave + distinctionsHave;
        }
        
        // How many points needed to get threshold from
        // current position
        public int CoursePointsNeeded()
        {
            int pointsNeeded = 0;
            EdexcelData myData = new EdexcelData();
            myData.CourseID = currentCourseID;
            myData.TargetGradeID = profileID;
            
            // Calculate the points needed from data and defaults using haves (CoursePointsEarned).
            int threshold = myData.TargetGradeThreshold();
            int earned = CoursePointsEarned();

            pointsNeeded = threshold - earned;
            
            return pointsNeeded;
        }
        
        // number of units left to be graded
        public int UnitsLeft()
        {
            EdexcelDefaults myDefaults = new EdexcelDefaults();
            int courseUnits = 0;

            switch (currentCourseID)
            {
                case 0:
                    courseUnits = myDefaults.CertificateUnits;
                    break;
                case 1:
                    courseUnits = myDefaults.SubDipUnits;
                    break;
                case 2:
                    courseUnits = myDefaults.NinetyUnits;
                    break;
                case 3:
                    courseUnits = myDefaults.DiplomaUnits;
                    break;
                case 4:
                    courseUnits = myDefaults.ExtendedUnits;
                    break;
                default:
                    break;
            }

            return courseUnits - UnitsGraded();
        }
    }
}
