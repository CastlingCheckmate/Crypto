namespace HomeWork4.Forms
{

    partial class AboutAndInstructionsForm
    {

        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            if (disposing)
            {
                Presenter.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this.aboutLabel = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.instructionsPanel = new System.Windows.Forms.Panel();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.aboutPanel.SuspendLayout();
            this.instructionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutLabel.Location = new System.Drawing.Point(0, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(572, 46);
            this.aboutLabel.TabIndex = 1;
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aboutPanel
            // 
            this.aboutPanel.Controls.Add(this.aboutLabel);
            this.aboutPanel.Location = new System.Drawing.Point(12, 12);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Size = new System.Drawing.Size(572, 46);
            this.aboutPanel.TabIndex = 3;
            // 
            // instructionsPanel
            // 
            this.instructionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.instructionsPanel.Controls.Add(this.instructionsLabel);
            this.instructionsPanel.Location = new System.Drawing.Point(12, 61);
            this.instructionsPanel.Name = "instructionsPanel";
            this.instructionsPanel.Size = new System.Drawing.Size(572, 175);
            this.instructionsPanel.TabIndex = 2;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instructionsLabel.Location = new System.Drawing.Point(0, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(570, 173);
            this.instructionsLabel.TabIndex = 0;
            // 
            // AboutAndInstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 248);
            this.Controls.Add(this.instructionsPanel);
            this.Controls.Add(this.aboutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::HomeWork4.Properties.Resources.LockIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutAndInstructionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About...";
            this.Load += new System.EventHandler(this.AboutAndInstructionsForm_Load);
            this.aboutPanel.ResumeLayout(false);
            this.instructionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Controls

        private System.Windows.Forms.Panel aboutPanel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Panel instructionsPanel;
        private System.Windows.Forms.Label instructionsLabel;

        #endregion

    }

}