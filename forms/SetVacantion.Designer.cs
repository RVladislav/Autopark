namespace Autopark
{
    partial class frmSetVacantion
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
            this.btnNo = new System.Windows.Forms.Button();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVacantions = new System.Windows.Forms.ComboBox();
            this.ds = new Autopark.ds();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workerTableAdapter = new Autopark.dsTableAdapters.WorkerTableAdapter();
            this.vacationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacationTableAdapter = new Autopark.dsTableAdapters.VacationTableAdapter();
            this.btnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNo.Location = new System.Drawing.Point(184, 96);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(156, 23);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "Снять с должности";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbWorker
            // 
            this.cmbWorker.DataSource = this.workerBindingSource;
            this.cmbWorker.DisplayMember = "fio";
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(12, 29);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(328, 21);
            this.cmbWorker.TabIndex = 1;
            this.cmbWorker.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Работник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Должность";
            // 
            // cmbVacantions
            // 
            this.cmbVacantions.DataSource = this.vacationBindingSource;
            this.cmbVacantions.DisplayMember = "Name";
            this.cmbVacantions.FormattingEnabled = true;
            this.cmbVacantions.Location = new System.Drawing.Point(12, 69);
            this.cmbVacantions.Name = "cmbVacantions";
            this.cmbVacantions.Size = new System.Drawing.Size(328, 21);
            this.cmbVacantions.TabIndex = 4;
            this.cmbVacantions.ValueMember = "id";
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.ds;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // vacationBindingSource
            // 
            this.vacationBindingSource.DataMember = "Vacation";
            this.vacationBindingSource.DataSource = this.ds;
            // 
            // vacationTableAdapter
            // 
            this.vacationTableAdapter.ClearBeforeFill = true;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnYes.Location = new System.Drawing.Point(12, 96);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(166, 23);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "Поставить на должность";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // frmSetVacantion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 127);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.cmbVacantions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.btnNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetVacantion";
            this.Text = "Должность";
            this.Load += new System.EventHandler(this.frmSetVacantion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVacantions;
        private ds ds;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private dsTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.BindingSource vacationBindingSource;
        private dsTableAdapters.VacationTableAdapter vacationTableAdapter;
        private System.Windows.Forms.Button btnYes;
    }
}