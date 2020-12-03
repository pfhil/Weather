using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeatherPresentation.Views;

namespace WeatherWinFormsUI
{
    public partial class MainForm : Form, IMainView
    {
        ApplicationContext _context;
        public MainForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

        }

        public event Action OpenCurrentWeather;

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnOpenCurrentWearher_Click(object sender, EventArgs e)
        {
            OpenCurrentWeather?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
            //base.Show();
        }
    }
}
