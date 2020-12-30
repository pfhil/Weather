using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherPresentation.Views;
using WeatherPresentation.Common;

namespace WeatherWinFormsUI
{
    public partial class ForecastWeatherForm : Form, IForecastWeatherView
    {
        public ForecastWeatherForm()
        {
            InitializeComponent();
        }

        public string TimeOfDataForecasted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action<int> SelectTime;

        public string CityName { get { return txtCityName.Text; } }

        public event Action GetWeather;

        public void SetWeatherInfo(WeatherInfo weatherInfo)
        {
            lblCountryCodeValue.Text = weatherInfo.CountryCode;
            lblTempValue.Text = weatherInfo.Temp;
            lblDescriptionValue.Text = weatherInfo.Description;
            lblVisibilityValue.Text = weatherInfo.Visibility;
            lblWindSpeedValue.Text = weatherInfo.WindSpeed;
            lblWindDirectionValue.Text = weatherInfo.WindDirection;
            lblCloudsPercentValue.Text = weatherInfo.CloudsPercent;
            lblCountryCodeValue.Text = weatherInfo.CountryCode;
            lblSunriseValue.Text = weatherInfo.Sunrise;
            lblSunsetValue.Text = weatherInfo.Sunset;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            GetWeather?.Invoke();
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void AddTimeItem(string TimeItem)
        {
            cmbTime.Items.Add(TimeItem);
        }

        public void ResetTimeList()
        {
            cmbTime.Items.Clear();
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTime?.Invoke(cmbTime.SelectedIndex);
        }
    }
}
