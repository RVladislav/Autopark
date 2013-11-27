namespace Autopark
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolbtnFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnNewBus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnVacation = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйМаршрутToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеСервисноеОбслуживаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnAboutProduction = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toollblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVacation = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.ds = new Autopark.ds();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnFile,
            this.toolbtnEdit,
            this.toolbtnAboutProduction});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(785, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // toolbtnFile
            // 
            this.toolbtnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnExit});
            this.toolbtnFile.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnFile.Image")));
            this.toolbtnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnFile.Name = "toolbtnFile";
            this.toolbtnFile.Size = new System.Drawing.Size(49, 22);
            this.toolbtnFile.Text = "Файл";
            // 
            // toolbtnExit
            // 
            this.toolbtnExit.Name = "toolbtnExit";
            this.toolbtnExit.Size = new System.Drawing.Size(108, 22);
            this.toolbtnExit.Text = "Выход";
            this.toolbtnExit.Click += new System.EventHandler(this.toolbtnExit_Click);
            // 
            // toolbtnEdit
            // 
            this.toolbtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnNewBus,
            this.toolbtnWorker,
            this.toolbtnVacation,
            this.новыйМаршрутToolStripMenuItem,
            this.новоеСервисноеОбслуживаниеToolStripMenuItem});
            this.toolbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnEdit.Image")));
            this.toolbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnEdit.Name = "toolbtnEdit";
            this.toolbtnEdit.Size = new System.Drawing.Size(60, 22);
            this.toolbtnEdit.Text = "Правка";
            // 
            // toolbtnNewBus
            // 
            this.toolbtnNewBus.Name = "toolbtnNewBus";
            this.toolbtnNewBus.Size = new System.Drawing.Size(171, 22);
            this.toolbtnNewBus.Text = "Новый автобус";
            this.toolbtnNewBus.Click += new System.EventHandler(this.toolbtnNewBus_Click);
            // 
            // toolbtnWorker
            // 
            this.toolbtnWorker.Name = "toolbtnWorker";
            this.toolbtnWorker.Size = new System.Drawing.Size(171, 22);
            this.toolbtnWorker.Text = "Новый работник";
            this.toolbtnWorker.Click += new System.EventHandler(this.toolbtnWorker_Click);
            // 
            // toolbtnVacation
            // 
            this.toolbtnVacation.Name = "toolbtnVacation";
            this.toolbtnVacation.Size = new System.Drawing.Size(171, 22);
            this.toolbtnVacation.Text = "Новая должность";
            this.toolbtnVacation.Click += new System.EventHandler(this.toolbtnVacation_Click);
            // 
            // новыйМаршрутToolStripMenuItem
            // 
            this.новыйМаршрутToolStripMenuItem.Name = "новыйМаршрутToolStripMenuItem";
            this.новыйМаршрутToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.новыйМаршрутToolStripMenuItem.Text = "Новый маршрут";
            this.новыйМаршрутToolStripMenuItem.Click += new System.EventHandler(this.новыйМаршрутToolStripMenuItem_Click);
            // 
            // новоеСервисноеОбслуживаниеToolStripMenuItem
            // 
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Name = "новоеСервисноеОбслуживаниеToolStripMenuItem";
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Text = "Новое ТО";
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Click += new System.EventHandler(this.новоеСервисноеОбслуживаниеToolStripMenuItem_Click);
            // 
            // toolbtnAboutProduction
            // 
            this.toolbtnAboutProduction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbtnAboutProduction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbtnHelp});
            this.toolbtnAboutProduction.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnAboutProduction.Image")));
            this.toolbtnAboutProduction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnAboutProduction.Name = "toolbtnAboutProduction";
            this.toolbtnAboutProduction.Size = new System.Drawing.Size(95, 22);
            this.toolbtnAboutProduction.Text = "О программе";
            // 
            // toolbtnHelp
            // 
            this.toolbtnHelp.Name = "toolbtnHelp";
            this.toolbtnHelp.Size = new System.Drawing.Size(123, 22);
            this.toolbtnHelp.Text = "Помощь";
            this.toolbtnHelp.Click += new System.EventHandler(this.toolbtnHelp_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toollblStatus,
            this.toolProgressBar});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 441);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(785, 21);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toollblStatus
            // 
            this.toollblStatus.Name = "toollblStatus";
            this.toollblStatus.Size = new System.Drawing.Size(120, 15);
            this.toollblStatus.Text = "Программа открыта";
            // 
            // toolProgressBar
            // 
            this.toolProgressBar.Margin = new System.Windows.Forms.Padding(10, 3, 1, 3);
            this.toolProgressBar.Name = "toolProgressBar";
            this.toolProgressBar.Size = new System.Drawing.Size(100, 15);
            this.toolProgressBar.Value = 100;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblVacation);
            this.pnlMenu.Controls.Add(this.lblWorker);
            this.pnlMenu.Controls.Add(this.lblBus);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 416);
            this.pnlMenu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "ТО на автобусы";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Маршруты";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVacation
            // 
            this.lblVacation.AutoSize = true;
            this.lblVacation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVacation.Location = new System.Drawing.Point(3, 88);
            this.lblVacation.Name = "lblVacation";
            this.lblVacation.Size = new System.Drawing.Size(112, 24);
            this.lblVacation.TabIndex = 5;
            this.lblVacation.Text = "Должности";
            this.lblVacation.Click += new System.EventHandler(this.lblVacation_Click);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorker.Location = new System.Drawing.Point(3, 50);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(106, 24);
            this.lblWorker.TabIndex = 4;
            this.lblWorker.Text = "Работники";
            this.lblWorker.Click += new System.EventHandler(this.lblWorker_Click);
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBus.Location = new System.Drawing.Point(3, 12);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(98, 24);
            this.lblBus.TabIndex = 3;
            this.lblBus.Text = "Автобусы";
            this.lblBus.Click += new System.EventHandler(this.lblBus_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(173, 26);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(612, 412);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentDoubleClick);
            this.dgvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMain_DataBindingComplete);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(606, 3);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(179, 20);
            this.txtFind.TabIndex = 4;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(562, 6);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(38, 13);
            this.lblFind.TabIndex = 5;
            this.lblFind.Text = "Найти";
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 462);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "frmMain";
            this.Text = "Автопарк";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolbtnFile;
        private System.Windows.Forms.ToolStripMenuItem toolbtnExit;
        private System.Windows.Forms.ToolStripDropDownButton toolbtnEdit;
        private System.Windows.Forms.ToolStripMenuItem toolbtnNewBus;
        private System.Windows.Forms.ToolStripDropDownButton toolbtnAboutProduction;
        private System.Windows.Forms.ToolStripMenuItem toolbtnHelp;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toollblStatus;
        private System.Windows.Forms.ToolStripProgressBar toolProgressBar;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblVacation;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.ToolStripMenuItem toolbtnWorker;
        private System.Windows.Forms.ToolStripMenuItem toolbtnVacation;
        private System.Windows.Forms.ToolStripMenuItem новыйМаршрутToolStripMenuItem;
        private ds ds;
        private System.Windows.Forms.ToolStripMenuItem новоеСервисноеОбслуживаниеToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblFind;
    }
}

