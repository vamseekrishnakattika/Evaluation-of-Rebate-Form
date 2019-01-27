namespace Asg3_vxk165930
{
    partial class Evaluation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.evalBtn = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.labelEval = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bsCount = new System.Windows.Forms.Label();
            this.totalTime = new System.Windows.Forms.Label();
            this.maxInt = new System.Windows.Forms.Label();
            this.avgInt = new System.Windows.Forms.Label();
            this.minInt = new System.Windows.Forms.Label();
            this.avgEntry = new System.Windows.Forms.Label();
            this.minEntry = new System.Windows.Forms.Label();
            this.maxEntry = new System.Windows.Forms.Label();
            this.numRec = new System.Windows.Forms.Label();
            this.lblNumRec = new System.Windows.Forms.Label();
            this.lblBSCount = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblAvgInt = new System.Windows.Forms.Label();
            this.lblMaxInt = new System.Windows.Forms.Label();
            this.lblMinInt = new System.Windows.Forms.Label();
            this.lblAvgTime = new System.Windows.Forms.Label();
            this.lblMaxTime = new System.Windows.Forms.Label();
            this.lblMinTime = new System.Windows.Forms.Label();
            this.labelNumRec = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openBtn);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.resetBtn);
            this.groupBox1.Controls.Add(this.lblSelectFile);
            this.groupBox1.Controls.Add(this.browseBtn);
            this.groupBox1.Location = new System.Drawing.Point(118, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.openBtn.Location = new System.Drawing.Point(118, 61);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(131, 30);
            this.openBtn.TabIndex = 1;
            this.openBtn.Text = "Open File";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(86, 19);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(514, 20);
            this.txtFileName.TabIndex = 0;
            this.txtFileName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFillUp);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resetBtn.Location = new System.Drawing.Point(469, 61);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(131, 30);
            this.resetBtn.TabIndex = 3;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFile.Location = new System.Drawing.Point(6, 22);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(73, 17);
            this.lblSelectFile.TabIndex = 15;
            this.lblSelectFile.Text = "Select File";
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browseBtn.Location = new System.Drawing.Point(294, 61);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(131, 30);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse File";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // evalBtn
            // 
            this.evalBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.evalBtn.Location = new System.Drawing.Point(29, 19);
            this.evalBtn.Name = "evalBtn";
            this.evalBtn.Size = new System.Drawing.Size(131, 30);
            this.evalBtn.TabIndex = 0;
            this.evalBtn.Text = "Evaluate";
            this.evalBtn.UseVisualStyleBackColor = false;
            this.evalBtn.Click += new System.EventHandler(this.evalBtn_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInstructions.Location = new System.Drawing.Point(33, 19);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(80, 17);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "instructions";
            // 
            // labelEval
            // 
            this.labelEval.AutoSize = true;
            this.labelEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEval.Location = new System.Drawing.Point(363, 23);
            this.labelEval.Name = "labelEval";
            this.labelEval.Size = new System.Drawing.Size(83, 20);
            this.labelEval.TabIndex = 0;
            this.labelEval.Text = "Evaluation";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveBtn.Location = new System.Drawing.Point(29, 68);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(131, 30);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bsCount);
            this.groupBox3.Controls.Add(this.totalTime);
            this.groupBox3.Controls.Add(this.maxInt);
            this.groupBox3.Controls.Add(this.avgInt);
            this.groupBox3.Controls.Add(this.minInt);
            this.groupBox3.Controls.Add(this.avgEntry);
            this.groupBox3.Controls.Add(this.minEntry);
            this.groupBox3.Controls.Add(this.maxEntry);
            this.groupBox3.Controls.Add(this.numRec);
            this.groupBox3.Controls.Add(this.lblNumRec);
            this.groupBox3.Controls.Add(this.lblBSCount);
            this.groupBox3.Controls.Add(this.lblTotalTime);
            this.groupBox3.Controls.Add(this.lblAvgInt);
            this.groupBox3.Controls.Add(this.lblMaxInt);
            this.groupBox3.Controls.Add(this.lblMinInt);
            this.groupBox3.Controls.Add(this.lblAvgTime);
            this.groupBox3.Controls.Add(this.lblMaxTime);
            this.groupBox3.Controls.Add(this.lblMinTime);
            this.groupBox3.Controls.Add(this.labelNumRec);
            this.groupBox3.Location = new System.Drawing.Point(118, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 372);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // bsCount
            // 
            this.bsCount.AutoSize = true;
            this.bsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsCount.Location = new System.Drawing.Point(385, 330);
            this.bsCount.Name = "bsCount";
            this.bsCount.Size = new System.Drawing.Size(12, 17);
            this.bsCount.TabIndex = 19;
            this.bsCount.Text = ":";
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTime.Location = new System.Drawing.Point(385, 294);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(12, 17);
            this.totalTime.TabIndex = 18;
            this.totalTime.Text = ":";
            // 
            // maxInt
            // 
            this.maxInt.AutoSize = true;
            this.maxInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxInt.Location = new System.Drawing.Point(385, 218);
            this.maxInt.Name = "maxInt";
            this.maxInt.Size = new System.Drawing.Size(12, 17);
            this.maxInt.TabIndex = 17;
            this.maxInt.Text = ":";
            // 
            // avgInt
            // 
            this.avgInt.AutoSize = true;
            this.avgInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgInt.Location = new System.Drawing.Point(385, 255);
            this.avgInt.Name = "avgInt";
            this.avgInt.Size = new System.Drawing.Size(12, 17);
            this.avgInt.TabIndex = 16;
            this.avgInt.Text = ":";
            // 
            // minInt
            // 
            this.minInt.AutoSize = true;
            this.minInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minInt.Location = new System.Drawing.Point(385, 178);
            this.minInt.Name = "minInt";
            this.minInt.Size = new System.Drawing.Size(12, 17);
            this.minInt.TabIndex = 15;
            this.minInt.Text = ":";
            // 
            // avgEntry
            // 
            this.avgEntry.AutoSize = true;
            this.avgEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgEntry.Location = new System.Drawing.Point(385, 140);
            this.avgEntry.Name = "avgEntry";
            this.avgEntry.Size = new System.Drawing.Size(12, 17);
            this.avgEntry.TabIndex = 14;
            this.avgEntry.Text = ":";
            // 
            // minEntry
            // 
            this.minEntry.AutoSize = true;
            this.minEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minEntry.Location = new System.Drawing.Point(385, 63);
            this.minEntry.Name = "minEntry";
            this.minEntry.Size = new System.Drawing.Size(12, 17);
            this.minEntry.TabIndex = 13;
            this.minEntry.Text = ":";
            // 
            // maxEntry
            // 
            this.maxEntry.AutoSize = true;
            this.maxEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxEntry.Location = new System.Drawing.Point(385, 102);
            this.maxEntry.Name = "maxEntry";
            this.maxEntry.Size = new System.Drawing.Size(12, 17);
            this.maxEntry.TabIndex = 12;
            this.maxEntry.Text = ":";
            // 
            // numRec
            // 
            this.numRec.AutoSize = true;
            this.numRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRec.Location = new System.Drawing.Point(385, 23);
            this.numRec.Name = "numRec";
            this.numRec.Size = new System.Drawing.Size(12, 17);
            this.numRec.TabIndex = 11;
            this.numRec.Text = ":";
            // 
            // lblNumRec
            // 
            this.lblNumRec.AutoSize = true;
            this.lblNumRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRec.Location = new System.Drawing.Point(114, 23);
            this.lblNumRec.Name = "lblNumRec";
            this.lblNumRec.Size = new System.Drawing.Size(126, 17);
            this.lblNumRec.TabIndex = 0;
            this.lblNumRec.Text = "Number of records";
            // 
            // lblBSCount
            // 
            this.lblBSCount.AutoSize = true;
            this.lblBSCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSCount.Location = new System.Drawing.Point(114, 330);
            this.lblBSCount.Name = "lblBSCount";
            this.lblBSCount.Size = new System.Drawing.Size(116, 17);
            this.lblBSCount.TabIndex = 8;
            this.lblBSCount.Text = "Backspace count";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.Location = new System.Drawing.Point(114, 294);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(70, 17);
            this.lblTotalTime.TabIndex = 7;
            this.lblTotalTime.Text = "Total time";
            // 
            // lblAvgInt
            // 
            this.lblAvgInt.AutoSize = true;
            this.lblAvgInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgInt.Location = new System.Drawing.Point(114, 255);
            this.lblAvgInt.Name = "lblAvgInt";
            this.lblAvgInt.Size = new System.Drawing.Size(169, 17);
            this.lblAvgInt.TabIndex = 6;
            this.lblAvgInt.Text = "Average inter-record time";
            // 
            // lblMaxInt
            // 
            this.lblMaxInt.AutoSize = true;
            this.lblMaxInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxInt.Location = new System.Drawing.Point(114, 216);
            this.lblMaxInt.Name = "lblMaxInt";
            this.lblMaxInt.Size = new System.Drawing.Size(174, 17);
            this.lblMaxInt.TabIndex = 5;
            this.lblMaxInt.Text = "Maximum inter-record time";
            // 
            // lblMinInt
            // 
            this.lblMinInt.AutoSize = true;
            this.lblMinInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinInt.Location = new System.Drawing.Point(114, 178);
            this.lblMinInt.Name = "lblMinInt";
            this.lblMinInt.Size = new System.Drawing.Size(171, 17);
            this.lblMinInt.TabIndex = 4;
            this.lblMinInt.Text = "Minimum inter-record time";
            // 
            // lblAvgTime
            // 
            this.lblAvgTime.AutoSize = true;
            this.lblAvgTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgTime.Location = new System.Drawing.Point(114, 140);
            this.lblAvgTime.Name = "lblAvgTime";
            this.lblAvgTime.Size = new System.Drawing.Size(127, 17);
            this.lblAvgTime.TabIndex = 3;
            this.lblAvgTime.Text = "Average entry time";
            // 
            // lblMaxTime
            // 
            this.lblMaxTime.AutoSize = true;
            this.lblMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTime.Location = new System.Drawing.Point(114, 102);
            this.lblMaxTime.Name = "lblMaxTime";
            this.lblMaxTime.Size = new System.Drawing.Size(132, 17);
            this.lblMaxTime.TabIndex = 2;
            this.lblMaxTime.Text = "Maximum entry time";
            // 
            // lblMinTime
            // 
            this.lblMinTime.AutoSize = true;
            this.lblMinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTime.Location = new System.Drawing.Point(114, 63);
            this.lblMinTime.Name = "lblMinTime";
            this.lblMinTime.Size = new System.Drawing.Size(129, 17);
            this.lblMinTime.TabIndex = 1;
            this.lblMinTime.Text = "Minimum entry time";
            // 
            // labelNumRec
            // 
            this.labelNumRec.AutoSize = true;
            this.labelNumRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRec.Location = new System.Drawing.Point(6, 23);
            this.labelNumRec.Name = "labelNumRec";
            this.labelNumRec.Size = new System.Drawing.Size(0, 20);
            this.labelNumRec.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInstructions);
            this.groupBox2.Location = new System.Drawing.Point(118, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(301, 168);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(118, 17);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "Mandatory Check";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.saveBtn);
            this.groupBox4.Controls.Add(this.evalBtn);
            this.groupBox4.Location = new System.Drawing.Point(558, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 114);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelEval);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Evaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluation";
            this.Load += new System.EventHandler(this.Evaluation_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startFillUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button evalBtn;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label labelEval;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lblSelectFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNumRec;
        private System.Windows.Forms.Label lblBSCount;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblAvgInt;
        private System.Windows.Forms.Label lblMaxInt;
        private System.Windows.Forms.Label lblMinInt;
        private System.Windows.Forms.Label lblAvgTime;
        private System.Windows.Forms.Label lblMaxTime;
        private System.Windows.Forms.Label lblMinTime;
        private System.Windows.Forms.Label labelNumRec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label bsCount;
        private System.Windows.Forms.Label totalTime;
        private System.Windows.Forms.Label maxInt;
        private System.Windows.Forms.Label avgInt;
        private System.Windows.Forms.Label minInt;
        private System.Windows.Forms.Label avgEntry;
        private System.Windows.Forms.Label minEntry;
        private System.Windows.Forms.Label maxEntry;
        private System.Windows.Forms.Label numRec;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}