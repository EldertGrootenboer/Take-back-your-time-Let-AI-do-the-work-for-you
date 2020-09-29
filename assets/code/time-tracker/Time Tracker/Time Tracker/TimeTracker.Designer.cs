namespace Time_Tracker
{
    partial class TimeTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTracker));
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelBillable = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.checkBoxBillable = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(122, 206);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(99, 32);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmitClick);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(3, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(59, 25);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(89, 3);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(227, 30);
            this.textBoxDate.TabIndex = 3;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelDate, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxDate, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelHours, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.labelTask, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.labelBillable, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxTask, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxHours, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.checkBoxBillable, 1, 4);
            this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(319, 169);
            this.tableLayoutPanel.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name:";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(3, 108);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(70, 25);
            this.labelHours.TabIndex = 5;
            this.labelHours.Text = "Hours:";
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(3, 72);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(62, 25);
            this.labelTask.TabIndex = 6;
            this.labelTask.Text = "Task:";
            // 
            // labelBillable
            // 
            this.labelBillable.AutoSize = true;
            this.labelBillable.Location = new System.Drawing.Point(3, 144);
            this.labelBillable.Name = "labelBillable";
            this.labelBillable.Size = new System.Drawing.Size(80, 25);
            this.labelBillable.TabIndex = 7;
            this.labelBillable.Text = "Billable:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(89, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 30);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(89, 75);
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(227, 30);
            this.textBoxTask.TabIndex = 3;
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(89, 111);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(227, 30);
            this.textBoxHours.TabIndex = 3;
            // 
            // checkBoxBillable
            // 
            this.checkBoxBillable.AutoSize = true;
            this.checkBoxBillable.Location = new System.Drawing.Point(89, 147);
            this.checkBoxBillable.Name = "checkBoxBillable";
            this.checkBoxBillable.Size = new System.Drawing.Size(18, 17);
            this.checkBoxBillable.TabIndex = 8;
            this.checkBoxBillable.UseVisualStyleBackColor = true;
            // 
            // TimeTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 249);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.buttonSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeTracker";
            this.Text = "Time Tracker";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelBillable;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.CheckBox checkBoxBillable;
    }
}

