using System.ComponentModel;
using OxyPlot;
using OxyPlot.Series;
using System.Collections.Generic;
using OxyPlot.Axes;
using System.Linq;

namespace FAMA.AP.ViewModel
{

    public class MainWindowModel : INotifyPropertyChanged
    {
        private PlotModel _plotModel;
        public PlotModel PlotModel
        {
            get { return _plotModel; }
            set { _plotModel = value; OnPropertyChanged("PlotModel"); }
        }

        public MainWindowModel()
        {
            FAMA.AP.DataLayer.DbBarSeries dataBarSeries = new FAMA.AP.DataLayer.DbBarSeries();

            dataBarSeries.Selectalldata();


            PlotModel = new PlotModel { Title = "" };
            // var PlotModel = new PlotModel();
           
            PlotModel.Title = "";
            PlotModel.LegendPlacement = LegendPlacement.Outside;
            var categoryAxis1 = new CategoryAxis();
            categoryAxis1.MinorStep = 1;
            categoryAxis1.Position = AxisPosition.Left;
            categoryAxis1.Labels.Add("Activity A");
            categoryAxis1.Labels.Add("Activity B");
            categoryAxis1.Labels.Add("Activity C");
            categoryAxis1.Labels.Add("Activity D");
            //categoryAxis1.ActualLabels.Add("Activity A");
            //categoryAxis1.ActualLabels.Add("Activity B");
            //categoryAxis1.ActualLabels.Add("Activity C");
            //categoryAxis1.ActualLabels.Add("Activity D");
            PlotModel.Axes.Add(categoryAxis1);



            var linearAxis1 = new LinearAxis();
            linearAxis1.MaximumPadding = 0.1;
            linearAxis1.MinimumPadding = 0.1;
            linearAxis1.Position = AxisPosition.Bottom;
            linearAxis1.IsAxisVisible = false;
            PlotModel.Axes.Add(linearAxis1);


            var intervalBarSeries1 = new IntervalBarSeries();
            intervalBarSeries1.Title = "";
            intervalBarSeries1.Items.Add(new IntervalBarItem(6, 8));
            intervalBarSeries1.Items.Add(new IntervalBarItem(4, 8));
            intervalBarSeries1.Items.Add(new IntervalBarItem(5, 11));
            intervalBarSeries1.Items.Add(new IntervalBarItem(4, 12));
            intervalBarSeries1.FillColor=OxyColors.LightBlue;
            intervalBarSeries1.LabelFormatString = "{0},{1}";
           
            PlotModel.Series.Add(intervalBarSeries1);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}