namespace HomeWork1.Forms
{

    internal partial class HomeWork1MainForm
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.task1GroupBox = new System.Windows.Forms.GroupBox();
            this.task1PrimesTextBox = new System.Windows.Forms.TextBox();
            this.task1MLabel = new System.Windows.Forms.Label();
            this.task1MValueTextBox = new System.Windows.Forms.TextBox();
            this.task2GroupBox = new System.Windows.Forms.GroupBox();
            this.task2ReducedResidueSystemElementsTextBox = new System.Windows.Forms.TextBox();
            this.task2MValueTextBox = new System.Windows.Forms.TextBox();
            this.task2MLabel = new System.Windows.Forms.Label();
            this.task3GroupBox = new System.Windows.Forms.GroupBox();
            this.task3EulerFunctionValueLabel = new System.Windows.Forms.Label();
            this.task3EulerFunctionLabel = new System.Windows.Forms.Label();
            this.task3MLabel = new System.Windows.Forms.Label();
            this.task3MValueTextBox = new System.Windows.Forms.TextBox();
            this.task4GroupBox = new System.Windows.Forms.GroupBox();
            this.task4XValueLabel = new System.Windows.Forms.Label();
            this.task4DescriptionLabel2 = new System.Windows.Forms.Label();
            this.task4BLabel = new System.Windows.Forms.Label();
            this.task4XLabel = new System.Windows.Forms.Label();
            this.task4ALabel = new System.Windows.Forms.Label();
            this.task4GLabel = new System.Windows.Forms.Label();
            this.task4DescriptionLabel1 = new System.Windows.Forms.Label();
            this.task4BValueTextBox = new System.Windows.Forms.TextBox();
            this.task4AValueTextBox = new System.Windows.Forms.TextBox();
            this.task4GValueTextBox = new System.Windows.Forms.TextBox();
            this.task1GroupBox.SuspendLayout();
            this.task2GroupBox.SuspendLayout();
            this.task3GroupBox.SuspendLayout();
            this.task4GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // task1GroupBox
            // 
            this.task1GroupBox.Controls.Add(this.task1PrimesTextBox);
            this.task1GroupBox.Controls.Add(this.task1MLabel);
            this.task1GroupBox.Controls.Add(this.task1MValueTextBox);
            this.task1GroupBox.Location = new System.Drawing.Point(12, 12);
            this.task1GroupBox.Name = "task1GroupBox";
            this.task1GroupBox.Size = new System.Drawing.Size(300, 200);
            this.task1GroupBox.TabIndex = 0;
            this.task1GroupBox.TabStop = false;
            this.task1GroupBox.Text = "Task 1: primes that lower than m";
            // 
            // task1PrimesTextBox
            // 
            this.task1PrimesTextBox.Location = new System.Drawing.Point(6, 45);
            this.task1PrimesTextBox.Multiline = true;
            this.task1PrimesTextBox.Name = "task1PrimesTextBox";
            this.task1PrimesTextBox.ReadOnly = true;
            this.task1PrimesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.task1PrimesTextBox.Size = new System.Drawing.Size(288, 149);
            this.task1PrimesTextBox.TabIndex = 5;
            // 
            // task1MLabel
            // 
            this.task1MLabel.AutoSize = true;
            this.task1MLabel.Location = new System.Drawing.Point(6, 22);
            this.task1MLabel.Name = "task1MLabel";
            this.task1MLabel.Size = new System.Drawing.Size(24, 13);
            this.task1MLabel.TabIndex = 1;
            this.task1MLabel.Text = "m =";
            // 
            // task1MValueTextBox
            // 
            this.task1MValueTextBox.Location = new System.Drawing.Point(36, 19);
            this.task1MValueTextBox.Name = "task1MValueTextBox";
            this.task1MValueTextBox.Size = new System.Drawing.Size(258, 20);
            this.task1MValueTextBox.TabIndex = 0;
            this.task1MValueTextBox.TextChanged += new System.EventHandler(this.task1MValueTextBox_TextChanged);
            // 
            // task2GroupBox
            // 
            this.task2GroupBox.Controls.Add(this.task2ReducedResidueSystemElementsTextBox);
            this.task2GroupBox.Controls.Add(this.task2MValueTextBox);
            this.task2GroupBox.Controls.Add(this.task2MLabel);
            this.task2GroupBox.Location = new System.Drawing.Point(318, 12);
            this.task2GroupBox.Name = "task2GroupBox";
            this.task2GroupBox.Size = new System.Drawing.Size(300, 200);
            this.task2GroupBox.TabIndex = 1;
            this.task2GroupBox.TabStop = false;
            this.task2GroupBox.Text = "Task 2: reduced residue system of m";
            // 
            // task2ReducedResidueSystemElementsTextBox
            // 
            this.task2ReducedResidueSystemElementsTextBox.Location = new System.Drawing.Point(6, 45);
            this.task2ReducedResidueSystemElementsTextBox.Multiline = true;
            this.task2ReducedResidueSystemElementsTextBox.Name = "task2ReducedResidueSystemElementsTextBox";
            this.task2ReducedResidueSystemElementsTextBox.ReadOnly = true;
            this.task2ReducedResidueSystemElementsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.task2ReducedResidueSystemElementsTextBox.Size = new System.Drawing.Size(288, 149);
            this.task2ReducedResidueSystemElementsTextBox.TabIndex = 6;
            // 
            // task2MValueTextBox
            // 
            this.task2MValueTextBox.Location = new System.Drawing.Point(36, 19);
            this.task2MValueTextBox.Name = "task2MValueTextBox";
            this.task2MValueTextBox.Size = new System.Drawing.Size(258, 20);
            this.task2MValueTextBox.TabIndex = 3;
            this.task2MValueTextBox.TextChanged += new System.EventHandler(this.task2MValueTextBox_TextChanged);
            // 
            // task2MLabel
            // 
            this.task2MLabel.AutoSize = true;
            this.task2MLabel.Location = new System.Drawing.Point(6, 22);
            this.task2MLabel.Name = "task2MLabel";
            this.task2MLabel.Size = new System.Drawing.Size(24, 13);
            this.task2MLabel.TabIndex = 4;
            this.task2MLabel.Text = "m =";
            // 
            // task3GroupBox
            // 
            this.task3GroupBox.Controls.Add(this.task3EulerFunctionValueLabel);
            this.task3GroupBox.Controls.Add(this.task3EulerFunctionLabel);
            this.task3GroupBox.Controls.Add(this.task3MLabel);
            this.task3GroupBox.Controls.Add(this.task3MValueTextBox);
            this.task3GroupBox.Location = new System.Drawing.Point(12, 218);
            this.task3GroupBox.Name = "task3GroupBox";
            this.task3GroupBox.Size = new System.Drawing.Size(300, 140);
            this.task3GroupBox.TabIndex = 1;
            this.task3GroupBox.TabStop = false;
            this.task3GroupBox.Text = "Task 3: Euler\'s function at m";
            // 
            // task3EulerFunctionValueLabel
            // 
            this.task3EulerFunctionValueLabel.AutoSize = true;
            this.task3EulerFunctionValueLabel.Location = new System.Drawing.Point(47, 44);
            this.task3EulerFunctionValueLabel.Name = "task3EulerFunctionValueLabel";
            this.task3EulerFunctionValueLabel.Size = new System.Drawing.Size(0, 13);
            this.task3EulerFunctionValueLabel.TabIndex = 6;
            // 
            // task3EulerFunctionLabel
            // 
            this.task3EulerFunctionLabel.AutoSize = true;
            this.task3EulerFunctionLabel.Location = new System.Drawing.Point(3, 44);
            this.task3EulerFunctionLabel.Name = "task3EulerFunctionLabel";
            this.task3EulerFunctionLabel.Size = new System.Drawing.Size(38, 13);
            this.task3EulerFunctionLabel.TabIndex = 5;
            this.task3EulerFunctionLabel.Text = "φ(m) =";
            // 
            // task3MLabel
            // 
            this.task3MLabel.AutoSize = true;
            this.task3MLabel.Location = new System.Drawing.Point(6, 24);
            this.task3MLabel.Name = "task3MLabel";
            this.task3MLabel.Size = new System.Drawing.Size(24, 13);
            this.task3MLabel.TabIndex = 4;
            this.task3MLabel.Text = "m =";
            // 
            // task3MValueTextBox
            // 
            this.task3MValueTextBox.Location = new System.Drawing.Point(36, 21);
            this.task3MValueTextBox.Name = "task3MValueTextBox";
            this.task3MValueTextBox.Size = new System.Drawing.Size(258, 20);
            this.task3MValueTextBox.TabIndex = 3;
            this.task3MValueTextBox.TextChanged += new System.EventHandler(this.task3MValueTextBox_TextChanged);
            // 
            // task4GroupBox
            // 
            this.task4GroupBox.Controls.Add(this.task4XValueLabel);
            this.task4GroupBox.Controls.Add(this.task4DescriptionLabel2);
            this.task4GroupBox.Controls.Add(this.task4BLabel);
            this.task4GroupBox.Controls.Add(this.task4XLabel);
            this.task4GroupBox.Controls.Add(this.task4ALabel);
            this.task4GroupBox.Controls.Add(this.task4GLabel);
            this.task4GroupBox.Controls.Add(this.task4DescriptionLabel1);
            this.task4GroupBox.Controls.Add(this.task4BValueTextBox);
            this.task4GroupBox.Controls.Add(this.task4AValueTextBox);
            this.task4GroupBox.Controls.Add(this.task4GValueTextBox);
            this.task4GroupBox.Location = new System.Drawing.Point(318, 218);
            this.task4GroupBox.Name = "task4GroupBox";
            this.task4GroupBox.Size = new System.Drawing.Size(300, 140);
            this.task4GroupBox.TabIndex = 1;
            this.task4GroupBox.TabStop = false;
            this.task4GroupBox.Text = "Task 4: discrete logarithm in the ring of deductions";
            // 
            // task4XValueLabel
            // 
            this.task4XValueLabel.AutoSize = true;
            this.task4XValueLabel.Location = new System.Drawing.Point(33, 119);
            this.task4XValueLabel.Name = "task4XValueLabel";
            this.task4XValueLabel.Size = new System.Drawing.Size(0, 13);
            this.task4XValueLabel.TabIndex = 9;
            // 
            // task4DescriptionLabel2
            // 
            this.task4DescriptionLabel2.AutoSize = true;
            this.task4DescriptionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.task4DescriptionLabel2.Location = new System.Drawing.Point(118, 17);
            this.task4DescriptionLabel2.Name = "task4DescriptionLabel2";
            this.task4DescriptionLabel2.Size = new System.Drawing.Size(10, 12);
            this.task4DescriptionLabel2.TabIndex = 8;
            this.task4DescriptionLabel2.Text = "x";
            // 
            // task4BLabel
            // 
            this.task4BLabel.AutoSize = true;
            this.task4BLabel.Location = new System.Drawing.Point(6, 95);
            this.task4BLabel.Name = "task4BLabel";
            this.task4BLabel.Size = new System.Drawing.Size(22, 13);
            this.task4BLabel.TabIndex = 7;
            this.task4BLabel.Text = "b =";
            // 
            // task4XLabel
            // 
            this.task4XLabel.AutoSize = true;
            this.task4XLabel.Location = new System.Drawing.Point(6, 119);
            this.task4XLabel.Name = "task4XLabel";
            this.task4XLabel.Size = new System.Drawing.Size(21, 13);
            this.task4XLabel.TabIndex = 6;
            this.task4XLabel.Text = "x =";
            // 
            // task4ALabel
            // 
            this.task4ALabel.AutoSize = true;
            this.task4ALabel.Location = new System.Drawing.Point(6, 69);
            this.task4ALabel.Name = "task4ALabel";
            this.task4ALabel.Size = new System.Drawing.Size(22, 13);
            this.task4ALabel.TabIndex = 5;
            this.task4ALabel.Text = "a =";
            // 
            // task4GLabel
            // 
            this.task4GLabel.AutoSize = true;
            this.task4GLabel.Location = new System.Drawing.Point(6, 43);
            this.task4GLabel.Name = "task4GLabel";
            this.task4GLabel.Size = new System.Drawing.Size(22, 13);
            this.task4GLabel.TabIndex = 4;
            this.task4GLabel.Text = "g =";
            // 
            // task4DescriptionLabel1
            // 
            this.task4DescriptionLabel1.AutoSize = true;
            this.task4DescriptionLabel1.Location = new System.Drawing.Point(6, 24);
            this.task4DescriptionLabel1.Name = "task4DescriptionLabel1";
            this.task4DescriptionLabel1.Size = new System.Drawing.Size(217, 13);
            this.task4DescriptionLabel1.TabIndex = 3;
            this.task4DescriptionLabel1.Text = "Solving equation g ≡ a  (mod b) [variable: x]";
            // 
            // task4BValueTextBox
            // 
            this.task4BValueTextBox.Location = new System.Drawing.Point(34, 92);
            this.task4BValueTextBox.Name = "task4BValueTextBox";
            this.task4BValueTextBox.Size = new System.Drawing.Size(260, 20);
            this.task4BValueTextBox.TabIndex = 2;
            this.task4BValueTextBox.TextChanged += new System.EventHandler(this.task4BValueTextBox_TextChanged);
            // 
            // task4AValueTextBox
            // 
            this.task4AValueTextBox.Location = new System.Drawing.Point(34, 66);
            this.task4AValueTextBox.Name = "task4AValueTextBox";
            this.task4AValueTextBox.Size = new System.Drawing.Size(260, 20);
            this.task4AValueTextBox.TabIndex = 1;
            this.task4AValueTextBox.TextChanged += new System.EventHandler(this.task4AValueTextBox_TextChanged);
            // 
            // task4GValueTextBox
            // 
            this.task4GValueTextBox.Location = new System.Drawing.Point(34, 40);
            this.task4GValueTextBox.Name = "task4GValueTextBox";
            this.task4GValueTextBox.Size = new System.Drawing.Size(260, 20);
            this.task4GValueTextBox.TabIndex = 0;
            this.task4GValueTextBox.TextChanged += new System.EventHandler(this.task4GValueTextBox_TextChanged);
            // 
            // HomeWork1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 370);
            this.Controls.Add(this.task2GroupBox);
            this.Controls.Add(this.task3GroupBox);
            this.Controls.Add(this.task4GroupBox);
            this.Controls.Add(this.task1GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.HomeWork1Form_HelpButtonClicked);
            this.Icon = global::HomeWork1.Properties.Resources.LockIcon;
            this.Load += new System.EventHandler(this.HomeWork1Form_Load);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomeWork1Form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework #1";
            this.task1GroupBox.ResumeLayout(false);
            this.task1GroupBox.PerformLayout();
            this.task2GroupBox.ResumeLayout(false);
            this.task2GroupBox.PerformLayout();
            this.task3GroupBox.ResumeLayout(false);
            this.task3GroupBox.PerformLayout();
            this.task4GroupBox.ResumeLayout(false);
            this.task4GroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        #region Controls

