using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradesLab5
{
    public partial class Form1 : Form
    {
        // main interface
        public Form1()
        {
            InitializeComponent();
            ResultStatus.FeasibleResult = false;
            cboCourse.SelectedIndex = 0;
            cboTargetGrade.SelectedIndex = 0;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string[] singleProfiles = { "P", "M", "D", "D*" };
            string[] doubleProfiles = { "PP", "MP", "MM", "DM", "DD", "D*D", "D*D*" };
            string[] tripleProfiles = { "PPP", "MPP", "MMP", "MMM", "DMM", "DDM", "DDD", "D*DD", "D*D*D", "D*D*D*" };

            switch (cboCourse.Text)
            {
                case "Certificate [3 units]":
                    txtCourseUnits.Text = "3";
                    cboTargetGrade.DataSource = singleProfiles;
                    break;
                case "Subsidiary Diploma [6 units]":
                    txtCourseUnits.Text = "6";
                    cboTargetGrade.DataSource = singleProfiles;
                    break;
                case "90 Credit Diploma [9 units]":
                    txtCourseUnits.Text = "9";
                    cboTargetGrade.DataSource = doubleProfiles;
                    break;
                case "Diploma [12 units]":
                    txtCourseUnits.Text = "12";
                    cboTargetGrade.DataSource = doubleProfiles;
                    break;
                case "Extended Diploma [18 units]":
                    txtCourseUnits.Text = "18";
                    cboTargetGrade.DataSource = tripleProfiles;
                    break;
                default:
                    txtCourseUnits.Text = "0";
                    cboTargetGrade.Text = "Select course above";
                    break;
            }

            ResetStudentData();

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open help
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // reset screen data
            ResetStartAgain();
        }

        private void emailReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // send data to text file
        }

        private void cmdSendEmail_Click(object sender, EventArgs e)
        {
            // Open email editor and populate with data
            ProfileOutput myEmailMassage = new ProfileOutput();
            if (!ResultStatus.FeasibleResult)
            {
                MessageBox.Show("No feasible result calculated");
                return;
            }
            
            if (txtEmailTo.Text.Length > 0)
            {
                myEmailMassage.EmailAddress = txtEmailTo.Text;
            }
            else
            {
                MessageBox.Show("No email address entered.");
                return;
            }

            bool validAddress = myEmailMassage.MailAddressValid();
            if (validAddress)
            {
                myEmailMassage.StudRef = txtStudRef.Text;
                myEmailMassage.StudName = txtStudName.Text;
                myEmailMassage.DateCalculated = DateTime.Now;
                myEmailMassage.CourseID = cboCourse.SelectedIndex;
                myEmailMassage.TargetProfileID = cboTargetGrade.SelectedIndex;
                myEmailMassage.PassesHave = Convert.ToInt32(txtPassesHave.Text);
                myEmailMassage.MeritsHave = Convert.ToInt32(txtMeritsHave.Text);
                myEmailMassage.DistinctionsHave = Convert.ToInt32(txtDistinctionsHave.Text);
                myEmailMassage.CanMeetGrade = true;
                myEmailMassage.UnitsLeft = Convert.ToInt32(txtUnitsLeft.Text);
                myEmailMassage.NeedPasses = Convert.ToInt32(txtPassNeeded.Text);
                myEmailMassage.NeedMerits = Convert.ToInt32(txtMeritNeeded.Text);
                myEmailMassage.NeedDistinctions = Convert.ToInt32(txtDistinctionNeeded.Text);
                myEmailMassage.AlternativeProfiles = rtxtAllProfiles.Text;
                myEmailMassage.Notes = rtxtNotes.Text;
                myEmailMassage.MakeEmailMessage();
            }
            else
            {
                MessageBox.Show("Mail address format is not valid");
                return;
            }
            
        }

        private void ResetStudentData()
        {
            //txtPassesHave.Text = "0";

            txtPassNeeded.Text = "0";
            //txtMeritsHave.Text = "0";
            txtMeritNeeded.Text = "0";
            //txtDistinctionsHave.Text = "0";
            txtDistinctionNeeded.Text = "0";
            //txtEmailTo.Text = "";
            lblCanMeetWith.Text = "The Target Grade can be achieved";
            lblWithGradeCounts.Text = "with these grade counts";
            rtxtAllProfiles.Text = "Alternative profiles";
            ResultStatus.FeasibleResult = false;
        }

        private void ResetStartAgain()
        {
            
            txtPassesHave.Text = "0";
            txtPassNeeded.Text = "0";
            txtMeritsHave.Text = "0";
            txtMeritNeeded.Text = "0";
            txtDistinctionsHave.Text = "0";
            txtDistinctionNeeded.Text = "0";
            txtEmailTo.Text = "";
            txtStudRef.Text = "";
            txtStudName.Text = "";
            rtxtNotes.Text = "";
            lblCanMeetWith.Text = "The Target Grade can be achieved";
            lblWithGradeCounts.Text = "with these grade counts";
            rtxtAllProfiles.Text = "Alternative profiles";
            cboCourse.SelectedIndex = 0;
            cboTargetGrade.SelectedIndex = 0;
            ResultStatus.FeasibleResult = false;
        }

        private void cboTargetGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            // clear student and outcome data

            ShowPoints();
            ResetStudentData();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Scenario currentScenario = new Scenario();
            string testStringEntry = string.Empty;
            int testIntegerEntry = 0;

            currentScenario.CourseID = cboCourse.SelectedIndex;
            currentScenario.TargetProfileID = cboTargetGrade.SelectedIndex;

            testStringEntry = txtPassesHave.Text;
            if ((int.TryParse(testStringEntry, out testIntegerEntry)))
            {
                currentScenario.GradedPass = testIntegerEntry;
            }
            else
            {
                currentScenario.GradedPass = 0;
            }

            testStringEntry = txtMeritsHave.Text;
            if ((int.TryParse(testStringEntry, out testIntegerEntry)))
            {
                currentScenario.GradededMerit = testIntegerEntry;
            }
            else
            {
                currentScenario.GradededMerit = 0;
            }

            testStringEntry = txtDistinctionsHave.Text;
            if ((int.TryParse(testStringEntry, out testIntegerEntry)))
            {
                currentScenario.GradedDistinction = testIntegerEntry;
            }
            else
            {
                currentScenario.GradedDistinction = 0;
            }

            // calculate data needed for calculation
            currentScenario.UnitsLeft = currentScenario.CourseUnitsLeft(currentScenario.CourseID);
            currentScenario.PointsGained = currentScenario.CurrentPointsGained();
            currentScenario.PointsNeeded = currentScenario.PointsNeededForProfile();

            // Use generated data to calculate paths
            GradeCountProfile myProfile = new GradeCountProfile();

            // Three element array to hole path and populate
            int[] myArray = new int[3];
            myArray = currentScenario.CheapestPath();

            if (myArray[0] == 999)
            {
                // Cannot meet grade from starting point
                rtxtAllProfiles.Text = "Cannot meet grade from current position";
                lblCanMeetWith.Text = "The Target Grade cannot be achieved";
            }
            else
            {
                
                txtPassNeeded.Text = myArray[0].ToString();
                txtMeritNeeded.Text = myArray[1].ToString();
                txtDistinctionNeeded.Text = myArray[2].ToString();
                rtxtAllProfiles.Text = currentScenario.AllProfiles();
            }
        }

        private void ShowPoints()
        {
            EdexcelData myData = new EdexcelData();
            myData.CourseID = cboCourse.SelectedIndex;
            myData.TargetGradeID = cboTargetGrade.SelectedIndex;

            txtCoursePoints.Text = myData.TargetGradeThreshold().ToString();
            txtUCASPoints.Text = myData.TargetGradeUcas().ToString();

        }

        private void UnitsHaveCheckAndShow()
        {
            ProfileScenario scenario = new ProfileScenario();

            int totalCourseUnits = Convert.ToInt32(txtCourseUnits.Text);
            lblCanMeetWith.Text = "The Target Grade can be achieved";

            int passes = Convert.ToInt32(txtPassesHave.Text);
            int merits = Convert.ToInt32(txtMeritsHave.Text);
            int distinctions = Convert.ToInt32(txtDistinctionsHave.Text);

            scenario.PassesHave = passes;
            scenario.MeritsHave = merits;
            scenario.DistinctionsHave = distinctions;


            int unitsGraded = passes + merits + distinctions;
            int unitsLeft = totalCourseUnits - unitsGraded;

            if (unitsLeft == 0)
            {
                MessageBox.Show("There are no units left to be graded");
                return;
            } else if (unitsLeft < 0)
            {
                MessageBox.Show("Too many graded units entered for selected course");
                return;
            }
            else
            {
                txtUnitsLeft.Text = unitsLeft.ToString();
                txtPointsEarned.Text = scenario.CoursePointsEarned().ToString();
            }

        }

        private void txtPassesHave_TextChanged(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                UnitsHaveCheckAndShow();
            }
        }

        private void txtMeritsHave_TextChanged(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                UnitsHaveCheckAndShow();
            }
        }

        private void txtDistinctionsHave_TextChanged(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                UnitsHaveCheckAndShow();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            MessageBox.Show(appPath);
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileOutput myOutput = new ProfileOutput();
            myOutput.StudRef = txtStudRef.Text;
            myOutput.StudName = txtStudName.Text;
            myOutput.DateCalculated = DateTime.Today;
            myOutput.CourseID = cboCourse.SelectedIndex;
            myOutput.TargetProfileID = cboTargetGrade.SelectedIndex;
            myOutput.PassesHave = Convert.ToInt32(txtPassesHave.Text);
            myOutput.MeritsHave = Convert.ToInt32(txtMeritsHave.Text);
            myOutput.DistinctionsHave = Convert.ToInt32(txtDistinctionsHave.Text);
            myOutput.CanMeetGrade = true;
            myOutput.UnitsLeft = Convert.ToInt32(txtUnitsLeft.Text);
            myOutput.NeedPasses = Convert.ToInt32(txtPassNeeded.Text);
            myOutput.NeedMerits = Convert.ToInt32(txtMeritNeeded.Text);
            myOutput.NeedDistinctions = Convert.ToInt32(txtDistinctionNeeded.Text);
            myOutput.AlternativeProfiles = rtxtAllProfiles.Text;
            myOutput.Notes = rtxtNotes.Text;

            string sClipboard = myOutput.CompileBody();

            Clipboard.SetText(sClipboard);

        }

        private void txtPassesHave_Enter(object sender, EventArgs e)
        {
            txtPassesHave.SelectionStart = 0;
            txtPassesHave.SelectionLength = txtPassesHave.Text.Length;
        }

        private void txtMeritsHave_Enter(object sender, EventArgs e)
        {
            txtMeritsHave.SelectionStart = 0;
            txtMeritsHave.SelectionLength = txtMeritsHave.Text.Length;
        }

        private void txtDistinctionsHave_Enter(object sender, EventArgs e)
        {
            txtDistinctionsHave.SelectionStart = 0;
            txtDistinctionsHave.SelectionLength = txtDistinctionsHave.Text.Length;
        }

        private bool IsValidData()
        {
            if (Validator.IsPresent(cboCourse) &&
                Validator.IsPresent(cboTargetGrade) &&
                Validator.IsPresent(txtPassesHave) &&
                Validator.IsPresent(txtMeritsHave)&&
                Validator.IsPresent(txtDistinctionsHave) &&
                Validator.IsInt32(txtPassesHave) &&
                Validator.IsInt32(txtMeritsHave) &&
                Validator.IsInt32(txtDistinctionsHave))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void helpPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmHelpBrowser = new frmHelpBrowser();
            frmHelpBrowser.Show();
        }
    }
}
