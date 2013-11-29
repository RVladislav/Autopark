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
            this.назначитьВодителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назначитьНаДолжностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTO = new System.Windows.Forms.Button();
            this.btnBusAccess = new System.Windows.Forms.Button();
            this.btnVacationTrue = new System.Windows.Forms.Button();
            this.btnOntheTrack = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnTrack = new System.Windows.Forms.Button();
            this.btnVacations = new System.Windows.Forms.Button();
            this.btnWorkers = new System.Windows.Forms.Button();
            this.btnBus = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.ds = new Autopark.ds();
            this.btnTrackAccess = new System.Windows.Forms.Button();
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
            this.toolAdmin,
            this.txtFind});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(1103, 25);
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
            this.новоеСервисноеОбслуживаниеToolStripMenuItem,
            this.назначитьВодителяToolStripMenuItem,
            this.назначитьНаДолжностьToolStripMenuItem});
            this.toolbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnEdit.Image")));
            this.toolbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnEdit.Name = "toolbtnEdit";
            this.toolbtnEdit.Size = new System.Drawing.Size(60, 22);
            this.toolbtnEdit.Text = "Правка";
            // 
            // toolbtnNewBus
            // 
            this.toolbtnNewBus.Name = "toolbtnNewBus";
            this.toolbtnNewBus.Size = new System.Drawing.Size(211, 22);
            this.toolbtnNewBus.Text = "Новый автобус";
            this.toolbtnNewBus.Click += new System.EventHandler(this.toolbtnNewBus_Click);
            // 
            // toolbtnWorker
            // 
            this.toolbtnWorker.Name = "toolbtnWorker";
            this.toolbtnWorker.Size = new System.Drawing.Size(211, 22);
            this.toolbtnWorker.Text = "Новый работник";
            this.toolbtnWorker.Click += new System.EventHandler(this.toolbtnWorker_Click);
            // 
            // toolbtnVacation
            // 
            this.toolbtnVacation.Name = "toolbtnVacation";
            this.toolbtnVacation.Size = new System.Drawing.Size(211, 22);
            this.toolbtnVacation.Text = "Новая должность";
            this.toolbtnVacation.Click += new System.EventHandler(this.toolbtnVacation_Click);
            // 
            // новыйМаршрутToolStripMenuItem
            // 
            this.новыйМаршрутToolStripMenuItem.Name = "новыйМаршрутToolStripMenuItem";
            this.новыйМаршрутToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.новыйМаршрутToolStripMenuItem.Text = "Новый маршрут";
            this.новыйМаршрутToolStripMenuItem.Click += new System.EventHandler(this.новыйМаршрутToolStripMenuItem_Click);
            // 
            // новоеСервисноеОбслуживаниеToolStripMenuItem
            // 
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Name = "новоеСервисноеОбслуживаниеToolStripMenuItem";
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Text = "Новое ТО";
            this.новоеСервисноеОбслуживаниеToolStripMenuItem.Click += new System.EventHandler(this.новоеСервисноеОбслуживаниеToolStripMenuItem_Click);
            // 
            // назначитьВодителяToolStripMenuItem
            // 
            this.назначитьВодителяToolStripMenuItem.Name = "назначитьВодителяToolStripMenuItem";
            this.назначитьВодителяToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.назначитьВодителяToolStripMenuItem.Text = "Назначить водителя";
            this.назначитьВодителяToolStripMenuItem.Click += new System.EventHandler(this.назначитьВодителяToolStripMenuItem_Click);
            // 
            // назначитьНаДолжностьToolStripMenuItem
            // 
            this.назначитьНаДолжностьToolStripMenuItem.Name = "назначитьНаДолжностьToolStripMenuItem";
            this.назначитьНаДолжностьToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.назначитьНаДолжностьToolStripMenuItem.Text = "Назначить на должность";
            this.назначитьНаДолжностьToolStripMenuItem.Click += new System.EventHandler(this.назначитьНаДолжностьToolStripMenuItem_Click);
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
            // txtFind
            // 
            this.txtFind.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(170, 25);
            this.txtFind.Text = "Поиск";
            this.txtFind.Click += new System.EventHandler(this.txtFind_Click);
            this.txtFind.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(0, 485);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1103, 0);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnTrackAccess);
            this.pnlMenu.Controls.Add(this.btnTO);
            this.pnlMenu.Controls.Add(this.btnBusAccess);
            this.pnlMenu.Controls.Add(this.btnVacationTrue);
            this.pnlMenu.Controls.Add(this.btnOntheTrack);
            this.pnlMenu.Controls.Add(this.btnDrivers);
            this.pnlMenu.Controls.Add(this.btnTrack);
            this.pnlMenu.Controls.Add(this.btnVacations);
            this.pnlMenu.Controls.Add(this.btnWorkers);
            this.pnlMenu.Controls.Add(this.btnBus);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 25);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(227, 460);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnTO
            // 
            this.btnTO.FlatAppearance.BorderSize = 0;
            this.btnTO.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnTO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTO.Location = new System.Drawing.Point(3, 309);
            this.btnTO.Name = "btnTO";
            this.btnTO.Size = new System.Drawing.Size(215, 28);
            this.btnTO.TabIndex = 23;
            this.btnTO.Text = "ТО";
            this.btnTO.UseVisualStyleBackColor = true;
            this.btnTO.Click += new System.EventHandler(this.btnTO_Click);
            // 
            // btnBusAccess
            // 
            this.btnBusAccess.FlatAppearance.BorderSize = 0;
            this.btnBusAccess.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnBusAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBusAccess.Location = new System.Drawing.Point(3, 241);
            this.btnBusAccess.Name = "btnBusAccess";
            this.btnBusAccess.Size = new System.Drawing.Size(215, 28);
            this.btnBusAccess.TabIndex = 22;
            this.btnBusAccess.Text = "Допущенные автобусы";
            this.btnBusAccess.UseVisualStyleBackColor = true;
            this.btnBusAccess.Click += new System.EventHandler(this.btnBusAccess_Click);
            // 
            // btnVacationTrue
            // 
            this.btnVacationTrue.FlatAppearance.BorderSize = 0;
            this.btnVacationTrue.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnVacationTrue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacationTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVacationTrue.Location = new System.Drawing.Point(3, 207);
            this.btnVacationTrue.Name = "btnVacationTrue";
            this.btnVacationTrue.Size = new System.Drawing.Size(215, 28);
            this.btnVacationTrue.TabIndex = 21;
            this.btnVacationTrue.Text = "Должностные";
            this.btnVacationTrue.UseVisualStyleBackColor = true;
            this.btnVacationTrue.Click += new System.EventHandler(this.btnVacationTrue_Click);
            // 
            // btnOntheTrack
            // 
            this.btnOntheTrack.FlatAppearance.BorderSize = 0;
            this.btnOntheTrack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnOntheTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOntheTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOntheTrack.Location = new System.Drawing.Point(3, 173);
            this.btnOntheTrack.Name = "btnOntheTrack";
            this.btnOntheTrack.Size = new System.Drawing.Size(215, 28);
            this.btnOntheTrack.TabIndex = 20;
            this.btnOntheTrack.Text = "На маршруте";
            this.btnOntheTrack.UseVisualStyleBackColor = true;
            this.btnOntheTrack.Click += new System.EventHandler(this.btnOntheTrack_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrivers.Location = new System.Drawing.Point(3, 139);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(215, 28);
            this.btnDrivers.TabIndex = 19;
            this.btnDrivers.Text = "Водители";
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.FlatAppearance.BorderSize = 0;
            this.btnTrack.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrack.Location = new System.Drawing.Point(3, 105);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(215, 28);
            this.btnTrack.TabIndex = 18;
            this.btnTrack.Text = "Маршруты";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // btnVacations
            // 
            this.btnVacations.FlatAppearance.BorderSize = 0;
            this.btnVacations.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnVacations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVacations.Location = new System.Drawing.Point(3, 71);
            this.btnVacations.Name = "btnVacations";
            this.btnVacations.Size = new System.Drawing.Size(215, 28);
            this.btnVacations.TabIndex = 17;
            this.btnVacations.Text = "Должности";
            this.btnVacations.UseVisualStyleBackColor = true;
            this.btnVacations.Click += new System.EventHandler(this.btnVacations_Click);
            // 
            // btnWorkers
            // 
            this.btnWorkers.FlatAppearance.BorderSize = 0;
            this.btnWorkers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWorkers.Location = new System.Drawing.Point(3, 37);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(215, 28);
            this.btnWorkers.TabIndex = 16;
            this.btnWorkers.Text = "Работники";
            this.btnWorkers.UseVisualStyleBackColor = true;
            this.btnWorkers.Click += new System.EventHandler(this.btnWorkers_Click);
            // 
            // btnBus
            // 
            this.btnBus.FlatAppearance.BorderSize = 0;
            this.btnBus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBus.Location = new System.Drawing.Point(3, 3);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(215, 28);
            this.btnBus.TabIndex = 15;
            this.btnBus.Text = "Автобусы";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(225, 25);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(878, 459);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            this.dgvMain.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMain_DataBindingComplete);
            // 
            // ds
            // 
            this.ds.DataSetName = "ds";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnTrackAccess
            // 
            this.btnTrackAccess.FlatAppearance.BorderSize = 0;
            this.btnTrackAccess.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnTrackAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrackAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrackAccess.Location = new System.Drawing.Point(3, 275);
            this.btnTrackAccess.Name = "btnTrackAccess";
            this.btnTrackAccess.Size = new System.Drawing.Size(215, 28);
            this.btnTrackAccess.TabIndex = 24;
            this.btnTrackAccess.Text = "Одобренные маршруты";
            this.btnTrackAccess.UseVisualStyleBackColor = true;
            this.btnTrackAccess.Click += new System.EventHandler(this.btnTrackAccess_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 485);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Автопарк";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem toolbtnWorker;
        private System.Windows.Forms.ToolStripMenuItem toolbtnVacation;
        private System.Windows.Forms.ToolStripMenuItem новыйМаршрутToolStripMenuItem;
        private ds ds;
        private System.Windows.Forms.ToolStripMenuItem новоеСервисноеОбслуживаниеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem классическийToolStripMenuItem;
        public System.Windows.Forms.ToolStripSplitButton toolAdmin;
        private System.Windows.Forms.ToolStripMenuItem автобусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автобусыМаршрутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиАвтобусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиВакансииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модернToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначитьВодителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назначитьНаДолжностьToolStripMenuItem;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnWorkers;
        private System.Windows.Forms.Button btnVacations;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnOntheTrack;
        private System.Windows.Forms.Button btnVacationTrue;
        private System.Windows.Forms.Button btnTO;
        private System.Windows.Forms.Button btnBusAccess;
        private System.Windows.Forms.ToolStripTextBox txtFind;
        private System.Windows.Forms.Button btnTrackAccess;
    }
}

