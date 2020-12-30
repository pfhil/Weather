
namespace WeatherWinFormsUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenCurrentWearher = new System.Windows.Forms.Button();
            this.btnOpenForecastWeather = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenCurrentWearher
            // 
            this.btnOpenCurrentWearher.Location = new System.Drawing.Point(41, 65);
            this.btnOpenCurrentWearher.Name = "btnOpenCurrentWearher";
            this.btnOpenCurrentWearher.Size = new System.Drawing.Size(112, 42);
            this.btnOpenCurrentWearher.TabIndex = 0;
            this.btnOpenCurrentWearher.Text = "Погода сейчас";
            this.btnOpenCurrentWearher.UseVisualStyleBackColor = true;
            this.btnOpenCurrentWearher.Click += new System.EventHandler(this.btnOpenCurrentWearher_Click);
            // 
            // btnOpenForecastWeather
            // 
            this.btnOpenForecastWeather.Location = new System.Drawing.Point(234, 65);
            this.btnOpenForecastWeather.Name = "btnOpenForecastWeather";
            this.btnOpenForecastWeather.Size = new System.Drawing.Size(112, 42);
            this.btnOpenForecastWeather.TabIndex = 1;
            this.btnOpenForecastWeather.Text = "Прогноз на 5 дней";
            this.btnOpenForecastWeather.UseVisualStyleBackColor = true;
            this.btnOpenForecastWeather.Click += new System.EventHandler(this.btnOpenForecastWeather_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 173);
            this.Controls.Add(this.btnOpenForecastWeather);
            this.Controls.Add(this.btnOpenCurrentWearher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Парсер погоды";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCurrentWearher;
        private System.Windows.Forms.Button btnOpenForecastWeather;
    }
}