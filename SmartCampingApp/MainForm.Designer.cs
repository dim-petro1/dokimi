
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

// πρόσθεσε τον καμβά στο tab
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSetup = new System.Windows.Forms.TabPage();
            this.btnEvaluateSpot = new System.Windows.Forms.Button();
            this.lblSetupStatus = new System.Windows.Forms.Label();
            this.tabLighting = new System.Windows.Forms.TabPage();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.trkBrightness = new System.Windows.Forms.TrackBar();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.tabEnergy = new System.Windows.Forms.TabPage();
            this.pbBattery = new System.Windows.Forms.ProgressBar();
            this.btnSavingMode = new System.Windows.Forms.Button();
            this.lblPv = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.tabWeather = new System.Windows.Forms.TabPage();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.btnSuggestActions = new System.Windows.Forms.Button();
            this.tabShelter = new System.Windows.Forms.TabPage();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.tabTourism = new System.Windows.Forms.TabPage();
            this.lstPOIs = new System.Windows.Forms.ListBox();
            this.btnGoPOI = new System.Windows.Forms.Button();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.btnJoinEvent = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnHelp = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolBattery = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolWeather = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMain.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabLighting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).BeginInit();
            this.tabEnergy.SuspendLayout();
            this.tabWeather.SuspendLayout();
            this.tabShelter.SuspendLayout();
            this.tabTourism.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSetup);
            this.tabMain.Controls.Add(this.tabLighting);
            this.tabMain.Controls.Add(this.tabEnergy);
            this.tabMain.Controls.Add(this.tabWeather);
            this.tabMain.Controls.Add(this.tabShelter);
            this.tabMain.Controls.Add(this.tabTourism);
            this.tabMain.Controls.Add(this.tabOrders);
            this.tabMain.Controls.Add(this.tabEvents);
            this.tabMain.Controls.Add(this.tabSettings);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(984, 561);
            this.tabMain.TabIndex = 0;
            // 
            // tabSetup
            // 
            this.tabSetup.Controls.Add(this.btnEvaluateSpot);
            this.tabSetup.Controls.Add(this.lblSetupStatus);
            this.tabSetup.Location = new System.Drawing.Point(4, 24);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetup.Size = new System.Drawing.Size(976, 533);
            this.tabSetup.TabIndex = 0;
            this.tabSetup.Text = "🏕️ Στήσιμο";
            this.tabSetup.UseVisualStyleBackColor = true;
            // 
            // btnEvaluateSpot
            // 
            this.btnEvaluateSpot.Location = new System.Drawing.Point(24, 22);
            this.btnEvaluateSpot.Name = "btnEvaluateSpot";
            this.btnEvaluateSpot.Size = new System.Drawing.Size(170, 30);
            this.btnEvaluateSpot.TabIndex = 1;
            this.btnEvaluateSpot.Text = "Αξιολόγηση Σημείου";
            this.btnEvaluateSpot.UseVisualStyleBackColor = true;
            this.btnEvaluateSpot.Click += new System.EventHandler(this.btnEvaluateSpot_Click);
            // 
            // lblSetupStatus
            // 
            this.lblSetupStatus.AutoSize = true;
            this.lblSetupStatus.Location = new System.Drawing.Point(24, 67);
            this.lblSetupStatus.Name = "lblSetupStatus";
            this.lblSetupStatus.Size = new System.Drawing.Size(232, 15);
            this.lblSetupStatus.TabIndex = 0;
            this.lblSetupStatus.Text = "Κατάσταση: Δεν έχει ξεκινήσει το στήσιμο.";
            // 
            // tabLighting
            // 
            this.tabLighting.Controls.Add(this.lblBrightness);
            this.tabLighting.Controls.Add(this.trkBrightness);
            this.tabLighting.Controls.Add(this.cmbColor);
            this.tabLighting.Controls.Add(this.lblColor);
            this.tabLighting.Location = new System.Drawing.Point(4, 24);
            this.tabLighting.Name = "tabLighting";
            this.tabLighting.Padding = new System.Windows.Forms.Padding(3);
            this.tabLighting.Size = new System.Drawing.Size(976, 533);
            this.tabLighting.TabIndex = 1;
            this.tabLighting.Text = "💡 Φωτισμός";
            this.tabLighting.UseVisualStyleBackColor = true;
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(24, 92);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(113, 15);
            this.lblBrightness.TabIndex = 3;
            this.lblBrightness.Text = "Ένταση: 40% (demo)";
            // 
            // trkBrightness
            // 
            this.trkBrightness.Location = new System.Drawing.Point(24, 120);
            this.trkBrightness.Maximum = 100;
            this.trkBrightness.Name = "trkBrightness";
            this.trkBrightness.Size = new System.Drawing.Size(300, 45);
            this.trkBrightness.TabIndex = 2;
            this.trkBrightness.TickFrequency = 10;
            this.trkBrightness.Value = 40;
            this.trkBrightness.Scroll += new System.EventHandler(this.trkBrightness_Scroll);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Items.AddRange(new object[] {
            "Cozy",
            "Reading",
            "Night",
            "Party"});
            this.cmbColor.Location = new System.Drawing.Point(24, 48);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(180, 23);
            this.cmbColor.TabIndex = 1;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(24, 22);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(190, 15);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Προκαθορισμένο χρώμα φωτισμού";
            // 
            // tabEnergy
            // 
            this.tabEnergy.Controls.Add(this.pbBattery);
            this.tabEnergy.Controls.Add(this.btnSavingMode);
            this.tabEnergy.Controls.Add(this.lblPv);
            this.tabEnergy.Controls.Add(this.lblLoad);
            this.tabEnergy.Location = new System.Drawing.Point(4, 24);
            this.tabEnergy.Name = "tabEnergy";
            this.tabEnergy.Size = new System.Drawing.Size(976, 533);
            this.tabEnergy.TabIndex = 2;
            this.tabEnergy.Text = "🔋 Ενέργεια";
            this.tabEnergy.UseVisualStyleBackColor = true;
            // 
            // pbBattery
            // 
            this.pbBattery.Location = new System.Drawing.Point(24, 98);
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(300, 23);
            this.pbBattery.TabIndex = 3;
            // 
            // btnSavingMode
            // 
            this.btnSavingMode.Location = new System.Drawing.Point(24, 136);
            this.btnSavingMode.Name = "btnSavingMode";
            this.btnSavingMode.Size = new System.Drawing.Size(192, 30);
            this.btnSavingMode.TabIndex = 2;
            this.btnSavingMode.Text = "Λειτουργία Εξοικονόμησης";
            this.btnSavingMode.UseVisualStyleBackColor = true;
            this.btnSavingMode.Click += new System.EventHandler(this.btnSavingMode_Click);
            // 
            // lblPv
            // 
            this.lblPv.AutoSize = true;
            this.lblPv.Location = new System.Drawing.Point(24, 22);
            this.lblPv.Name = "lblPv";
            this.lblPv.Size = new System.Drawing.Size(156, 15);
            this.lblPv.TabIndex = 1;
            this.lblPv.Text = "Παραγωγή PV: 120W (demo)";
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Location = new System.Drawing.Point(24, 58);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(146, 15);
            this.lblLoad.TabIndex = 0;
            this.lblLoad.Text = "Κατανάλωση: 80W (demo)";
            // 
            // tabWeather
            // 
            this.tabWeather.Controls.Add(this.btnSuggestActions);
            this.tabWeather.Controls.Add(this.lblWind);
            this.tabWeather.Controls.Add(this.lblHumidity);
            this.tabWeather.Controls.Add(this.lblTemp);
            this.tabWeather.Location = new System.Drawing.Point(4, 24);
            this.tabWeather.Name = "tabWeather";
            this.tabWeather.Size = new System.Drawing.Size(976, 533);
            this.tabWeather.TabIndex = 3;
            this.tabWeather.Text = "🌦️ Καιρός";
            this.tabWeather.UseVisualStyleBackColor = true;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(24, 22);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(120, 15);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Θερμοκρασία: 24°C";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(24, 54);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(92, 15);
            this.lblHumidity.TabIndex = 1;
            this.lblHumidity.Text = "Υγρασία: 55%";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(24, 86);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(103, 15);
            this.lblWind.TabIndex = 2;
            this.lblWind.Text = "Άνεμος: 10 km/h";
            // 
            // btnSuggestActions
            // 
            this.btnSuggestActions.Location = new System.Drawing.Point(24, 120);
            this.btnSuggestActions.Name = "btnSuggestActions";
            this.btnSuggestActions.Size = new System.Drawing.Size(170, 30);
            this.btnSuggestActions.TabIndex = 3;
            this.btnSuggestActions.Text = "Πρότεινε ενέργειες";
            this.btnSuggestActions.UseVisualStyleBackColor = true;
            this.btnSuggestActions.Click += new System.EventHandler(this.btnSuggestActions_Click);
            // 
            // tabShelter
            // 
            this.tabShelter.Controls.Add(this.cmbRoute);
            this.tabShelter.Controls.Add(this.btnNavigate);
            this.tabShelter.Location = new System.Drawing.Point(4, 24);
            this.tabShelter.Name = "tabShelter";
            this.tabShelter.Size = new System.Drawing.Size(976, 533);
            this.tabShelter.TabIndex = 4;
            this.tabShelter.Text = "🧭 Καταφύγιο";
            this.tabShelter.UseVisualStyleBackColor = true;
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Items.AddRange(new object[] {
            "Ασφαλής",
            "Σύντομη",
            "Αποφυγή ανηφόρας"});
            this.cmbRoute.Location = new System.Drawing.Point(24, 22);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(200, 23);
            this.cmbRoute.TabIndex = 1;
            // 
            // btnNavigate
            // 
            this.btnNavigate.Location = new System.Drawing.Point(24, 58);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(170, 30);
            this.btnNavigate.TabIndex = 0;
            this.btnNavigate.Text = "Πλοήγηση";
            this.btnNavigate.UseVisualStyleBackColor = true;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            // 
            // tabTourism
            // 
            this.tabTourism.Controls.Add(this.lstPOIs);
            this.tabTourism.Controls.Add(this.btnGoPOI);
            this.tabTourism.Location = new System.Drawing.Point(4, 24);
            this.tabTourism.Name = "tabTourism";
            this.tabTourism.Size = new System.Drawing.Size(976, 533);
            this.tabTourism.TabIndex = 5;
            this.tabTourism.Text = "🗺️ Τουρισμός";
            this.tabTourism.UseVisualStyleBackColor = true;
            // 
            // lstPOIs
            // 
            this.lstPOIs.FormattingEnabled = true;
            this.lstPOIs.ItemHeight = 15;
            this.lstPOIs.Location = new System.Drawing.Point(24, 22);
            this.lstPOIs.Name = "lstPOIs";
            this.lstPOIs.Size = new System.Drawing.Size(260, 214);
            this.lstPOIs.TabIndex = 1;
            // 
            // btnGoPOI
            // 
            this.btnGoPOI.Location = new System.Drawing.Point(24, 250);
            this.btnGoPOI.Name = "btnGoPOI";
            this.btnGoPOI.Size = new System.Drawing.Size(170, 30);
            this.btnGoPOI.TabIndex = 0;
            this.btnGoPOI.Text = "Πήγαινε";
            this.btnGoPOI.UseVisualStyleBackColor = true;
            this.btnGoPOI.Click += new System.EventHandler(this.btnGoPOI_Click);
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.lstOrders);
            this.tabOrders.Controls.Add(this.btnOrder);
            this.tabOrders.Location = new System.Drawing.Point(4, 24);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Size = new System.Drawing.Size(976, 533);
            this.tabOrders.TabIndex = 6;
            this.tabOrders.Text = "🍽️ Παραγγελίες";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 15;
            this.lstOrders.Location = new System.Drawing.Point(24, 22);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(300, 214);
            this.lstOrders.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(24, 250);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(170, 30);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Παράγγειλε (demo)";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.lstEvents);
            this.tabEvents.Controls.Add(this.btnJoinEvent);
            this.tabEvents.Location = new System.Drawing.Point(4, 24);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(976, 533);
            this.tabEvents.TabIndex = 7;
            this.tabEvents.Text = "🎟️ Εκδηλώσεις";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 15;
            this.lstEvents.Location = new System.Drawing.Point(24, 22);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(320, 214);
            this.lstEvents.TabIndex = 1;
            // 
            // btnJoinEvent
            // 
            this.btnJoinEvent.Location = new System.Drawing.Point(24, 250);
            this.btnJoinEvent.Name = "btnJoinEvent";
            this.btnJoinEvent.Size = new System.Drawing.Size(170, 30);
            this.btnJoinEvent.TabIndex = 0;
            this.btnJoinEvent.Text = "Δήλωση συμμετοχής";
            this.btnJoinEvent.UseVisualStyleBackColor = true;
            this.btnJoinEvent.Click += new System.EventHandler(this.btnJoinEvent_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.btnHelp);
            this.tabSettings.Location = new System.Drawing.Point(4, 24);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(976, 533);
            this.tabSettings.TabIndex = 8;
            this.tabSettings.Text = "⚙️ Ρυθμίσεις & Βοήθεια";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(24, 22);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(170, 30);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.Text = "Help (online)";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBattery,
            this.toolWeather});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 1;
            // 
            // toolBattery
            // 
            this.toolBattery.Name = "toolBattery";
            this.toolBattery.Size = new System.Drawing.Size(113, 17);
            this.toolBattery.Text = "🔋 Μπαταρία: 72%";
            // 
            // toolWeather
            // 
            this.toolWeather.Name = "toolWeather";
            this.toolWeather.Size = new System.Drawing.Size(129, 17);
            this.toolWeather.Text = "🌦️ 24°C | 10 km/h";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabMain);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Έξυπνο Camping — Προσομοίωση";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabMain.ResumeLayout(false);
            this.tabSetup.ResumeLayout(false);
            this.tabSetup.PerformLayout();
            this.tabLighting.ResumeLayout(false);
            this.tabLighting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkBrightness)).EndInit();
            this.tabEnergy.ResumeLayout(false);
            this.tabEnergy.PerformLayout();
            this.tabWeather.ResumeLayout(false);
            this.tabWeather.PerformLayout();
            this.tabShelter.ResumeLayout(false);
            this.tabTourism.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
