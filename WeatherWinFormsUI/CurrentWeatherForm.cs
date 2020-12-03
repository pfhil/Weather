using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherPresentation.Common;
using WeatherPresentation.Views;

namespace WeatherWinFormsUI
{
    public partial class CurrentWeatherForm : Form, ICurrentWeatherView
    {
        public CurrentWeatherForm()
        {
            InitializeComponent();
        }

        public string CityName { get { return txtCityName.Text; } }

        public event Action GetWeather;

        public void SetWeatherInfo(CurrentWeatherInfo weatherInfo)
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
    }
}
