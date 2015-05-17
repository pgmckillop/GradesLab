using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Microsoft.Office.Interop.Outlook;
using OutlookApp = Microsoft.Office.Interop.Outlook.Application;



namespace GradesLab5
{
    class ProfileOutput
    {
        private string studRef;

        public string StudRef
        {
            get { return studRef; }
            set { studRef = value; }
        }

        private string studName;

        public string StudName
        {
            get { return studName; }
            set { studName = value; }
        }


        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }
        

        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private DateTime dateCalculated;

        public DateTime DateCalculated
        {
            get { return dateCalculated; }
            set { dateCalculated = value; }
        }

        private int courseID;

        public int CourseID
        {
            get { return courseID; }
            set { courseID = value; }
        }

        private int targetProfileID;

        public int TargetProfileID
        {
            get { return targetProfileID; }
            set { targetProfileID = value; }
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

        private bool canMeetGrade;

        public bool CanMeetGrade
        {
            get { return canMeetGrade; }
            set { canMeetGrade = value; }
        }

        private int unitsLeft;

        public int UnitsLeft
        {
            get { return unitsLeft; }
            set { unitsLeft = value; }
        }
        

        private int needPasses;

        public int NeedPasses
        {
            get { return needPasses; }
            set { needPasses = value; }
        }

        private int needMerits;

        public int NeedMerits
        {
            get { return needMerits; }
            set { needMerits = value; }
        }

        private int needDistinctions;

        public int NeedDistinctions
        {
            get { return needDistinctions; }
            set { needDistinctions = value; }
        }

        private string alternativeProfiles;

        public string AlternativeProfiles
        {
            get { return alternativeProfiles; }
            set { alternativeProfiles = value; }
        }
        
        // Constructor
        public ProfileOutput()
        {
            emailAddress = string.Empty;
        }

        public bool MailAddressValid()
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void MakeEmailMessage()
        {
            OutlookApp outlookApp = new OutlookApp();
            MailItem mailItem = outlookApp.CreateItem(OlItemType.olMailItem);
            string thisMessageBody = CompileBody();

            // Profile scenario data will go in here
            mailItem.To = emailAddress;
            mailItem.CC = "paul.mckillop@iwcollege.ac.uk";
            mailItem.Subject = studName + " Grade and profile tutorial";
            mailItem.Body = thisMessageBody;
            mailItem.Display(true);
       
        }

        public string CompileBody()
        {
            EdexcelData myData = new EdexcelData();
            myData.CourseID = courseID;
            myData.TargetGradeID = targetProfileID;

            string sDateCalculated = String.Format("{0:f}",dateCalculated);
            string sStudRef = studRef;
            string sStudName = studName;
            string sNotes = notes;
            string sCourseName = myData.CourseTitle();
            string sTargetProfile = myData.ProfileTitle();
            string sPassesHave = passesHave.ToString();
            string sMeritsHave = meritsHave.ToString();
            string sDistinctionsHave = distinctionsHave.ToString();
            string sCanMeetGrade = string.Empty;
            if (canMeetGrade)
            {
                sCanMeetGrade = "The Target Profile grade CAN be met from the current position";
            }
            else
            {
                sCanMeetGrade = "The Target Profile grade CANNOT be met from the current position";
            }
            string sLeftToGrade = unitsLeft.ToString();
            string sNeedPasses = needPasses.ToString();
            string sNeedMerits = needMerits.ToString();
            string sNeedDistinctions = needDistinctions.ToString();

            string sNeedProfile = "P: " + sNeedPasses + " M: " + sNeedMerits + " D: " + sNeedDistinctions;

            string sAlternativeProfiles = alternativeProfiles;

            StringBuilder sb = new StringBuilder();
            sb.Append("Target grades tutorial outcomes");
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("Student: ");
            sb.Append(sStudName);
            sb.Append(" ");
            sb.Append(sStudRef);
            sb.AppendLine();
            sb.AppendLine();

            sb.Append("Tutorial date: ");
            sb.Append(sDateCalculated);
            sb.AppendLine();
            sb.AppendLine();

            sb.Append("Course name: ");
            sb.Append(sCourseName);
            sb.AppendLine();
            sb.Append("Target profile calculated: ");
            sb.Append(sTargetProfile);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("Current grades situation:");
            sb.AppendLine();
            sb.Append("Passes completed and graded: ");
            sb.Append(sPassesHave);
            sb.AppendLine();
            sb.Append("Merits completed and graded: ");
            sb.Append(sMeritsHave);
            sb.AppendLine();
            sb.Append("Distinctions completed and graded: ");
            sb.Append(sDistinctionsHave);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("The number of units left to grade is: ");
            sb.Append(sLeftToGrade);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append(sCanMeetGrade);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("The route to the target with the most passes is: ");
            sb.Append(sNeedProfile);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("If there are possible alternative profiles, they are listed here:");
            sb.AppendLine();
            sb.Append(sAlternativeProfiles);
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("Notes:");
            sb.AppendLine();
            sb.Append(notes);
            sb.AppendLine();
            sb.AppendLine();
            sb.AppendLine();
            sb.Append("It is important to note that the paths to the target grade");
            sb.AppendLine();
            sb.Append("must be recalculated whenever graded units are added or changed");


            return sb.ToString();
        }

    }
}
