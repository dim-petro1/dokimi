
namespace SmartCampingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabMain = new TabControl();
            tabSetup = new TabPage();
            button1 = new Button();
            btnEvaluateSpot = new Button();
            lblSetupStatus = new Label();
            tabLighting = new TabPage();
            lblBrightness = new Label();
            trkBrightness = new TrackBar();
            cmbColor = new ComboBox();
            lblColor = new Label();
            tabEnergy = new TabPage();
            pbBattery = new ProgressBar();
            btnSavingMode = new Button();
            lblPv = new Label();
            lblLoad = new Label();
            tabWeather = new TabPage();
            btnSuggestActions = new Button();
            lblWind = new Label();
            lblHumidity = new Label();
            lblTemp = new Label();
            tabShelter = new TabPage();
            cmbRoute = new ComboBox();
            btnNavigate = new Button();
            tabTourism = new TabPage();
            lstPOIs = new ListBox();
            btnGoPOI = new Button();
            tabOrders = new TabPage();
            lstOrders = new ListBox();
            btnOrder = new Button();
            tabEvents = new TabPage();
            lstEvents = new ListBox();
            btnJoinEvent = new Button();
            tabSettings = new TabPage();
            btnHelp = new Button();
            statusStrip1 = new StatusStrip();
            toolBattery = new ToolStripStatusLabel();
            toolWeather = new ToolStripStatusLabel();
            button2 = new Button();
            tabMain.SuspendLayout();
            tabSetup.SuspendLayout();
            tabLighting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkBrightness).BeginInit();
            tabEnergy.SuspendLayout();
            tabWeather.SuspendLayout();
            tabShelter.SuspendLayout();
            tabTourism.SuspendLayout();
            tabOrders.SuspendLayout();
            tabEvents.SuspendLayout();
            tabSettings.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabSetup);
            tabMain.Controls.Add(tabLighting);
            tabMain.Controls.Add(tabEnergy);
            tabMain.Controls.Add(tabWeather);
            tabMain.Controls.Add(tabShelter);
            tabMain.Controls.Add(tabTourism);
            tabMain.Controls.Add(tabOrders);
            tabMain.Controls.Add(tabEvents);
            tabMain.Controls.Add(tabSettings);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(984, 561);
            tabMain.TabIndex = 0;
            // 
            // tabSetup
            // 
            tabSetup.Controls.Add(button2);
            tabSetup.Controls.Add(button1);
            tabSetup.Controls.Add(btnEvaluateSpot);
            tabSetup.Controls.Add(lblSetupStatus);
            tabSetup.Location = new Point(4, 24);
            tabSetup.Name = "tabSetup";
            tabSetup.Padding = new Padding(3, 3, 3, 3);
            tabSetup.Size = new Size(976, 533);
            tabSetup.TabIndex = 0;
            tabSetup.Text = "🏕️ Στήσιμο";
            tabSetup.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(405, 163);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnEvaluateSpot
            // 
            btnEvaluateSpot.Location = new Point(24, 22);
            btnEvaluateSpot.Name = "btnEvaluateSpot";
            btnEvaluateSpot.Size = new Size(170, 30);
            btnEvaluateSpot.TabIndex = 1;
            btnEvaluateSpot.Text = "Αξιολόγηση Σημείου";
            btnEvaluateSpot.UseVisualStyleBackColor = true;
            btnEvaluateSpot.Click += btnEvaluateSpot_Click;
            // 
            // lblSetupStatus
            // 
            lblSetupStatus.AutoSize = true;
            lblSetupStatus.Location = new Point(24, 67);
            lblSetupStatus.Name = "lblSetupStatus";
            lblSetupStatus.Size = new Size(231, 15);
            lblSetupStatus.TabIndex = 0;
            lblSetupStatus.Text = "Κατάσταση: Δεν έχει ξεκινήσει το στήσιμο.";
            // 
            // tabLighting
            // 
            tabLighting.Controls.Add(lblBrightness);
            tabLighting.Controls.Add(trkBrightness);
            tabLighting.Controls.Add(cmbColor);
            tabLighting.Controls.Add(lblColor);
            tabLighting.Location = new Point(4, 24);
            tabLighting.Name = "tabLighting";
            tabLighting.Padding = new Padding(3, 3, 3, 3);
            tabLighting.Size = new Size(976, 533);
            tabLighting.TabIndex = 1;
            tabLighting.Text = "💡 Φωτισμός";
            tabLighting.UseVisualStyleBackColor = true;
            // 
            // lblBrightness
            // 
            lblBrightness.AutoSize = true;
            lblBrightness.Location = new Point(24, 92);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(117, 15);
            lblBrightness.TabIndex = 3;
            lblBrightness.Text = "Ένταση: 40% (demo)";
            // 
            // trkBrightness
            // 
            trkBrightness.Location = new Point(24, 120);
            trkBrightness.Maximum = 100;
            trkBrightness.Name = "trkBrightness";
            trkBrightness.Size = new Size(300, 45);
            trkBrightness.TabIndex = 2;
            trkBrightness.TickFrequency = 10;
            trkBrightness.Value = 40;
            trkBrightness.Scroll += trkBrightness_Scroll;
            // 
            // cmbColor
            // 
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Cozy", "Reading", "Night", "Party" });
            cmbColor.Location = new Point(24, 48);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(180, 23);
            cmbColor.TabIndex = 1;
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(24, 22);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(200, 15);
            lblColor.TabIndex = 0;
            lblColor.Text = "Προκαθορισμένο χρώμα φωτισμού";
            // 
            // tabEnergy
            // 
            tabEnergy.Controls.Add(pbBattery);
            tabEnergy.Controls.Add(btnSavingMode);
            tabEnergy.Controls.Add(lblPv);
            tabEnergy.Controls.Add(lblLoad);
            tabEnergy.Location = new Point(4, 24);
            tabEnergy.Name = "tabEnergy";
            tabEnergy.Size = new Size(976, 533);
            tabEnergy.TabIndex = 2;
            tabEnergy.Text = "🔋 Ενέργεια";
            tabEnergy.UseVisualStyleBackColor = true;
            // 
            // pbBattery
            // 
            pbBattery.Location = new Point(24, 98);
            pbBattery.Name = "pbBattery";
            pbBattery.Size = new Size(300, 23);
            pbBattery.TabIndex = 3;
            // 
            // btnSavingMode
            // 
            btnSavingMode.Location = new Point(24, 136);
            btnSavingMode.Name = "btnSavingMode";
            btnSavingMode.Size = new Size(192, 30);
            btnSavingMode.TabIndex = 2;
            btnSavingMode.Text = "Λειτουργία Εξοικονόμησης";
            btnSavingMode.UseVisualStyleBackColor = true;
            btnSavingMode.Click += btnSavingMode_Click;
            // 
            // lblPv
            // 
            lblPv.AutoSize = true;
            lblPv.Location = new Point(24, 22);
            lblPv.Name = "lblPv";
            lblPv.Size = new Size(161, 15);
            lblPv.TabIndex = 1;
            lblPv.Text = "Παραγωγή PV: 120W (demo)";
            // 
            // lblLoad
            // 
            lblLoad.AutoSize = true;
            lblLoad.Location = new Point(24, 58);
            lblLoad.Name = "lblLoad";
            lblLoad.Size = new Size(149, 15);
            lblLoad.TabIndex = 0;
            lblLoad.Text = "Κατανάλωση: 80W (demo)";
            // 
            // tabWeather
            // 
            tabWeather.Controls.Add(btnSuggestActions);
            tabWeather.Controls.Add(lblWind);
            tabWeather.Controls.Add(lblHumidity);
            tabWeather.Controls.Add(lblTemp);
            tabWeather.Location = new Point(4, 24);
            tabWeather.Name = "tabWeather";
            tabWeather.Size = new Size(976, 533);
            tabWeather.TabIndex = 3;
            tabWeather.Text = "🌦️ Καιρός";
            tabWeather.UseVisualStyleBackColor = true;
            // 
            // btnSuggestActions
            // 
            btnSuggestActions.Location = new Point(24, 120);
            btnSuggestActions.Name = "btnSuggestActions";
            btnSuggestActions.Size = new Size(170, 30);
            btnSuggestActions.TabIndex = 3;
            btnSuggestActions.Text = "Πρότεινε ενέργειες";
            btnSuggestActions.UseVisualStyleBackColor = true;
            btnSuggestActions.Click += btnSuggestActions_Click;
            // 
            // lblWind
            // 
            lblWind.AutoSize = true;
            lblWind.Location = new Point(24, 86);
            lblWind.Name = "lblWind";
            lblWind.Size = new Size(96, 15);
            lblWind.TabIndex = 2;
            lblWind.Text = "Άνεμος: 10 km/h";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Location = new Point(24, 54);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(79, 15);
            lblHumidity.TabIndex = 1;
            lblHumidity.Text = "Υγρασία: 55%";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(24, 22);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(110, 15);
            lblTemp.TabIndex = 0;
            lblTemp.Text = "Θερμοκρασία: 24°C";
            // 
            // tabShelter
            // 
            tabShelter.Controls.Add(cmbRoute);
            tabShelter.Controls.Add(btnNavigate);
            tabShelter.Location = new Point(4, 24);
            tabShelter.Name = "tabShelter";
            tabShelter.Size = new Size(976, 533);
            tabShelter.TabIndex = 4;
            tabShelter.Text = "\U0001f9ed Καταφύγιο";
            tabShelter.UseVisualStyleBackColor = true;
            // 
            // cmbRoute
            // 
            cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Items.AddRange(new object[] { "Ασφαλής", "Σύντομη", "Αποφυγή ανηφόρας" });
            cmbRoute.Location = new Point(24, 22);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(200, 23);
            cmbRoute.TabIndex = 1;
            // 
            // btnNavigate
            // 
            btnNavigate.Location = new Point(24, 58);
            btnNavigate.Name = "btnNavigate";
            btnNavigate.Size = new Size(170, 30);
            btnNavigate.TabIndex = 0;
            btnNavigate.Text = "Πλοήγηση";
            btnNavigate.UseVisualStyleBackColor = true;
            btnNavigate.Click += btnNavigate_Click;
            // 
            // tabTourism
            // 
            tabTourism.Controls.Add(lstPOIs);
            tabTourism.Controls.Add(btnGoPOI);
            tabTourism.Location = new Point(4, 24);
            tabTourism.Name = "tabTourism";
            tabTourism.Size = new Size(976, 533);
            tabTourism.TabIndex = 5;
            tabTourism.Text = "🗺️ Τουρισμός";
            tabTourism.UseVisualStyleBackColor = true;
            // 
            // lstPOIs
            // 
            lstPOIs.FormattingEnabled = true;
            lstPOIs.ItemHeight = 15;
            lstPOIs.Location = new Point(24, 22);
            lstPOIs.Name = "lstPOIs";
            lstPOIs.Size = new Size(260, 214);
            lstPOIs.TabIndex = 1;
            // 
            // btnGoPOI
            // 
            btnGoPOI.Location = new Point(24, 250);
            btnGoPOI.Name = "btnGoPOI";
            btnGoPOI.Size = new Size(170, 30);
            btnGoPOI.TabIndex = 0;
            btnGoPOI.Text = "Πήγαινε";
            btnGoPOI.UseVisualStyleBackColor = true;
            btnGoPOI.Click += btnGoPOI_Click;
            // 
            // tabOrders
            // 
            tabOrders.Controls.Add(lstOrders);
            tabOrders.Controls.Add(btnOrder);
            tabOrders.Location = new Point(4, 24);
            tabOrders.Name = "tabOrders";
            tabOrders.Size = new Size(976, 533);
            tabOrders.TabIndex = 6;
            tabOrders.Text = "🍽️ Παραγγελίες";
            tabOrders.UseVisualStyleBackColor = true;
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 15;
            lstOrders.Location = new Point(24, 22);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(300, 214);
            lstOrders.TabIndex = 1;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(24, 250);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(170, 30);
            btnOrder.TabIndex = 0;
            btnOrder.Text = "Παράγγειλε (demo)";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // tabEvents
            // 
            tabEvents.Controls.Add(lstEvents);
            tabEvents.Controls.Add(btnJoinEvent);
            tabEvents.Location = new Point(4, 24);
            tabEvents.Name = "tabEvents";
            tabEvents.Size = new Size(976, 533);
            tabEvents.TabIndex = 7;
            tabEvents.Text = "🎟️ Εκδηλώσεις";
            tabEvents.UseVisualStyleBackColor = true;
            // 
            // lstEvents
            // 
            lstEvents.FormattingEnabled = true;
            lstEvents.ItemHeight = 15;
            lstEvents.Location = new Point(24, 22);
            lstEvents.Name = "lstEvents";
            lstEvents.Size = new Size(320, 214);
            lstEvents.TabIndex = 1;
            // 
            // btnJoinEvent
            // 
            btnJoinEvent.Location = new Point(24, 250);
            btnJoinEvent.Name = "btnJoinEvent";
            btnJoinEvent.Size = new Size(170, 30);
            btnJoinEvent.TabIndex = 0;
            btnJoinEvent.Text = "Δήλωση συμμετοχής";
            btnJoinEvent.UseVisualStyleBackColor = true;
            btnJoinEvent.Click += btnJoinEvent_Click;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(btnHelp);
            tabSettings.Location = new Point(4, 24);
            tabSettings.Name = "tabSettings";
            tabSettings.Size = new Size(976, 533);
            tabSettings.TabIndex = 8;
            tabSettings.Text = "⚙️ Ρυθμίσεις & Βοήθεια";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(24, 22);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(170, 30);
            btnHelp.TabIndex = 0;
            btnHelp.Text = "Help (online)";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolBattery, toolWeather });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 22);
            statusStrip1.TabIndex = 1;
            // 
            // toolBattery
            // 
            toolBattery.Name = "toolBattery";
            toolBattery.Size = new Size(106, 17);
            toolBattery.Text = "🔋 Μπαταρία: 72%";
            // 
            // toolWeather
            // 
            toolWeather.Name = "toolWeather";
            toolWeather.Size = new Size(100, 17);
            toolWeather.Text = "🌦️ 24°C | 10 km/h";
            // 
            // button2
            // 
            button2.Location = new Point(405, 232);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(statusStrip1);
            Controls.Add(tabMain);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Έξυπνο Camping — Προσομοίωση";
            Load += MainForm_Load;
            tabMain.ResumeLayout(false);
            tabSetup.ResumeLayout(false);
            tabSetup.PerformLayout();
            tabLighting.ResumeLayout(false);
            tabLighting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trkBrightness).EndInit();
            tabEnergy.ResumeLayout(false);
            tabEnergy.PerformLayout();
            tabWeather.ResumeLayout(false);
            tabWeather.PerformLayout();
            tabShelter.ResumeLayout(false);
            tabTourism.ResumeLayout(false);
            tabOrders.ResumeLayout(false);
            tabEvents.ResumeLayout(false);
            tabSettings.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSetup;
        private System.Windows.Forms.TabPage tabLighting;
        private System.Windows.Forms.TabPage tabEnergy;
        private System.Windows.Forms.TabPage tabWeather;
        private System.Windows.Forms.TabPage tabShelter;
        private System.Windows.Forms.TabPage tabTourism;
        private System.Windows.Forms.TabPage tabOrders;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label lblSetupStatus;
        private System.Windows.Forms.Button btnEvaluateSpot;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.TrackBar trkBrightness;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ProgressBar pbBattery;
        private System.Windows.Forms.Button btnSavingMode;
        private System.Windows.Forms.Label lblPv;
        private System.Windows.Forms.Label lblLoad;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Button btnSuggestActions;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.ListBox lstPOIs;
        private System.Windows.Forms.Button btnGoPOI;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Button btnJoinEvent;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolBattery;
        private System.Windows.Forms.ToolStripStatusLabel toolWeather;
        private Button button1;
        private Button button2;
    }
}
