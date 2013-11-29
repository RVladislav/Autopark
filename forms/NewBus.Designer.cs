namespace Autopark
{
    partial class frmNewBus
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
            this.allDriversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Autopark.ds();
            this.lblTrack = new System.Windows.Forms.Label();
            this.cmbTrack = new System.Windows.Forms.ComboBox();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMark = new System.Windows.Forms.ComboBox();
            this.busBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbTour = new System.Windows.Forms.CheckBox();
            this.cbNew = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.trackTableAdapter = new Autopark.dsTableAdapters.TrackTableAdapter();
            this.all_driversTableAdapter = new Autopark.dsTableAdapters.All_driversTableAdapter();
            this.busTableAdapter = new Autopark.dsTableAdapters.BusTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allDriversBindingSource
            // 
            this.allDriversBindingSource.DataMember = "All drivers";
            this.allDriversBindingSource.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTrack
            // 
            this.lblTrack.AutoSize = true;
            this.lblTrack.Location = new System.Drawing.Point(12, 76);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(52, 13);
            this.lblTrack.TabIndex = 4;
            this.lblTrack.Text = "Маршрут";
            // 
            // cmbTrack
            // 
            this.cmbTrack.BackColor = System.Drawing.SystemColors.Control;
            this.cmbTrack.DataSource = this.trackBindingSource;
            this.cmbTrack.DisplayMember = "Description";
            this.cmbTrack.FormattingEnabled = true;
            this.cmbTrack.Location = new System.Drawing.Point(82, 73);
            this.cmbTrack.Name = "cmbTrack";
            this.cmbTrack.Size = new System.Drawing.Size(261, 21);
            this.cmbTrack.TabIndex = 5;
            this.cmbTrack.ValueMember = "id";
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataMember = "Track";
            this.trackBindingSource.DataSource = this.ds;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(257, 184);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Марка";
            // 
            // cmbMark
            // 
            this.cmbMark.DataSource = this.busBindingSource;
            this.cmbMark.DisplayMember = "mark";
            this.cmbMark.FormattingEnabled = true;
            this.cmbMark.Location = new System.Drawing.Point(82, 37);
            this.cmbMark.Name = "cmbMark";
            this.cmbMark.Size = new System.Drawing.Size(261, 21);
            this.cmbMark.TabIndex = 16;
            this.cmbMark.ValueMember = "id";
            // 
            // busBindingSource
            // 
            this.busBindingSource.DataMember = "Bus";
            this.busBindingSource.DataSource = this.ds;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Туристический";
            // 
            // cbTour
            // 
            this.cbTour.AutoSize = true;
            this.cbTour.Location = new System.Drawing.Point(101, 110);
            this.cbTour.Name = "cbTour";
            this.cbTour.Size = new System.Drawing.Size(15, 14);
            this.cbTour.TabIndex = 18;
            this.cbTour.UseVisualStyleBackColor = true;
            // 
            // cbNew
            // 
            this.cbNew.AutoSize = true;
            this.cbNew.Location = new System.Drawing.Point(101, 138);
            this.cbNew.Name = "cbNew";
            this.cbNew.Size = new System.Drawing.Size(15, 14);
            this.cbNew.TabIndex = 20;
            this.cbNew.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Новый";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Количество сидячих мест";
            // 
            // txtSits
            // 
            this.txtSits.Location = new System.Drawing.Point(155, 165);
            this.txtSits.Name = "txtSits";
            this.txtSits.Size = new System.Drawing.Size(59, 20);
            this.txtSits.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Номер";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(82, 9);
            this.txtNumber.MaxLength = 6;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(59, 20);
            this.txtNumber.TabIndex = 24;
            // 
            // trackTableAdapter
            // 
            this.trackTableAdapter.ClearBeforeFill = true;
            // 
            // all_driversTableAdapter
            // 
            this.all_driversTableAdapter.ClearBeforeFill = true;
            // 
            // busTableAdapter
            // 
            this.busTableAdapter.ClearBeforeFill = true;
            // 
            // frmNewBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 226);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMark);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbTrack);
            this.Controls.Add(this.lblTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewBus";
            this.Text = "Новый автобус";
            this.Load += new System.EventHandler(this.frmNewBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrack;
        private System.Windows.Forms.ComboBox cmbTrack;
        private System.Windows.Forms.Button btnSave;
        private ds ds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTour;
        private System.Windows.Forms.CheckBox cbNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private dsTableAdapters.TrackTableAdapter trackTableAdapter;
        private System.Windows.Forms.BindingSource allDriversBindingSource;
        private dsTableAdapters.All_driversTableAdapter all_driversTableAdapter;
        private System.Windows.Forms.BindingSource busBindingSource;
        private dsTableAdapters.BusTableAdapter busTableAdapter;
    }
}