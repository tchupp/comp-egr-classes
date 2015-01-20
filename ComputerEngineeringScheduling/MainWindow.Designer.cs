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
            this.unfinishedCourseLabel = new System.Windows.Forms.Label();
            this.finishedCourseLabel = new System.Windows.Forms.Label();
            this.availableCourseLabel = new System.Windows.Forms.Label();
            this.unfinishedCourseList = new System.Windows.Forms.ListBox();
            this.finishedCourseList = new System.Windows.Forms.ListBox();
            this.availableCourseList = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.currentFilePathLabel = new System.Windows.Forms.Label();
            this.updateCurrentFilePathButton = new System.Windows.Forms.Button();
            this.coursesPathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // unfinishedCourseLabel
            // 
            this.unfinishedCourseLabel.AutoSize = true;
            this.unfinishedCourseLabel.Location = new System.Drawing.Point(12, 9);
            this.unfinishedCourseLabel.Name = "unfinishedCourseLabel";
            this.unfinishedCourseLabel.Size = new System.Drawing.Size(98, 13);
            this.unfinishedCourseLabel.TabIndex = 3;
            this.unfinishedCourseLabel.Text = "Unfinished Courses";
            // 
            // finishedCourseLabel
            // 
            this.finishedCourseLabel.AutoSize = true;
            this.finishedCourseLabel.Location = new System.Drawing.Point(251, 9);
            this.finishedCourseLabel.Name = "finishedCourseLabel";
            this.finishedCourseLabel.Size = new System.Drawing.Size(87, 13);
            this.finishedCourseLabel.TabIndex = 4;
            this.finishedCourseLabel.Text = "Finished Courses";
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
            // unfinishedCourseList
            // 
            this.unfinishedCourseList.FormattingEnabled = true;
            this.unfinishedCourseList.Location = new System.Drawing.Point(15, 25);
            this.unfinishedCourseList.Name = "unfinishedCourseList";
            this.unfinishedCourseList.Size = new System.Drawing.Size(120, 290);
            this.unfinishedCourseList.TabIndex = 0;
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
            // currentFilePathLabel
            // 
            this.currentFilePathLabel.AutoSize = true;
            this.currentFilePathLabel.Location = new System.Drawing.Point(12, 362);
            this.currentFilePathLabel.Name = "currentFilePathLabel";
            this.currentFilePathLabel.Size = new System.Drawing.Size(139, 13);
            this.currentFilePathLabel.TabIndex = 9;
            this.currentFilePathLabel.Text = "currentFilePath Default Text";
            // 
            // updateCurrentFilePathButton
            // 
            this.updateCurrentFilePathButton.Location = new System.Drawing.Point(15, 378);
            this.updateCurrentFilePathButton.Name = "updateCurrentFilePathButton";
            this.updateCurrentFilePathButton.Size = new System.Drawing.Size(120, 39);
            this.updateCurrentFilePathButton.TabIndex = 10;
            this.updateCurrentFilePathButton.Text = "Update Current FilePath";
            this.updateCurrentFilePathButton.UseVisualStyleBackColor = true;
            this.updateCurrentFilePathButton.Click += new System.EventHandler(this.updateCurrentFilePathButton_Click);
            // 
            // coursesPathLabel
            // 
            this.coursesPathLabel.AutoSize = true;
            this.coursesPathLabel.Location = new System.Drawing.Point(12, 349);
            this.coursesPathLabel.Name = "coursesPathLabel";
            this.coursesPathLabel.Size = new System.Drawing.Size(139, 13);
            this.coursesPathLabel.TabIndex = 11;
            this.coursesPathLabel.Text = "Current \"courses.csv\" Path:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 429);
            this.Controls.Add(this.coursesPathLabel);
            this.Controls.Add(this.updateCurrentFilePathButton);
            this.Controls.Add(this.currentFilePathLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.availableCourseList);
            this.Controls.Add(this.finishedCourseList);
            this.Controls.Add(this.unfinishedCourseList);
            this.Controls.Add(this.availableCourseLabel);
            this.Controls.Add(this.finishedCourseLabel);
            this.Controls.Add(this.unfinishedCourseLabel);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unfinishedCourseLabel;
        private System.Windows.Forms.Label finishedCourseLabel;
        private System.Windows.Forms.Label availableCourseLabel;
        private System.Windows.Forms.ListBox unfinishedCourseList;
        private System.Windows.Forms.ListBox finishedCourseList;
        private System.Windows.Forms.ListBox availableCourseList;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label currentFilePathLabel;
        private System.Windows.Forms.Button updateCurrentFilePathButton;
        private System.Windows.Forms.Label coursesPathLabel;
    }
}