namespace ComputerEngineeringScheduling
{
    partial class MainWindow
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
            this.allClassesLabel = new System.Windows.Forms.Label();
            this.finishedClassesLabel = new System.Windows.Forms.Label();
            this.availableClassesLabel = new System.Windows.Forms.Label();
            this.allClassesList = new System.Windows.Forms.ListBox();
            this.finishedClassesList = new System.Windows.Forms.ListBox();
            this.availableClassesList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allClassesLabel
            // 
            this.allClassesLabel.AutoSize = true;
            this.allClassesLabel.Location = new System.Drawing.Point(12, 9);
            this.allClassesLabel.Name = "allClassesLabel";
            this.allClassesLabel.Size = new System.Drawing.Size(97, 13);
            this.allClassesLabel.TabIndex = 3;
            this.allClassesLabel.Text = "All Avalible Classes";
            // 
            // finishedClassesLabel
            // 
            this.finishedClassesLabel.AutoSize = true;
            this.finishedClassesLabel.Location = new System.Drawing.Point(251, 9);
            this.finishedClassesLabel.Name = "finishedClassesLabel";
            this.finishedClassesLabel.Size = new System.Drawing.Size(77, 13);
            this.finishedClassesLabel.TabIndex = 4;
            this.finishedClassesLabel.Text = "Classes Taken";
            // 
            // availableClassesLabel
            // 
            this.availableClassesLabel.AutoSize = true;
            this.availableClassesLabel.Location = new System.Drawing.Point(499, 9);
            this.availableClassesLabel.Name = "availableClassesLabel";
            this.availableClassesLabel.Size = new System.Drawing.Size(89, 13);
            this.availableClassesLabel.TabIndex = 5;
            this.availableClassesLabel.Text = "Available Classes";
            // 
            // allClassesList
            // 
            this.allClassesList.FormattingEnabled = true;
            this.allClassesList.Location = new System.Drawing.Point(15, 25);
            this.allClassesList.Name = "allClassesList";
            this.allClassesList.Size = new System.Drawing.Size(120, 290);
            this.allClassesList.TabIndex = 0;
            // 
            // finishedClassesList
            // 
            this.finishedClassesList.FormattingEnabled = true;
            this.finishedClassesList.Location = new System.Drawing.Point(254, 25);
            this.finishedClassesList.Name = "finishedClassesList";
            this.finishedClassesList.Size = new System.Drawing.Size(120, 290);
            this.finishedClassesList.TabIndex = 1;
            // 
            // availableClassesList
            // 
            this.availableClassesList.FormattingEnabled = true;
            this.availableClassesList.Location = new System.Drawing.Point(502, 25);
            this.availableClassesList.Name = "availableClassesList";
            this.availableClassesList.Size = new System.Drawing.Size(120, 290);
            this.availableClassesList.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(155, 111);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(155, 168);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 7;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(152, 243);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(93, 13);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = "Info for debugging";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 327);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.availableClassesList);
            this.Controls.Add(this.finishedClassesList);
            this.Controls.Add(this.allClassesList);
            this.Controls.Add(this.availableClassesLabel);
            this.Controls.Add(this.finishedClassesLabel);
            this.Controls.Add(this.allClassesLabel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label allClassesLabel;
        private System.Windows.Forms.Label finishedClassesLabel;
        private System.Windows.Forms.Label availableClassesLabel;
        private System.Windows.Forms.ListBox allClassesList;
        private System.Windows.Forms.ListBox finishedClassesList;
        private System.Windows.Forms.ListBox availableClassesList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label infoLabel;
    }
}