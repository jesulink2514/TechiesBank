using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Microcharts;
using SkiaSharp;

namespace TechiesBank.ViewModels
{
    public class SecondOldPageViewModel : BindableBase
    {
        public SecondOldPageViewModel()
        {
            SavingsChart = new LineChart()
            {
                LineSize = 5,
                PointMode = PointMode.None,
                LabelColor = SKColor.Parse("a8a8a8"),
                LabelTextSize = 50,
                LabelOrientation = Orientation.Horizontal,
                ValueLabelOrientation = Orientation.Horizontal,
                Entries = new[]
                {
                    new ChartEntry(100){Color = SKColor.Parse("7247dc"),Label = "Jan", ValueLabel = ".", ValueLabelColor= SKColor.Parse("a8a8a8"),TextColor = SKColor.Parse("a8a8a8")},
                    new ChartEntry(50){ Color = SKColor.Parse("7247dc"),Label = "Feb",ValueLabel = ".",TextColor = SKColor.Parse("a8a8a8")},
                    new ChartEntry(180){Color = SKColor.Parse("7247dc"),Label = "Mar",ValueLabel = ".", ValueLabelColor = SKColor.Parse("a8a8a8"),TextColor = SKColor.Parse("a8a8a8")},
                    new ChartEntry(250){Color = SKColor.Parse("7247dc"),Label = "Apr",ValueLabel = ".", ValueLabelColor = SKColor.Parse("a8a8a8"),TextColor = SKColor.Parse("a8a8a8")},
                    new ChartEntry(196){Color = SKColor.Parse("7247dc"),Label = "May",ValueLabel = ".", ValueLabelColor = SKColor.Parse("a8a8a8"),TextColor = SKColor.Parse("a8a8a8")},
                    new ChartEntry(55){ Color = SKColor.Parse("7247dc"),Label = "Jun",ValueLabel = ".",TextColor = SKColor.Parse("a8a8a8")},
                    new ChartEntry(102){ Color = SKColor.Parse("7247dc"),Label = "Jul",ValueLabel = ".",TextColor = SKColor.Parse("a8a8a8")}
                }
            };
        }
        public Chart SavingsChart { get; set; }
    }
}
