using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherPresentation.Common
{
    public interface IView
    {
        void Show();
        void Close();
        void ShowMessage(string message);
    }
}
