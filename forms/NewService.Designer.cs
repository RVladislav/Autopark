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
            this.label1 = new System.Windows.Forms.Label();
            this.chbDone = new System.Windows.Forms.CheckBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(217, 291);
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
            this.txtDescription.Size = new System.Drawing.Size(267, 150);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Допущен";
            // 
            // chbDone
            // 
            this.chbDone.AutoSize = true;
            this.chbDone.Location = new System.Drawing.Point(70, 268);
            this.chbDone.Name = "chbDone";
            this.chbDone.Size = new System.Drawing.Size(15, 14);
            this.chbDone.TabIndex = 12;
            this.chbDone.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(123, 20);
            this.txtNumber.MaxLength = 6;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(156, 20);
            this.txtNumber.TabIndex = 13;
            this.txtNumber.Text = "пример: A000AA";
            this.txtNumber.Click += new System.EventHandler(this.txtNumber_Click);
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
            // frmNewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 328);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.chbDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNewService";
            this.Text = "Новое техническое обслуживание";
            this.Load += new System.EventHandler(this.frmNewService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbDone;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
    }
}