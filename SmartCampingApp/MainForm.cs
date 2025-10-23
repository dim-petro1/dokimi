
using System;
using System.Linq;
using System.Windows.Forms;

namespace SmartCampingApp
{
    public partial class MainForm : Form
    {
        private readonly AppState _state = new();
        private readonly System.Windows.Forms.Timer _simTimer = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {

            // Initialize UI from state
            cmbColor.SelectedIndex = 0;
            trkBrightness.Value = _state.Lighting.BrightnessPercent;
            lblBrightness.Text = $"Ένταση: {trkBrightness.Value}%";
            pbBattery.Value = Math.Max(0, Math.Min(100, _state.Energy.BatteryPercent));

            // Seed POIs
            lstPOIs.Items.Add("Παραλία Κρυφή (1.2 km)");
            lstPOIs.Items.Add("Μονοπάτι Πεύκης (2.1 km)");
            lstPOIs.Items.Add("Φάρος (3.0 km)");

            // Seed Orders/Events
            lstOrders.Items.Add("Καμία παραγγελία ακόμη.");
            foreach (var ev in _state.Events)
                lstEvents.Items.Add($"{ev.Title} — {ev.Start:dd/MM HH:mm}");

            // Timer for simple simulation (weather/energy drift)
            _simTimer.Interval = 1500;
            _simTimer.Tick += (s, args) => SimStep();
            _simTimer.Start();
        }

        private void SimStep()
        {
            // Weather random walk
            var rnd = new Random();
            _state.Weather.TemperatureC += (rnd.NextDouble() - 0.5) * 0.3;
            _state.Weather.WindKmh = Math.Max(0, _state.Weather.WindKmh + (rnd.NextDouble() - 0.5) * 1.0);

            // Energy: PV vs Load (very rough demo)
            int delta = Math.Sign(_state.Energy.PvWatts - _state.Energy.LoadWatts);
            _state.Energy.BatteryPercent = Math.Max(0, Math.Min(100, _state.Energy.BatteryPercent + delta));

            // Update UI
            lblTemp.Text = $"Θερμοκρασία: {_state.Weather.TemperatureC:0.#}°C";
            lblWind.Text = $"Άνεμος: {_state.Weather.WindKmh:0.#} km/h";
            pbBattery.Value = _state.Energy.BatteryPercent;
            toolBattery.Text = $"🔋 Μπαταρία: {_state.Energy.BatteryPercent}%";
            toolWeather.Text = $"🌦️ {(_state.Weather.TemperatureC):0.#}°C | {_state.Weather.WindKmh:0.#} km/h";
        }

        private void btnEvaluateSpot_Click(object sender, EventArgs e)
        {
            // Simple demo: Toggle setup state
            _state.Tent.IsSetupComplete = !_state.Tent.IsSetupComplete;
            lblSetupStatus.Text = _state.Tent.IsSetupComplete
                ? "Κατάσταση: Η σκηνή στήθηκε επιτυχώς ✅"
                : "Κατάσταση: Δεν έχει ξεκινήσει το στήσιμο.";
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _state.Lighting.ColorPreset = cmbColor.SelectedItem?.ToString() ?? "Cozy";
            MessageBox.Show($"Χρώμα φωτισμού: {_state.Lighting.ColorPreset}", "Φωτισμός", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void trkBrightness_Scroll(object sender, EventArgs e)
        {
            _state.Lighting.BrightnessPercent = trkBrightness.Value;
            lblBrightness.Text = $"Ένταση: {trkBrightness.Value}%";
        }

        private void btnSavingMode_Click(object sender, EventArgs e)
        {
            _state.Energy.SavingMode = !_state.Energy.SavingMode;
            if (_state.Energy.SavingMode)
            {
                _state.Energy.LoadWatts = Math.Max(10, _state.Energy.LoadWatts - 40);
                MessageBox.Show("Ενεργοποιήθηκε η λειτουργία εξοικονόμησης. Μη κρίσιμα φορτία απενεργοποιήθηκαν.", "Ενέργεια");
            }
            else
            {
                _state.Energy.LoadWatts += 40;
            }
            lblLoad.Text = $"Κατανάλωση: {_state.Energy.LoadWatts}W (demo)";
        }

        private void btnSuggestActions_Click(object sender, EventArgs e)
        {
            string msg = _state.Weather.WindKmh > 20
                ? "Ισχυρός άνεμος — προτείνεται ανάπτυξη προστατευτικών πανιών."
                : "Συνθήκες ομαλές. Δεν απαιτείται ενέργεια.";
            MessageBox.Show(msg, "Προτάσεις Καιρού");
        }

        private void btnNavigate_Click(object sender, EventArgs e)
        {
            var route = cmbRoute.SelectedItem?.ToString() ?? "Ασφαλής";
            MessageBox.Show($"Επιλέχθηκε διαδρομή: {route}.\n Πλοήγηση προς κοντινότερο καταφύγιο (demo).", "Πλοήγηση");
        }

        private void btnGoPOI_Click(object sender, EventArgs e)
        {
            if (lstPOIs.SelectedItem is null)
            {
                MessageBox.Show("Διάλεξε ένα σημείο ενδιαφέροντος (POI).");
                return;
            }
            MessageBox.Show($"Πλοήγηση προς: {lstPOIs.SelectedItem}", "Τουριστική Πλοήγηση");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lstOrders.Items.Clear();
            lstOrders.Items.Add($"Παραγγελία #{_state.Orders.Count + 1}: Καφές + Club Sandwich");
            _state.Orders.Add(new Order());
            MessageBox.Show("Η παραγγελία στάλθηκε στο μπαρ/κουζίνα (demo).", "Παραγγελίες");
        }

        private void btnJoinEvent_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex < 0)
            {
                MessageBox.Show("Επίλεξε μια εκδήλωση.");
                return;
            }
            MessageBox.Show("Δηλώθηκε συμμετοχή! (demo)", "Εκδηλώσεις");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Online Help\n\n— Χρησιμοποίησε τα Tabs για πλοήγηση.\n— Φωτισμός: Επίλεξε preset και ρύθμισε ένταση.\n— Ενέργεια: Ενεργοποίησε εξοικονόμηση για χαμηλότερη κατανάλωση.\n— Καιρός: Δες προτάσεις δράσης.\n— Καταφύγιο/Τουρισμός: Demo πλοήγησης.", "Βοήθεια", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Αυτό προστέθηκε από Νίκο");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Αυτό προστέθηκε από Δημήτρη");
        }
    }
}
