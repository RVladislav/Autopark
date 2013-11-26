namespace Autopark
{
    partial class frmNewService
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
            this.lblBus = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.ds = new Autopark.ds();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.busTableAdapter = new Autopark.dsTableAdapters.BusTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.busBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fchbDone = new System.Windows.Forms.CheckBox();
            this.cmbWhells = new System.Windows.Forms.CheckBox();
            this.cmbControl = new System.Windows.Forms.CheckBox();
            this.cmbStop = new System.Windows.Forms.CheckBox();
            this.cmbInterier = new System.Windows.Forms.CheckBox();
            this.cmbExterier = new System.Windows.Forms.CheckBox();
            this.cmbMotor = new System.Windows.Forms.CheckBox();
            this.cmbRust = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCreate = new System.Windows.Forms.DateTimePicker();
            this.grpTest = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).BeginInit();
            this.grpTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(372, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Location = new System.Drawing.Point(12, 23);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(90, 13);
            this.lblBus.TabIndex = 8;
            this.lblBus.Text = "Номер автобуса";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 89);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(431, 150);
            this.txtDescription.TabIndex = 10;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "Bus";
            this.busBindingSource.DataSource = this.ds;
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Описание";
            // 
            // cmbBus
            // 
            this.cmbBus.DataSource = this.busBindingSource1;
            this.cmbBus.DisplayMember = "number";
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(108, 20);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(171, 21);
            this.cmbBus.TabIndex = 15;
            this.cmbBus.ValueMember = "id";
            // 
            // busBindingSource1
            // 
            this.busBindingSource1.DataMember = "Bus";
            this.busBindingSource1.DataSource = this.ds;
            // 
            // fchbDone
            // 
            this.fchbDone.AutoSize = true;
            this.fchbDone.Location = new System.Drawing.Point(12, 573);
            this.fchbDone.Name = "fchbDone";
            this.fchbDone.Size = new System.Drawing.Size(73, 17);
            this.fchbDone.TabIndex = 16;
            this.fchbDone.Text = "Допущен";
            this.fchbDone.UseVisualStyleBackColor = true;
            // 
            // cmbWhells
            // 
            this.cmbWhells.AutoSize = true;
            this.cmbWhells.Location = new System.Drawing.Point(16, 23);
            this.cmbWhells.Name = "cmbWhells";
            this.cmbWhells.Size = new System.Drawing.Size(63, 17);
            this.cmbWhells.TabIndex = 17;
            this.cmbWhells.Text = "Колёса";
            this.cmbWhells.UseVisualStyleBackColor = true;
            // 
            // cmbControl
            // 
            this.cmbControl.AutoSize = true;
            this.cmbControl.Location = new System.Drawing.Point(16, 46);
            this.cmbControl.Name = "cmbControl";
            this.cmbControl.Size = new System.Drawing.Size(88, 17);
            this.cmbControl.TabIndex = 18;
            this.cmbControl.Text = "Управление";
            this.cmbControl.UseVisualStyleBackColor = true;
            // 
            // cmbStop
            // 
            this.cmbStop.AutoSize = true;
            this.cmbStop.Location = new System.Drawing.Point(16, 69);
            this.cmbStop.Name = "cmbStop";
            this.cmbStop.Size = new System.Drawing.Size(129, 17);
            this.cmbStop.TabIndex = 19;
            this.cmbStop.Text = "Тормозная система";
            this.cmbStop.UseVisualStyleBackColor = true;
            // 
            // cmbInterier
            // 
            this.cmbInterier.AutoSize = true;
            this.cmbInterier.Location = new System.Drawing.Point(16, 138);
            this.cmbInterier.Name = "cmbInterier";
            this.cmbInterier.Size = new System.Drawing.Size(106, 17);
            this.cmbInterier.TabIndex = 22;
            this.cmbInterier.Text = "Внутренний вид";
            this.cmbInterier.UseVisualStyleBackColor = true;
            // 
            // cmbExterier
            // 
            this.cmbExterier.AutoSize = true;
            this.cmbExterier.Location = new System.Drawing.Point(16, 115);
            this.cmbExterier.Name = "cmbExterier";
            this.cmbExterier.Size = new System.Drawing.Size(92, 17);
            this.cmbExterier.TabIndex = 21;
            this.cmbExterier.Text = "Внешний вид";
            this.cmbExterier.UseVisualStyleBackColor = true;
            // 
            // cmbMotor
            // 
            this.cmbMotor.AutoSize = true;
            this.cmbMotor.Location = new System.Drawing.Point(16, 92);
            this.cmbMotor.Name = "cmbMotor";
            this.cmbMotor.Size = new System.Drawing.Size(81, 17);
            this.cmbMotor.TabIndex = 20;
            this.cmbMotor.Text = "Двигатель";
            this.cmbMotor.UseVisualStyleBackColor = true;
            // 
            // cmbRust
            // 
            this.cmbRust.AutoSize = true;
            this.cmbRust.Location = new System.Drawing.Point(16, 161);
            this.cmbRust.Name = "cmbRust";
            this.cmbRust.Size = new System.Drawing.Size(76, 17);
            this.cmbRust.TabIndex = 23;
            this.cmbRust.Text = "Ржавчина";
            this.cmbRust.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Максимальная скорость";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(152, 474);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Дата создания";
            // 
            // dtpCreate
            // 
            this.dtpCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreate.Location = new System.Drawing.Point(99, 507);
            this.dtpCreate.Name = "dtpCreate";
            this.dtpCreate.Size = new System.Drawing.Size(150, 20);
            this.dtpCreate.TabIndex = 27;
            // 
            // grpTest
            // 
            this.grpTest.Controls.Add(this.cmbWhells);
            this.grpTest.Controls.Add(this.cmbControl);
            this.grpTest.Controls.Add(this.cmbStop);
            this.grpTest.Controls.Add(this.cmbMotor);
            this.grpTest.Controls.Add(this.cmbExterier);
            this.grpTest.Controls.Add(this.cmbRust);
            this.grpTest.Controls.Add(this.cmbInterier);
            this.grpTest.Location = new System.Drawing.Point(12, 258);
            this.grpTest.Name = "grpTest";
            this.grpTest.Size = new System.Drawing.Size(200, 188);
            this.grpTest.TabIndex = 28;
            this.grpTest.TabStop = false;
            this.grpTest.Text = "Тесты";
            // 
            // frmNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 606);
            this.Controls.Add(this.grpTest);
            this.Controls.Add(this.dtpCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fchbDone);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewService";
            this.Text = "Новое техническое обслуживание";
            this.Load += new System.EventHandler(this.frmNewService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource1)).EndInit();
            this.grpTest.ResumeLayout(false);
            this.grpTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.TextBox txtDescription;
        private ds ds;
        private System.Windows.Forms.BindingSource busBindingSource;
        private dsTableAdapters.BusTableAdapter busTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.BindingSource busBindingSource1;
        private System.Windows.Forms.CheckBox fchbDone;
        private System.Windows.Forms.CheckBox cmbWhells;
        private System.Windows.Forms.CheckBox cmbControl;
        private System.Windows.Forms.CheckBox cmbStop;
        private System.Windows.Forms.CheckBox cmbInterier;
        private System.Windows.Forms.CheckBox cmbExterier;
        private System.Windows.Forms.CheckBox cmbMotor;
        private System.Windows.Forms.CheckBox cmbRust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCreate;
        private System.Windows.Forms.GroupBox grpTest;
    }
}