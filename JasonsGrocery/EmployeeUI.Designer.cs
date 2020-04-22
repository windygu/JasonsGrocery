﻿namespace JasonsGrocery
{
    partial class EmployeeUI
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
            this.uxHoursWorked = new System.Windows.Forms.Button();
            this.uxClockIn = new System.Windows.Forms.Button();
            this.uxClockOut = new System.Windows.Forms.Button();
            this.EmployeeIdTextBox = new System.Windows.Forms.TextBox();
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxHoursWorked
            // 
            this.uxHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHoursWorked.Location = new System.Drawing.Point(131, 30);
            this.uxHoursWorked.Margin = new System.Windows.Forms.Padding(2);
            this.uxHoursWorked.Name = "uxHoursWorked";
            this.uxHoursWorked.Size = new System.Drawing.Size(129, 37);
            this.uxHoursWorked.TabIndex = 0;
            this.uxHoursWorked.Text = "HoursWorked";
            this.uxHoursWorked.UseVisualStyleBackColor = true;
            this.uxHoursWorked.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uxClockIn
            // 
            this.uxClockIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClockIn.Location = new System.Drawing.Point(279, 30);
            this.uxClockIn.Margin = new System.Windows.Forms.Padding(2);
            this.uxClockIn.Name = "uxClockIn";
            this.uxClockIn.Size = new System.Drawing.Size(77, 37);
            this.uxClockIn.TabIndex = 1;
            this.uxClockIn.Text = "ClockIn";
            this.uxClockIn.UseVisualStyleBackColor = true;
            // 
            // uxClockOut
            // 
            this.uxClockOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClockOut.Location = new System.Drawing.Point(375, 30);
            this.uxClockOut.Margin = new System.Windows.Forms.Padding(2);
            this.uxClockOut.Name = "uxClockOut";
            this.uxClockOut.Size = new System.Drawing.Size(94, 37);
            this.uxClockOut.TabIndex = 2;
            this.uxClockOut.Text = "ClockOut";
            this.uxClockOut.UseVisualStyleBackColor = true;
            // 
            // EmployeeIdTextBox
            // 
            this.EmployeeIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIdTextBox.Location = new System.Drawing.Point(12, 41);
            this.EmployeeIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeIdTextBox.Name = "EmployeeIdTextBox";
            this.EmployeeIdTextBox.Size = new System.Drawing.Size(95, 26);
            this.EmployeeIdTextBox.TabIndex = 4;
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Location = new System.Drawing.Point(14, 81);
            this.uxDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(506, 223);
            this.uxDataGrid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "EmployeeID:";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 324);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EmployeeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 366);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDataGrid);
            this.Controls.Add(this.EmployeeIdTextBox);
            this.Controls.Add(this.uxClockOut);
            this.Controls.Add(this.uxClockIn);
            this.Controls.Add(this.uxHoursWorked);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeUI";
            this.Text = "BossUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeUI_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxHoursWorked;
        private System.Windows.Forms.Button uxClockIn;
        private System.Windows.Forms.Button uxClockOut;
        private System.Windows.Forms.TextBox EmployeeIdTextBox;
        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
    }
}