using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_vxk165930
{
    public partial class Evaluation : Form
    {
        /*Input file and output file variable names*/
        private string inputFilename;
        private string outputFilename;
        /*The dictionary stores the data that is needed to be stored on to a file specified by the user*/
        Dictionary<String, String> saveResults = new Dictionary<String, String>();

        public Evaluation()
        {
            InitializeComponent();
           
        }

        /*This method is invoked whenever the application is opened first*/
        private void Evaluation_Load(object sender, EventArgs e)
        {
            lblInstructions.Text = "Instructions to the User:\n*Please select the file to evaluate using Browse File(or)\n" +
                "*Enter the filename with full path and click Open File\n" +
                "*Click Evaluate to get the results\n" +
                "*Click Save to save the results to a file";
            lblError.Text = "";
            saveBtn.Enabled = false;
            evalBtn.Enabled = false;
            resetBtn.Enabled = false;
            
        }

        /*This method is invoked whenever the user presses the Open button*/
        private void openBtn_Click(object sender, EventArgs e)
        {
             if (txtFileName.Text == "")
            {
                resetForm();
                lblError.Text = "Please enter the file name or Select using Browse button!";
                txtFileName.Focus();
            }
            else if (!System.IO.File.Exists(txtFileName.Text))
            {
                String fileName = txtFileName.Text;
                resetForm();
                txtFileName.Text = fileName;
                lblError.Text = "The File you are trying to open doen't exist!";
                txtFileName.Focus();
            }
            else
            {
                lblError.Text = "";
                evalBtn.Enabled = true;
            }
        }

        /*This method is invoked whenever the user presses the Browse button*/
        private void browseBtn_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
            ofd.Filter= "Text Files|*.txt";
            ofd.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            ofd.ShowDialog();
            txtFileName.Text = ofd.FileName;
            if (txtFileName.Text == "")
            {
                resetForm();
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "";
                evalBtn.Enabled = true;
            }
           
            
        }

        /*This method is invoked whenever the user presses the Evaluate button*/
        private void evalBtn_Click(object sender, EventArgs e)
        {

           
            if (txtFileName.Text == "")
            {
                lblError.Text = "Please enter the file name or Select using Browse button!";
                txtFileName.Focus();
            }
            else if(!System.IO.File.Exists(txtFileName.Text))
            {
                lblError.Text = "The File you are trying to open doen't exist!";
                txtFileName.Focus();
            }
            else
            {
                inputFilename = txtFileName.Text;
                EvaluateService service = new EvaluateService();
                List<RecordDetails> allRecords = service.readData(inputFilename);
                if (allRecords==null || allRecords.Count == 0)
                {
                    lblError.Text = "Error! Incorrect file selected. Please select correct input file";
                    return;
                }
                Dictionary<String, String> evaluationResults = service.evaluationDetails(allRecords);
                /*Saving evaluation results so that they can can be written to a file*/
                saveResults = evaluationResults; 
                /*Diplaying the evaluation results*/
                numRec.Text = ":" + evaluationResults["records"];
                minEntry.Text = ":" + evaluationResults["minEntry"];
                maxEntry.Text = ":" + evaluationResults["maxEntry"];
                avgEntry.Text = ":" + evaluationResults["avgEntry"];
                minInt.Text = ":" + evaluationResults["minInt"];
                maxInt.Text = ":" + evaluationResults["maxInt"];
                avgInt.Text = ":" + evaluationResults["avgInt"];
                totalTime.Text = ":" + evaluationResults["totalTime"];
                bsCount.Text = ":" + evaluationResults["bsCount"];
                resetBtn.Enabled = true;
                saveBtn.Enabled = true;
            }
        }

        /*This method is invoked whenever the user presses the Save button*/
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".txt";
            sfd.Filter = "Text Files|*.txt|All files|*.*";
            sfd.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            sfd.ShowDialog();
            outputFilename = sfd.FileName;
            if (outputFilename=="")
            {
                return;
            }
            if(saveResults==null || saveResults.Count == 0)
            {
                return;
            }
            
                EvaluateService saveService = new EvaluateService();
                saveService.writeData(saveResults, outputFilename);       
            
        }


        /*This method is invoked whenever the user presses the Reset button*/
        private void resetBtn_Click(object sender, EventArgs e)
        {

            resetForm();
        }

        /*This method is invoked to reset the form whenever required*/
        private void resetForm()
        {
            txtFileName.Text = "";
            numRec.Text = ":";
            minEntry.Text = ":";
            maxEntry.Text = ":";
            avgEntry.Text = ":";
            minInt.Text = ":";
            maxInt.Text = ":";
            avgInt.Text = ":";
            totalTime.Text = ":";
            bsCount.Text = ":";
            saveBtn.Enabled = false;
            evalBtn.Enabled = false;
            saveResults = null;
            lblError.Text = "";
        }

        /*This method is invoked whenever the user presses a key in the text box field*/
        private void startFillUp(object sender, KeyPressEventArgs e)
        {
            resetBtn.Enabled = true;
        }

       
    }
}
