﻿namespace Autopark
{
    partial class frmNewWorker
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
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpYearsold = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkYears = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHobbies = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chbVeter = new System.Windows.Forms.CheckBox();
            this.chbOne = new System.Windows.Forms.CheckBox();
            this.chbDisability = new System.Windows.Forms.CheckBox();
            this.chbManychildren = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbVacation = new System.Windows.Forms.ComboBox();
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Autopark.ds();
            this.vacationTableAdapter = new Autopark.dsTableAdapters.VacationTableAdapter();
            this.btnNewVacation = new System.Windows.Forms.Button();
            this.chbCar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(380, 483);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ФИО";
            // 
            // txtFIO
            // 
            this.txtFIO.Location = new System.Drawing.Point(107, 6);
            this.txtFIO.Name = "txtFIO";
            this.txtFIO.Size = new System.Drawing.Size(284, 20);
            this.txtFIO.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата рождения";
            // 
            // dtpYearsold
            // 
            this.dtpYearsold.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYearsold.Location = new System.Drawing.Point(132, 54);
            this.dtpYearsold.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtpYearsold.Name = "dtpYearsold";
            this.dtpYearsold.Size = new System.Drawing.Size(150, 20);
            this.dtpYearsold.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Стаж";
            // 
            // txtWorkYears
            // 
            this.txtWorkYears.Location = new System.Drawing.Point(132, 80);
            this.txtWorkYears.Name = "txtWorkYears";
            this.txtWorkYears.Size = new System.Drawing.Size(150, 20);
            this.txtWorkYears.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Кантактный телефон";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(132, 106);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(150, 20);
            this.txtTel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Семейное положение";
            // 
            // cmbFamily
            // 
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Items.AddRange(new object[] {
            "В браке",
            "Открыт(а) для знакомств",
            "Неопределено"});
            this.cmbFamily.Location = new System.Drawing.Point(136, 139);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.Size = new System.Drawing.Size(146, 21);
            this.cmbFamily.TabIndex = 17;
            this.cmbFamily.Text = "Выберите";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Хобби";
            // 
            // txtHobbies
            // 
            this.txtHobbies.Location = new System.Drawing.Point(12, 279);
            this.txtHobbies.Multiline = true;
            this.txtHobbies.Name = "txtHobbies";
            this.txtHobbies.Size = new System.Drawing.Size(362, 68);
            this.txtHobbies.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Льготы";
            // 
            // chbVeter
            // 
            this.chbVeter.AutoSize = true;
            this.chbVeter.Location = new System.Drawing.Point(84, 167);
            this.chbVeter.Name = "chbVeter";
            this.chbVeter.Size = new System.Drawing.Size(68, 17);
            this.chbVeter.TabIndex = 21;
            this.chbVeter.Text = "Ветеран";
            this.chbVeter.UseVisualStyleBackColor = true;
            // 
            // chbOne
            // 
            this.chbOne.AutoSize = true;
            this.chbOne.Location = new System.Drawing.Point(84, 190);
            this.chbOne.Name = "chbOne";
            this.chbOne.Size = new System.Drawing.Size(62, 17);
            this.chbOne.TabIndex = 22;
            this.chbOne.Text = "Сирота";
            this.chbOne.UseVisualStyleBackColor = true;
            // 
            // chbDisability
            // 
            this.chbDisability.AutoSize = true;
            this.chbDisability.Location = new System.Drawing.Point(84, 213);
            this.chbDisability.Name = "chbDisability";
            this.chbDisability.Size = new System.Drawing.Size(70, 17);
            this.chbDisability.TabIndex = 23;
            this.chbDisability.Text = "Инвалид";
            this.chbDisability.UseVisualStyleBackColor = true;
            // 
            // chbManychildren
            // 
            this.chbManychildren.AutoSize = true;
            this.chbManychildren.Location = new System.Drawing.Point(84, 236);
            this.chbManychildren.Name = "chbManychildren";
            this.chbManychildren.Size = new System.Drawing.Size(128, 17);
            this.chbManychildren.TabIndex = 24;
            this.chbManychildren.Text = "Многодетная семья";
            this.chbManychildren.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Примечания";
            // 
            // txtOthers
            // 
            this.txtOthers.Location = new System.Drawing.Point(12, 371);
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(362, 68);
            this.txtOthers.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Должность";
            // 
            // chbVacation
            // 
            this.chbVacation.DataSource = this.vacationBindingSource;
            this.chbVacation.DisplayMember = "Name";
            this.chbVacation.FormattingEnabled = true;
            this.chbVacation.Location = new System.Drawing.Point(132, 28);
            this.chbVacation.Name = "chbVacation";
            this.chbVacation.Size = new System.Drawing.Size(176, 21);
            this.chbVacation.TabIndex = 28;
            this.chbVacation.ValueMember = "id";
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "Vacation";
            this.vacationBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // btnNewVacation
            // 
            this.btnNewVacation.Location = new System.Drawing.Point(314, 28);
            this.btnNewVacation.Name = "btnNewVacation";
            this.btnNewVacation.Size = new System.Drawing.Size(21, 21);
            this.btnNewVacation.TabIndex = 29;
            this.btnNewVacation.Text = "+";
            this.btnNewVacation.UseVisualStyleBackColor = true;
            this.btnNewVacation.Click += new System.EventHandler(this.btnNewVacation_Click);
            // 
            // chbCar
            // 
            this.chbCar.AutoSize = true;
            this.chbCar.Location = new System.Drawing.Point(12, 445);
            this.chbCar.Name = "chbCar";
            this.chbCar.Size = new System.Drawing.Size(133, 17);
            this.chbCar.TabIndex = 30;
            this.chbCar.Text = "Наличие автомобиля";
            this.chbCar.UseVisualStyleBackColor = true;
            // 
            // frmNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 518);
            this.Controls.Add(this.chbCar);
            this.Controls.Add(this.btnNewVacation);
            this.Controls.Add(this.chbVacation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chbManychildren);
            this.Controls.Add(this.chbDisability);
            this.Controls.Add(this.chbOne);
            this.Controls.Add(this.chbVeter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHobbies);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFamily);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWorkYears);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpYearsold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewWorker";
            this.Text = "Новый работник";
            this.Load += new System.EventHandler(this.frmNewWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpYearsold;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkYears;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHobbies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chbVeter;
        private System.Windows.Forms.CheckBox chbOne;
        private System.Windows.Forms.CheckBox chbDisability;
        private System.Windows.Forms.CheckBox chbManychildren;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox chbVacation;
        private ds ds;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private dsTableAdapters.VacationTableAdapter vacationTableAdapter;
        private System.Windows.Forms.Button btnNewVacation;
        private System.Windows.Forms.CheckBox chbCar;
    }
}