        private System.Windows.Forms.GroupBox task1GroupBox;
        private System.Windows.Forms.Label task1MLabel;
        private System.Windows.Forms.TextBox task1MValueTextBox;
        private System.Windows.Forms.TextBox task1PrimesTextBox;
        private System.Windows.Forms.GroupBox task2GroupBox;
        private System.Windows.Forms.Label task2MLabel;
        private System.Windows.Forms.TextBox task2MValueTextBox;
        private System.Windows.Forms.TextBox task2ReducedResidueSystemElementsTextBox;
        private System.Windows.Forms.GroupBox task3GroupBox;
        private System.Windows.Forms.Label task3MLabel;
        private System.Windows.Forms.TextBox task3MValueTextBox;
        private System.Windows.Forms.Label task3EulerFunctionLabel;
        private System.Windows.Forms.Label task3EulerFunctionValueLabel;
        private System.Windows.Forms.GroupBox task4GroupBox;
        private System.Windows.Forms.Label task4DescriptionLabel1;
        private System.Windows.Forms.Label task4DescriptionLabel2;
        private System.Windows.Forms.Label task4GLabel;
        private System.Windows.Forms.TextBox task4GValueTextBox;
        private System.Windows.Forms.Label task4ALabel;
        private System.Windows.Forms.TextBox task4AValueTextBox;
        private System.Windows.Forms.Label task4BLabel;
        private System.Windows.Forms.TextBox task4BValueTextBox;
        private System.Windows.Forms.Label task4XLabel;
        private System.Windows.Forms.Label task4XValueLabel;

        #endregion

    }

}