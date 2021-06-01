using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurencyConverter
{
    public partial class GUI : Form
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public GUI()
        {
            InitializeComponent();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            
            this.chart.Titles.Add("Daily Rates for the Past 30 Days");
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(89, 158);
            this.chart.Name = "chartCurrency";
            
            this.chart.Size = new System.Drawing.Size(400, 200);
            this.chart.TabIndex = 14;
            this.chart.Text = "chart1";
            this.Controls.Add(this.chart);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (validateAmount() && validateComboBoxes())
            {
                generateGraph();
                String startingAmountStr = tbAmount.Text;
                double startingAmount = Double.Parse(startingAmountStr);
                String startingCurrency = cbStartCurrency.Text;
                String finalCurrency = cbEndCurrency.Text;
                tbResult.Text = String.Format("{0:0,0.00}", Converter.Convert(startingAmount, startingCurrency, finalCurrency));
            }
        }

        private void tbAmount_MouseLeave(object sender, EventArgs e)
        {
            String amount = tbAmount.Text.ToString();
            try
            {
                Double.Parse(amount);
                lblError.Text = " ";              

            }
            catch
            {
                lblError.Text = "Invalid entry";
            }
        }

        private Boolean validateAmount()
        {
            String amount = tbAmount.Text.ToString();
            try
            {
                Double.Parse(amount);
                lblError.Text = " ";
                return true;
            }
            catch
            {
                lblError.Text = "Invalid entry";
                return false;
            }
        }

        private Boolean validateComboBoxes()
        {
            String startCurr = cbStartCurrency.Text.ToString();
            String endCurr = cbEndCurrency.Text.ToString();

            if (startCurr.Equals(endCurr))
            {
                lblError2.Text = "starting and ending currency match";
                return false;
            }
            else
            {
                lblError2.Text = " ";
                return true;
            }
        }

        public void generateGraph()
        {
            this.chart.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            List<double> dataStart = Service.getHistory(cbStartCurrency.Text);
            List<double> dataEnd = Service.getHistory(cbEndCurrency.Text);
            for (int i = 0; i < dataStart.Count; i++)
            {
                System.Windows.Forms.DataVisualization.Charting.DataPoint dataStartPoint = new System.Windows.Forms.DataVisualization.Charting.DataPoint(i, dataStart[i]);
                System.Windows.Forms.DataVisualization.Charting.DataPoint dataEndPoint = new System.Windows.Forms.DataVisualization.Charting.DataPoint(i, dataEnd[i]);
                series1.Points.Add(dataStartPoint);
                series2.Points.Add(dataEndPoint);
            }
            // 
            // chartCurrency
            //
            setYAxis(dataStart, dataEnd);
            
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            series1.Name = cbStartCurrency.Text;
            series2.Name = cbEndCurrency.Text;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
        }

        public void setYAxis(List<double> dataStart, List<double> dataEnd)
        {
            double[] startArray = new double[dataStart.Count];
            double[] endArray = new double[dataEnd.Count];
            for (int i = 0; i < dataStart.Count; i++)
            {
                startArray[i] = dataStart[i];
                endArray[i] = dataEnd[i];
            }
            double max = startArray.Max() > endArray.Max() ? startArray.Max() : endArray.Max();
            double min = startArray.Min() < endArray.Min() ? startArray.Min() : endArray.Min();

            this.chart.ChartAreas[0].AxisY.Minimum = Math.Round(min - 3);
            this.chart.ChartAreas[0].AxisY.Maximum = Math.Round(max + 3);
        }


    }
}
