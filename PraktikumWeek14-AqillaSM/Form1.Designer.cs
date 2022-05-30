namespace PraktikumWeek14_AqillaSM
{
    partial class FormTeam
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
            this.ButtonFirst = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTeam = new System.Windows.Forms.Label();
            this.LabelStadium = new System.Windows.Forms.Label();
            this.LabelManager = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LabelWorst = new System.Windows.Forms.Label();
            this.labelTopScorer = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DataGridMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonFirst
            // 
            this.ButtonFirst.Location = new System.Drawing.Point(141, 72);
            this.ButtonFirst.Name = "ButtonFirst";
            this.ButtonFirst.Size = new System.Drawing.Size(118, 61);
            this.ButtonFirst.TabIndex = 0;
            this.ButtonFirst.Text = "<<";
            this.ButtonFirst.UseVisualStyleBackColor = true;
            this.ButtonFirst.Click += new System.EventHandler(this.ButtonFirst_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(277, 72);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(121, 61);
            this.ButtonPrev.TabIndex = 1;
            this.ButtonPrev.Text = "<";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(486, 72);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(121, 61);
            this.ButtonNext.TabIndex = 2;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonLast
            // 
            this.ButtonLast.Location = new System.Drawing.Point(646, 72);
            this.ButtonLast.Name = "ButtonLast";
            this.ButtonLast.Size = new System.Drawing.Size(121, 61);
            this.ButtonLast.TabIndex = 3;
            this.ButtonLast.Text = ">>";
            this.ButtonLast.UseVisualStyleBackColor = true;
            this.ButtonLast.Click += new System.EventHandler(this.ButtonLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team Name :";
            // 
            // LabelTeam
            // 
            this.LabelTeam.AutoSize = true;
            this.LabelTeam.Location = new System.Drawing.Point(377, 178);
            this.LabelTeam.Name = "LabelTeam";
            this.LabelTeam.Size = new System.Drawing.Size(102, 16);
            this.LabelTeam.TabIndex = 5;
            this.LabelTeam.Text = "Manchester City";
            // 
            // LabelStadium
            // 
            this.LabelStadium.AutoSize = true;
            this.LabelStadium.Location = new System.Drawing.Point(377, 283);
            this.LabelStadium.Name = "LabelStadium";
            this.LabelStadium.Size = new System.Drawing.Size(171, 16);
            this.LabelStadium.TabIndex = 6;
            this.LabelStadium.Text = "City of Manchester Stadium,";
            // 
            // LabelManager
            // 
            this.LabelManager.AutoSize = true;
            this.LabelManager.Location = new System.Drawing.Point(377, 231);
            this.LabelManager.Name = "LabelManager";
            this.LabelManager.Size = new System.Drawing.Size(105, 16);
            this.LabelManager.TabIndex = 10;
            this.LabelManager.Text = "Roberto Mancini";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Worst Discipline :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Stadium :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Manager :";
            // 
            // LabelWorst
            // 
            this.LabelWorst.AutoSize = true;
            this.LabelWorst.Location = new System.Drawing.Point(377, 390);
            this.LabelWorst.Name = "LabelWorst";
            this.LabelWorst.Size = new System.Drawing.Size(87, 16);
            this.LabelWorst.TabIndex = 16;
            this.LabelWorst.Text = "James Miner,";
            // 
            // labelTopScorer
            // 
            this.labelTopScorer.AutoSize = true;
            this.labelTopScorer.Location = new System.Drawing.Point(377, 335);
            this.labelTopScorer.Name = "labelTopScorer";
            this.labelTopScorer.Size = new System.Drawing.Size(96, 16);
            this.labelTopScorer.TabIndex = 17;
            this.labelTopScorer.Text = "Cardos Steves";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(282, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 16);
            this.label16.TabIndex = 19;
            this.label16.Text = "Top Scorer :";
            // 
            // DataGridMatch
            // 
            this.DataGridMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMatch.Location = new System.Drawing.Point(141, 424);
            this.DataGridMatch.Name = "DataGridMatch";
            this.DataGridMatch.RowHeadersWidth = 51;
            this.DataGridMatch.RowTemplate.Height = 24;
            this.DataGridMatch.Size = new System.Drawing.Size(626, 283);
            this.DataGridMatch.TabIndex = 22;
            // 
            // FormTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 780);
            this.Controls.Add(this.DataGridMatch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.labelTopScorer);
            this.Controls.Add(this.LabelWorst);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LabelManager);
            this.Controls.Add(this.LabelStadium);
            this.Controls.Add(this.LabelTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonLast);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonFirst);
            this.Name = "FormTeam";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFirst;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelTeam;
        private System.Windows.Forms.Label LabelStadium;
        private System.Windows.Forms.Label LabelManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LabelWorst;
        private System.Windows.Forms.Label labelTopScorer;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView DataGridMatch;
    }
}

