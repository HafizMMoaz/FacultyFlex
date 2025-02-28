using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBS25P023.UI {
    public partial class Dashboard : UserControl {
        public Dashboard() {
            InitializeComponent();
            LoadChartData();
        }


        private void LoadChartData() {
            // Clear existing data if any
            chart1.Series.Clear();

            // Create Series
            Series boardMarkersSeries = new Series("Board Markers");
            Series hdmiConvertersSeries = new Series("HDMI Converters");
            Series dustorsSeries = new Series("Dustors");

            // Set Chart Type
            boardMarkersSeries.ChartType = SeriesChartType.Column;
            hdmiConvertersSeries.ChartType = SeriesChartType.Column;
            dustorsSeries.ChartType = SeriesChartType.Column;

            // Add Data Points
            int[] boardMarkers = { 15, 40, 55, 30 };
            int[] hdmiConverters = { 60, 50, 65, 25 };
            int[] dustors = { 70, 65, 60, 80 };

            for (int i = 0; i < boardMarkers.Length; i++) {
                boardMarkersSeries.Points.AddXY(i + 1, boardMarkers[i]);
                hdmiConvertersSeries.Points.AddXY(i + 1, hdmiConverters[i]);
                dustorsSeries.Points.AddXY(i + 1, dustors[i]);
            }

            // Add Series to Chart
            chart1.Series.Add(boardMarkersSeries);
            chart1.Series.Add(hdmiConvertersSeries);
            chart1.Series.Add(dustorsSeries);

            // Configure Chart Appearance
            chart1.ChartAreas[0].AxisX.Title = "Request Instance";
            chart1.ChartAreas[0].AxisY.Title = "Quantity";
        }
    }
}
