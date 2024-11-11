namespace INF_UE_Quadratezahlentester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRandomZ = new Label();
            lblDiffifulty = new Label();
            btmNewTest = new Button();
            tbDifficulty = new TrackBar();
            tbEntry = new TextBox();
            btmTest = new Button();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)tbDifficulty).BeginInit();
            SuspendLayout();
            // 
            // lblRandomZ
            // 
            lblRandomZ.AutoSize = true;
            lblRandomZ.Location = new Point(182, 19);
            lblRandomZ.Name = "lblRandomZ";
            lblRandomZ.Size = new Size(25, 32);
            lblRandomZ.TabIndex = 0;
            lblRandomZ.Text = "?";
            // 
            // lblDiffifulty
            // 
            lblDiffifulty.AutoSize = true;
            lblDiffifulty.Location = new Point(634, 105);
            lblDiffifulty.Name = "lblDiffifulty";
            lblDiffifulty.Size = new Size(25, 32);
            lblDiffifulty.TabIndex = 1;
            lblDiffifulty.Text = "?";
            // 
            // btmNewTest
            // 
            btmNewTest.Location = new Point(12, 12);
            btmNewTest.Name = "btmNewTest";
            btmNewTest.Size = new Size(150, 46);
            btmNewTest.TabIndex = 2;
            btmNewTest.Text = "New test ";
            btmNewTest.UseVisualStyleBackColor = true;
            btmNewTest.Click += btmNewTest_Click;
            // 
            // tbDifficulty
            // 
            tbDifficulty.LargeChange = 1;
            tbDifficulty.Location = new Point(498, 12);
            tbDifficulty.Maximum = 100;
            tbDifficulty.Minimum = 10;
            tbDifficulty.Name = "tbDifficulty";
            tbDifficulty.Size = new Size(339, 90);
            tbDifficulty.TabIndex = 3;
            tbDifficulty.Value = 10;
            tbDifficulty.Scroll += tbDifficulty_Scroll;
            // 
            // tbEntry
            // 
            tbEntry.Location = new Point(182, 80);
            tbEntry.Name = "tbEntry";
            tbEntry.Size = new Size(200, 39);
            tbEntry.TabIndex = 4;
            // 
            // btmTest
            // 
            btmTest.Location = new Point(12, 73);
            btmTest.Name = "btmTest";
            btmTest.Size = new Size(150, 46);
            btmTest.TabIndex = 5;
            btmTest.Text = "Test";
            btmTest.UseVisualStyleBackColor = true;
            btmTest.Click += btmTest_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(384, 222);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(25, 32);
            lblResult.TabIndex = 6;
            lblResult.Text = "?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 549);
            Controls.Add(lblResult);
            Controls.Add(btmTest);
            Controls.Add(tbEntry);
            Controls.Add(tbDifficulty);
            Controls.Add(btmNewTest);
            Controls.Add(lblDiffifulty);
            Controls.Add(lblRandomZ);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbDifficulty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRandomZ;
        private Label lblDiffifulty;
        private Button btmNewTest;
        private TrackBar tbDifficulty;
        private TextBox tbEntry;
        private Button btmTest;
        private Label lblResult;
    }
}
