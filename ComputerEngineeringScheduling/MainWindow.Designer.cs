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
            this.allCourseLabel = new System.Windows.Forms.Label();
            this.finishedCourseLabel = new System.Windows.Forms.Label();
            this.availableCourseLabel = new System.Windows.Forms.Label();
            this.allCourseList = new System.Windows.Forms.ListBox();
            this.finishedCourseList = new System.Windows.Forms.ListBox();
            this.availableCourseList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // allCourseLabel
            // 
            this.allCourseLabel.AutoSize = true;
            this.allCourseLabel.Location = new System.Drawing.Point(12, 9);
            this.allCourseLabel.Name = "allCourseLabel";
            this.allCourseLabel.Size = new System.Drawing.Size(99, 13);
            this.allCourseLabel.TabIndex = 3;
            this.allCourseLabel.Text = "All Avalible Courses";
            // 
            // finishedCourseLabel
            // 
            this.finishedCourseLabel.AutoSize = true;
            this.finishedCourseLabel.Location = new System.Drawing.Point(251, 9);
            this.finishedCourseLabel.Name = "finishedCourseLabel";
            this.finishedCourseLabel.Size = new System.Drawing.Size(79, 13);
            this.finishedCourseLabel.TabIndex = 4;
            this.finishedCourseLabel.Text = "Courses Taken";
            // 
            // availableCourseLabel
            // 
            this.availableCourseLabel.AutoSize = true;
            this.availableCourseLabel.Location = new System.Drawing.Point(499, 9);
            this.availableCourseLabel.Name = "availableCourseLabel";
            this.availableCourseLabel.Size = new System.Drawing.Size(91, 13);
            this.availableCourseLabel.TabIndex = 5;
            this.availableCourseLabel.Text = "Available Courses";
            // 
            // allCourseList
            // 
            this.allCourseList.FormattingEnabled = true;
            this.allCourseList.Items.AddRange(new object[] {
            "CSE410",
            "CSE220",
            "CSE335",
            "CSE420"});
            this.allCourseList.Location = new System.Drawing.Point(15, 25);
            this.allCourseList.Name = "allCourseList";
            this.allCourseList.Size = new System.Drawing.Size(120, 290);
            this.allCourseList.TabIndex = 0;
            // 
            // finishedCourseList
            // 
            this.finishedCourseList.FormattingEnabled = true;
            this.finishedCourseList.Location = new System.Drawing.Point(254, 25);
            this.finishedCourseList.Name = "finishedCourseList";
            this.finishedCourseList.Size = new System.Drawing.Size(120, 290);
            this.finishedCourseList.TabIndex = 1;
            // 
            // availableCourseList
            // 
            this.availableCourseList.FormattingEnabled = true;
            this.availableCourseList.Location = new System.Drawing.Point(502, 25);
            this.availableCourseList.Name = "availableCourseList";
            this.availableCourseList.Size = new System.Drawing.Size(120, 290);
            this.availableCourseList.TabIndex = 2;
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
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
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
            this.Controls.Add(this.availableCourseList);
            this.Controls.Add(this.finishedCourseList);
            this.Controls.Add(this.allCourseList);
            this.Controls.Add(this.availableCourseLabel);
            this.Controls.Add(this.finishedCourseLabel);
            this.Controls.Add(this.allCourseLabel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label allCourseLabel;
        private System.Windows.Forms.Label finishedCourseLabel;
        private System.Windows.Forms.Label availableCourseLabel;
        private System.Windows.Forms.ListBox allCourseList;
        private System.Windows.Forms.ListBox finishedCourseList;
        private System.Windows.Forms.ListBox availableCourseList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label infoLabel;
    }
}