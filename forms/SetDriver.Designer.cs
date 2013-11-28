namespace Autopark
{
    partial class frmSetDriver
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
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.allDriversBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new Autopark.ds();
            this.allDriversBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.allDriversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdBus = new System.Windows.Forms.ComboBox();
            this.allDriversBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNo = new System.Windows.Forms.Button();
            this.all_driversTableAdapter = new Autopark.dsTableAdapters.All_driversTableAdapter();
            this.btnYes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDriver
            // 
            this.cmbDriver.DataSource = this.allDriversBindingSource2;
            this.cmbDriver.DisplayMember = "fio";
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(11, 25);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(287, 21);
            this.cmbDriver.TabIndex = 0;
            this.cmbDriver.ValueMember = "Worker_id";
            // 
            // allDriversBindingSource2
            // 
            this.allDriversBindingSource2.DataMember = "All drivers";
            this.allDriversBindingSource2.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allDriversBindingSource1
            // 
            this.allDriversBindingSource1.DataMember = "All drivers";
            this.allDriversBindingSource1.DataSource = this.ds;
            // 
            // allDriversBindingSource
            // 
            this.allDriversBindingSource.DataMember = "All drivers";
            this.allDriversBindingSource.DataSource = this.ds;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Водители";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автобусы";
            // 
            // cmdBus
            // 
            this.cmdBus.DataSource = this.allDriversBindingSource3;
            this.cmdBus.DisplayMember = "number";
            this.cmdBus.FormattingEnabled = true;
            this.cmdBus.Location = new System.Drawing.Point(11, 65);
            this.cmdBus.Name = "cmdBus";
            this.cmdBus.Size = new System.Drawing.Size(287, 21);
            this.cmdBus.TabIndex = 3;
            this.cmdBus.ValueMember = "Bus_id";
            // 
            // allDriversBindingSource3
            // 
            this.allDriversBindingSource3.DataMember = "All drivers";
            this.allDriversBindingSource3.DataSource = this.ds;
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.Location = new System.Drawing.Point(168, 92);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(130, 23);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "Убрать водителя";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // all_driversTableAdapter
            // 
            this.all_driversTableAdapter.ClearBeforeFill = true;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.Location = new System.Drawing.Point(11, 92);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(151, 23);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "Назначить водителем";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // frmSetDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 155);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.cmdBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDriver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetDriver";
            this.Text = "Водители и автобусы";
            this.Load += new System.EventHandler(this.frmSetDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDriversBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdBus;
        private System.Windows.Forms.Button btnNo;
        private ds ds;
        private System.Windows.Forms.BindingSource allDriversBindingSource;
        private Autopark.dsTableAdapters.All_driversTableAdapter all_driversTableAdapter;
        private System.Windows.Forms.BindingSource allDriversBindingSource1;
        private System.Windows.Forms.BindingSource allDriversBindingSource2;
        private System.Windows.Forms.BindingSource allDriversBindingSource3;
        private System.Windows.Forms.Button btnYes;
    }
}