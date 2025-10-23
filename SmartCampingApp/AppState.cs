
using System;
using System.Collections.Generic;

namespace SmartCampingApp
{
    public class TentState
    {
        public bool IsSetupComplete { get; set; }
        public double PegAngle { get; set; }
        public double PegPressure { get; set; }
        public bool WindPanelsDeployed { get; set; }
    }

    public class LightingState
    {
        public int BrightnessPercent { get; set; } = 40; // 0-100
        public string ColorPreset { get; set; } = "Cozy"; // Cozy, Reading, Night, Party
    }

    public class EnergyState
    {
        public int BatteryPercent { get; set; } = 72;
        public int PvWatts { get; set; } = 120;
        public int LoadWatts { get; set; } = 80;
        public bool SavingMode { get; set; }
    }

    public class WeatherState
    {
        public double TemperatureC { get; set; } = 24.0;
        public int HumidityPercent { get; set; } = 55;
        public double WindKmh { get; set; } = 10;
    }

    public class OrderItem { public string Name { get; set; } = ""; public decimal Price { get; set; } }
    public class OrderLine { public OrderItem Item { get; set; } = new OrderItem(); public int Qty { get; set; } = 1; }
    public class Order { public List<OrderLine> Lines { get; set; } = new(); public string Status { get; set; } = "Pending"; }

    public class EventItem { public string Title { get; set; } = ""; public DateTime Start { get; set; } = DateTime.Now; public bool Joined { get; set; } }

    public class AppState
    {
        public TentState Tent { get; } = new();
        public LightingState Lighting { get; } = new();
        public EnergyState Energy { get; } = new();
        public WeatherState Weather { get; } = new();
        public List<Order> Orders { get; } = new();
        public List<EventItem> Events { get; } = new()
        {
            new EventItem{ Title = "Συναυλία Ακουστικής Κιθάρας", Start = DateTime.Today.AddHours(21)},
            new EventItem{ Title = "Πρωινό SUP", Start = DateTime.Today.AddDays(1).AddHours(8)},
        };
    }
}
