
namespace WeatherWinFormsUI
{
    partial class CurrentWeatherForm
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
        protected void InitializeComponent()
        {
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptionValue = new System.Windows.Forms.Label();
            this.lblVisibility = new System.Windows.Forms.Label();
            this.lblVisibilityValue = new System.Windows.Forms.Label();
            this.lblWindSpeedValue = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblSunriseValue = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.lblSunsetValue = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            this.lblWindDirectionValue = new System.Windows.Forms.Label();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.lblCloudsPercentValue = new System.Windows.Forms.Label();
            this.lblCloudsPercent = new System.Windows.Forms.Label();
            this.lblTempValue = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.grpbxWind = new System.Windows.Forms.GroupBox();
            this.lblCityName = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.lblCountryCodeValue = new System.Windows.Forms.Label();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.grpbxWind.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(167, 12);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(206, 29);
            this.txtCityName.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(8, 180);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(98, 21);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание: ";
            // 
            // lblDescriptionValue
            // 
            this.lblDescriptionValue.AutoSize = true;
            this.lblDescriptionValue.Location = new System.Drawing.Point(230, 180);
            this.lblDescriptionValue.Name = "lblDescriptionValue";
            this.lblDescriptionValue.Size = new System.Drawing.Size(0, 21);
            this.lblDescriptionValue.TabIndex = 3;
            // 
            // lblVisibility
            // 
            this.lblVisibility.AutoSize = true;
            this.lblVisibility.Location = new System.Drawing.Point(8, 218);
            this.lblVisibility.Name = "lblVisibility";
            this.lblVisibility.Size = new System.Drawing.Size(109, 21);
            this.lblVisibility.TabIndex = 4;
            this.lblVisibility.Text = "Видимость: ";
            // 
            // lblVisibilityValue
            // 
            this.lblVisibilityValue.AutoSize = true;
            this.lblVisibilityValue.Location = new System.Drawing.Point(230, 218);
            this.lblVisibilityValue.Name = "lblVisibilityValue";
            this.lblVisibilityValue.Size = new System.Drawing.Size(0, 21);
            this.lblVisibilityValue.TabIndex = 5;
            // 
            // lblWindSpeedValue
            // 
            this.lblWindSpeedValue.AutoSize = true;
            this.lblWindSpeedValue.Location = new System.Drawing.Point(217, 70);
            this.lblWindSpeedValue.Name = "lblWindSpeedValue";
            this.lblWindSpeedValue.Size = new System.Drawing.Size(0, 21);
            this.lblWindSpeedValue.TabIndex = 7;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Location = new System.Drawing.Point(16, 70);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(96, 21);
            this.lblWindSpeed.TabIndex = 6;
            this.lblWindSpeed.Text = "Скорость: ";
            // 
            // lblSunriseValue
            // 
            this.lblSunriseValue.AutoSize = true;
            this.lblSunriseValue.Location = new System.Drawing.Point(230, 430);
            this.lblSunriseValue.Name = "lblSunriseValue";
            this.lblSunriseValue.Size = new System.Drawing.Size(0, 21);
            this.lblSunriseValue.TabIndex = 9;
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.Location = new System.Drawing.Point(8, 430);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(95, 21);
            this.lblSunrise.TabIndex = 8;
            this.lblSunrise.Text = "Рассвет в: ";
            // 
            // lblSunsetValue
            // 
            this.lblSunsetValue.AutoSize = true;
            this.lblSunsetValue.Location = new System.Drawing.Point(230, 472);
            this.lblSunsetValue.Name = "lblSunsetValue";
            this.lblSunsetValue.Size = new System.Drawing.Size(0, 21);
            this.lblSunsetValue.TabIndex = 11;
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Location = new System.Drawing.Point(8, 472);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(76, 21);
            this.lblSunset.TabIndex = 10;
            this.lblSunset.Text = "Закат в: ";
            // 
            // lblWindDirectionValue
            // 
            this.lblWindDirectionValue.AutoSize = true;
            this.lblWindDirectionValue.Location = new System.Drawing.Point(217, 28);
            this.lblWindDirectionValue.Name = "lblWindDirectionValue";
            this.lblWindDirectionValue.Size = new System.Drawing.Size(0, 21);
            this.lblWindDirectionValue.TabIndex = 15;
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.AutoSize = true;
            this.lblWindDirection.Location = new System.Drawing.Point(16, 28);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(122, 21);
            this.lblWindDirection.TabIndex = 14;
            this.lblWindDirection.Text = "Направление: ";
            // 
            // lblCloudsPercentValue
            // 
            this.lblCloudsPercentValue.AutoSize = true;
            this.lblCloudsPercentValue.Location = new System.Drawing.Point(230, 388);
            this.lblCloudsPercentValue.Name = "lblCloudsPercentValue";
            this.lblCloudsPercentValue.Size = new System.Drawing.Size(0, 21);
            this.lblCloudsPercentValue.TabIndex = 17;
            // 
            // lblCloudsPercent
            // 
            this.lblCloudsPercent.AutoSize = true;
            this.lblCloudsPercent.Location = new System.Drawing.Point(8, 388);
            this.lblCloudsPercent.Name = "lblCloudsPercent";
            this.lblCloudsPercent.Size = new System.Drawing.Size(115, 21);
            this.lblCloudsPercent.TabIndex = 16;
            this.lblCloudsPercent.Text = "Облачность: ";
            // 
            // lblTempValue
            // 
            this.lblTempValue.AutoSize = true;
            this.lblTempValue.Location = new System.Drawing.Point(230, 138);
            this.lblTempValue.Name = "lblTempValue";
            this.lblTempValue.Size = new System.Drawing.Size(0, 21);
            this.lblTempValue.TabIndex = 19;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(8, 138);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(121, 21);
            this.lblTemp.TabIndex = 18;
            this.lblTemp.Text = "Температура: ";
            // 
            // grpbxWind
            // 
            this.grpbxWind.Controls.Add(this.lblWindSpeed);
            this.grpbxWind.Controls.Add(this.lblWindSpeedValue);
            this.grpbxWind.Controls.Add(this.lblWindDirection);
            this.grpbxWind.Controls.Add(this.lblWindDirectionValue);
            this.grpbxWind.Location = new System.Drawing.Point(13, 251);
            this.grpbxWind.Name = "grpbxWind";
            this.grpbxWind.Size = new System.Drawing.Size(359, 119);
            this.grpbxWind.TabIndex = 20;
            this.grpbxWind.TabStop = false;
            this.grpbxWind.Text = "Ветер";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(8, 15);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(153, 21);
            this.lblCityName.TabIndex = 21;
            this.lblCityName.Text = "Название города: ";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(93, 47);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(199, 31);
            this.btnGetData.TabIndex = 22;
            this.btnGetData.Text = "Получить данные";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // lblCountryCodeValue
            // 
            this.lblCountryCodeValue.AutoSize = true;
            this.lblCountryCodeValue.Location = new System.Drawing.Point(230, 97);
            this.lblCountryCodeValue.Name = "lblCountryCodeValue";
            this.lblCountryCodeValue.Size = new System.Drawing.Size(0, 21);
            this.lblCountryCodeValue.TabIndex = 24;
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.Location = new System.Drawing.Point(8, 97);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(113, 21);
            this.lblCountryCode.TabIndex = 23;
            this.lblCountryCode.Text = "Код страны: ";
            // 
            // CurrentWeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 516);
            this.Controls.Add(this.lblCountryCodeValue);
            this.Controls.Add(this.lblCountryCode);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.lblVisibility);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.grpbxWind);
            this.Controls.Add(this.lblVisibilityValue);
            this.Controls.Add(this.lblTempValue);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblCloudsPercentValue);
            this.Controls.Add(this.lblCloudsPercent);
            this.Controls.Add(this.lblSunsetValue);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.lblSunriseValue);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(this.lblDescriptionValue);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtCityName);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "CurrentWeatherForm";
            this.Text = "Погода сейчас";
            this.grpbxWind.ResumeLayout(false);
            this.grpbxWind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtCityName;
        protected System.Windows.Forms.Label lblDescription;
        protected System.Windows.Forms.Label lblDescriptionValue;
        protected System.Windows.Forms.Label lblVisibility;
        protected System.Windows.Forms.Label lblVisibilityValue;
        protected System.Windows.Forms.Label lblWindSpeedValue;
        protected System.Windows.Forms.Label lblWindSpeed;
        protected System.Windows.Forms.Label lblSunriseValue;
        protected System.Windows.Forms.Label lblSunrise;
        protected System.Windows.Forms.Label lblSunsetValue;
        protected System.Windows.Forms.Label lblSunset;
        protected System.Windows.Forms.Label lblWindDirectionValue;
        protected System.Windows.Forms.Label lblWindDirection;
        protected System.Windows.Forms.Label lblCloudsPercentValue;
        protected System.Windows.Forms.Label lblCloudsPercent;
        protected System.Windows.Forms.Label lblTempValue;
        protected System.Windows.Forms.Label lblTemp;
        protected System.Windows.Forms.GroupBox grpbxWind;
        protected System.Windows.Forms.Label lblCityName;
        protected System.Windows.Forms.Button btnGetData;
        protected System.Windows.Forms.Label lblCountryCodeValue;
        protected System.Windows.Forms.Label lblCountryCode;
    }
}