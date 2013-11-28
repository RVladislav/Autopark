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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.классическийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модернToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbtnAboutProduction = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbtnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAdmin = new System.Windows.Forms.ToolStripSplitButton();
            this.автобусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автобусыМаршрутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиАвтобусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиВакансииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVacation = new System.Windows.Forms.Label();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblBus = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.ds = new Autopark.ds();
            this.toolStrip.SuspendLayout();
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
            this.toolStripDropDownButton1,
            this.toolbtnAboutProduction,
            this.toolAdmin});
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
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.классическийToolStripMenuItem,
            this.модернToolStripMenuItem,
            this.индиToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripDropDownButton1.Text = "Скин";
            // 
            // классическийToolStripMenuItem
            // 
            this.классическийToolStripMenuItem.Name = "классическийToolStripMenuItem";
            this.классическийToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.классическийToolStripMenuItem.Text = "Классический";
            // 
            // модернToolStripMenuItem
            // 
            this.модернToolStripMenuItem.Name = "модернToolStripMenuItem";
            this.модернToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.модернToolStripMenuItem.Text = "Модерн";
            // 
            // индиToolStripMenuItem
            // 
            this.индиToolStripMenuItem.Name = "индиToolStripMenuItem";
            this.индиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.индиToolStripMenuItem.Text = "Инди";
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
            // toolAdmin
            // 
            this.toolAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автобусыToolStripMenuItem,
            this.работникиToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.маршрутыToolStripMenuItem,
            this.тОToolStripMenuItem,
            this.автобусыМаршрутыToolStripMenuItem,
            this.работникиАвтобусыToolStripMenuItem,
            this.работникиВакансииToolStripMenuItem});
            this.toolAdmin.Image = ((System.Drawing.Image)(resources.GetObject("toolAdmin.Image")));
            this.toolAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAdmin.Name = "toolAdmin";
            this.toolAdmin.Size = new System.Drawing.Size(110, 22);
            this.toolAdmin.Text = "Администратор";
            this.toolAdmin.Visible = false;
            this.toolAdmin.ButtonClick += new System.EventHandler(this.toolAdmin_ButtonClick);
            // 
            // автобусыToolStripMenuItem
            // 
            this.автобусыToolStripMenuItem.Name = "автобусыToolStripMenuItem";
            this.автобусыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.автобусыToolStripMenuItem.Text = "Автобусы";
            this.автобусыToolStripMenuItem.Click += new System.EventHandler(this.автобусыToolStripMenuItem_Click);
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.работникиToolStripMenuItem.Text = "Работники";
            this.работникиToolStripMenuItem.Click += new System.EventHandler(this.работникиToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // маршрутыToolStripMenuItem
            // 
            this.маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
            this.маршрутыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.маршрутыToolStripMenuItem.Text = "Маршруты";
            this.маршрутыToolStripMenuItem.Click += new System.EventHandler(this.маршрутыToolStripMenuItem_Click);
            // 
            // тОToolStripMenuItem
            // 
            this.тОToolStripMenuItem.Name = "тОToolStripMenuItem";
            this.тОToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.тОToolStripMenuItem.Text = "ТО";
            this.тОToolStripMenuItem.Click += new System.EventHandler(this.тОToolStripMenuItem_Click);
            // 
            // автобусыМаршрутыToolStripMenuItem
            // 
            this.автобусыМаршрутыToolStripMenuItem.Name = "автобусыМаршрутыToolStripMenuItem";
            this.автобусыМаршрутыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.автобусыМаршрутыToolStripMenuItem.Text = "Автобусы -> Маршруты";
            this.автобусыМаршрутыToolStripMenuItem.Click += new System.EventHandler(this.автобусыМаршрутыToolStripMenuItem_Click);
            // 
            // работникиАвтобусыToolStripMenuItem
            // 
            this.работникиАвтобусыToolStripMenuItem.Name = "работникиАвтобусыToolStripMenuItem";
            this.работникиАвтобусыToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.работникиАвтобусыToolStripMenuItem.Text = "Работники -> Автобусы";
            this.работникиАвтобусыToolStripMenuItem.Click += new System.EventHandler(this.работникиАвтобусыToolStripMenuItem_Click);
            // 
            // работникиВакансииToolStripMenuItem
            // 
            this.работникиВакансииToolStripMenuItem.Name = "работникиВакансииToolStripMenuItem";
            this.работникиВакансииToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.работникиВакансииToolStripMenuItem.Text = "Работники -> Вакансии";
            this.работникиВакансииToolStripMenuItem.Click += new System.EventHandler(this.работникиВакансииToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 462);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(785, 0);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.label5);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.label3);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblVacation);
            this.pnlMenu.Controls.Add(this.lblWorker);
            this.pnlMenu.Controls.Add(this.lblBus);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(167, 437);
            this.pnlMenu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "ТО на автобусы";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "На маршруте";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Водители";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.dgvMain.Size = new System.Drawing.Size(612, 436);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMain_DataBindingComplete);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(606, 3);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(179, 20);
            this.txtFind.TabIndex = 4;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // lblFind
            // 
            this.lblFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Автопарк";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
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
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblVacation;
        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Label lblBus;
        private System.Windows.Forms.ToolStripMenuItem toolbtnWorker;
        private System.Windows.Forms.ToolStripMenuItem toolbtnVacation;
        private System.Windows.Forms.ToolStripMenuItem новыйМаршрутToolStripMenuItem;
        private ds ds;
        private System.Windows.Forms.ToolStripMenuItem новоеСервисноеОбслуживаниеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem классическийToolStripMenuItem;
        public System.Windows.Forms.ToolStripSplitButton toolAdmin;
        private System.Windows.Forms.ToolStripMenuItem автобусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автобусыМаршрутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиАвтобусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиВакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модернToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индиToolStripMenuItem;
    }
}

