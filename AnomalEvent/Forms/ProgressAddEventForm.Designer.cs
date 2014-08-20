using System;

namespace AnomalEvent
{
	partial class ProgressAddEventForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ClassifiedByComboBox = new System.Windows.Forms.ComboBox();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RegisteredByComboBox = new System.Windows.Forms.ComboBox();
            this.ShortDescription = new System.Windows.Forms.RichTextBox();
            this.reg_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eventDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.butCancel = new System.Windows.Forms.Button();
            this.butOk = new System.Windows.Forms.Button();
            this.Formular = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.CreateReport = new System.Windows.Forms.Button();
            this.OpenReportButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.ClassifiedByComboBox);
            this.mainPanel.Controls.Add(this.DepartmentComboBox);
            this.mainPanel.Controls.Add(this.CategoryComboBox);
            this.mainPanel.Controls.Add(this.RegisteredByComboBox);
            this.mainPanel.Controls.Add(this.ShortDescription);
            this.mainPanel.Controls.Add(this.reg_id);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.eventDate);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(1, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(582, 175);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // ClassifiedByComboBox
            // 
            this.ClassifiedByComboBox.FormattingEnabled = true;
            this.ClassifiedByComboBox.Location = new System.Drawing.Point(446, 60);
            this.ClassifiedByComboBox.Name = "ClassifiedByComboBox";
            this.ClassifiedByComboBox.Size = new System.Drawing.Size(125, 21);
            this.ClassifiedByComboBox.TabIndex = 18;
            this.ClassifiedByComboBox.SelectedIndexChanged += new System.EventHandler(this.ClassifiedByComboBox_SelectedIndexChanged);
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(391, 33);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(181, 21);
            this.DepartmentComboBox.TabIndex = 17;
            this.DepartmentComboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentComboBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(134, 57);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(200, 21);
            this.CategoryComboBox.TabIndex = 16;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // RegisteredByComboBox
            // 
            this.RegisteredByComboBox.FormattingEnabled = true;
            this.RegisteredByComboBox.Location = new System.Drawing.Point(134, 33);
            this.RegisteredByComboBox.Name = "RegisteredByComboBox";
            this.RegisteredByComboBox.Size = new System.Drawing.Size(200, 21);
            this.RegisteredByComboBox.TabIndex = 15;
            this.RegisteredByComboBox.SelectedIndexChanged += new System.EventHandler(this.RegisteredByComboBox_SelectedIndexChanged);
            // 
            // ShortDescription
            // 
            this.ShortDescription.Location = new System.Drawing.Point(14, 101);
            this.ShortDescription.Name = "ShortDescription";
            this.ShortDescription.Size = new System.Drawing.Size(557, 71);
            this.ShortDescription.TabIndex = 14;
            this.ShortDescription.Text = "";
            this.ShortDescription.TextChanged += new System.EventHandler(this.ShortDescription_TextChanged);
            // 
            // reg_id
            // 
            this.reg_id.Location = new System.Drawing.Point(391, 5);
            this.reg_id.Name = "reg_id";
            this.reg_id.Size = new System.Drawing.Size(180, 20);
            this.reg_id.TabIndex = 11;
            this.reg_id.TextChanged += new System.EventHandler(this.reg_id_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Краткое описание события";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Классифицировал";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цех";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Рег. №:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зарегистрировал";
            // 
            // eventDate
            // 
            this.eventDate.Location = new System.Drawing.Point(134, 6);
            this.eventDate.Name = "eventDate";
            this.eventDate.Size = new System.Drawing.Size(200, 20);
            this.eventDate.TabIndex = 1;
            this.eventDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата, время события";
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.Location = new System.Drawing.Point(511, 208);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(61, 23);
            this.butCancel.TabIndex = 2;
            this.butCancel.Text = "Закрыть";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butOk
            // 
            this.butOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butOk.Location = new System.Drawing.Point(461, 208);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(44, 23);
            this.butOk.TabIndex = 3;
            this.butOk.Text = "Ок";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // Formular
            // 
            this.Formular.Location = new System.Drawing.Point(12, 206);
            this.Formular.Name = "Formular";
            this.Formular.Size = new System.Drawing.Size(75, 23);
            this.Formular.TabIndex = 4;
            this.Formular.Text = "Формуляр";
            this.Formular.UseVisualStyleBackColor = true;
            this.Formular.Click += new System.EventHandler(this.Formular_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(209, 206);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(77, 23);
            this.ReportButton.TabIndex = 5;
            this.ReportButton.Text = "Прикрепить";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CreateReport
            // 
            this.CreateReport.Location = new System.Drawing.Point(144, 207);
            this.CreateReport.Name = "CreateReport";
            this.CreateReport.Size = new System.Drawing.Size(59, 23);
            this.CreateReport.TabIndex = 6;
            this.CreateReport.Text = "Создать";
            this.CreateReport.UseVisualStyleBackColor = true;
            this.CreateReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenReportButton
            // 
            this.OpenReportButton.Location = new System.Drawing.Point(292, 207);
            this.OpenReportButton.Name = "OpenReportButton";
            this.OpenReportButton.Size = new System.Drawing.Size(61, 23);
            this.OpenReportButton.TabIndex = 8;
            this.OpenReportButton.Text = "Открыть";
            this.OpenReportButton.UseVisualStyleBackColor = true;
            this.OpenReportButton.Click += new System.EventHandler(this.OpenReportButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(93, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Отчет:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "КорМеры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ProgressAddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OpenReportButton);
            this.Controls.Add(this.CreateReport);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.Formular);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.mainPanel);
            this.Name = "ProgressAddEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание события";
            this.Load += new System.EventHandler(this.ProgressAddEventForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

	    #endregion

        private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button butCancel;
		private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.DateTimePicker eventDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ShortDescription;
        private System.Windows.Forms.TextBox reg_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Formular;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.ComboBox ClassifiedByComboBox;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox RegisteredByComboBox;
        private System.Windows.Forms.Button CreateReport;
        private System.Windows.Forms.Button OpenReportButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;

	}
}