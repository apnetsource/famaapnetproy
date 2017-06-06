using System.Windows;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System.Collections.Generic;
using System.Linq;
using FAMA.AP.Model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FAMA.AP.ViewModel;

namespace FAMA.AP.Desktop.View.ADMIN
{
    /// <summary>
    /// Interaction logic for BarSeries.xaml
    /// </summary>
    public partial class BarSeriess : UserControl
    {
        public BarSeriess()
        {
            InitializeComponent();
            this.Model = CreateBarSerieModel();
            this.DataContext = this;
        }

        public PlotModel Model { get; set; }

        private static PlotModel CreateBarSerieModel()
        {
            PlotModel model = new PlotModel { Title = "Cake Type Popularity" };

            //generate a random percentage distribution between the 5
            //cake-types (see axis below)
            var rand = new System.Random();
            double[] cakePopularity = new double[5];
            for (int i = 0; i < 5; ++i)
            {
                cakePopularity[i] = rand.NextDouble();
            }
            var sum = cakePopularity.Sum();
            
          
            BarSeries barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                    {
                new BarItem{ Value = (cakePopularity[0] / sum * 100) },
                new BarItem{ Value = (cakePopularity[1] / sum * 100) },
                new BarItem{ Value = (cakePopularity[2] / sum * 100) },
                new BarItem{ Value = (cakePopularity[3] / sum * 100) },
                new BarItem{ Value = (cakePopularity[4] / sum * 100) }
        }),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:.00}%"
            };
            model.Series.Add(barSeries);
            

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CakeAxis",
                ItemsSource = new[]
                    {
                "Apple cake",
                "Baumkuchen",
                "Bundt Cake",
                "Chocolate cake",
                "Carrot cake"
        }

            });
            var linearAxis1 = new LinearAxis();
            linearAxis1.IsAxisVisible = false;
            linearAxis1.Position = AxisPosition.Bottom;
        
            return model;

        }

    }
}
