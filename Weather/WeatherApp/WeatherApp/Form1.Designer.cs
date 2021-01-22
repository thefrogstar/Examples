
namespace WeatherApp
{
    partial class Form1
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
            this.tlpWeather = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tlpPage = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windDirLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.pbCloud = new System.Windows.Forms.PictureBox();
            this.tlpWeather.SuspendLayout();
            this.tlpPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpWeather
            // 
            this.tlpWeather.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpWeather.ColumnCount = 2;
            this.tlpWeather.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpWeather.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlpWeather.Controls.Add(this.label2, 0, 2);
            this.tlpWeather.Controls.Add(this.label1, 0, 1);
            this.tlpWeather.Controls.Add(this.label6, 0, 0);
            this.tlpWeather.Controls.Add(this.label4, 0, 3);
            this.tlpWeather.Controls.Add(this.pbCloud, 1, 3);
            this.tlpWeather.Controls.Add(this.dateLabel, 1, 0);
            this.tlpWeather.Controls.Add(this.temperatureLabel, 1, 1);
            this.tlpWeather.Controls.Add(this.panel2, 1, 2);
            this.tlpWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpWeather.Location = new System.Drawing.Point(79, 87);
            this.tlpWeather.Name = "tlpWeather";
            this.tlpWeather.RowCount = 4;
            this.tlpWeather.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tlpWeather.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.555555F));
            this.tlpWeather.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlpWeather.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tlpWeather.Size = new System.Drawing.Size(603, 546);
            this.tlpWeather.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wind";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cloud Cover";
            // 
            // tlpPage
            // 
            this.tlpPage.ColumnCount = 3;
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPage.Controls.Add(this.tlpWeather, 1, 1);
            this.tlpPage.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tlpPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPage.Location = new System.Drawing.Point(0, 0);
            this.tlpPage.Name = "tlpPage";
            this.tlpPage.RowCount = 2;
            this.tlpPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20755F));
            this.tlpPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.79245F));
            this.tlpPage.Size = new System.Drawing.Size(762, 636);
            this.tlpPage.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(79, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(603, 78);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbLocation);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 73);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Chose Location";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Sandhurst",
            "Bahrain",
            "Greenland",
            "Australia"});
            this.cbLocation.Location = new System.Drawing.Point(126, 8);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(299, 21);
            this.cbLocation.TabIndex = 2;
            this.cbLocation.Text = "Sandhurst";
            this.cbLocation.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(123, 51);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(125, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Longitude: --- Latitude: ---";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update Weather";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Location = new System.Drawing.Point(157, 3);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(440, 29);
            this.dateLabel.TabIndex = 7;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(157, 35);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(0, 25);
            this.temperatureLabel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.windSpeedLabel);
            this.panel2.Controls.Add(this.windDirLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(157, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 111);
            this.panel2.TabIndex = 9;
            // 
            // windDirLabel
            // 
            this.windDirLabel.AutoSize = true;
            this.windDirLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.windDirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windDirLabel.Location = new System.Drawing.Point(0, 0);
            this.windDirLabel.Name = "windDirLabel";
            this.windDirLabel.Size = new System.Drawing.Size(0, 55);
            this.windDirLabel.TabIndex = 0;
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.windSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.Location = new System.Drawing.Point(440, 0);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(0, 39);
            this.windSpeedLabel.TabIndex = 1;
            // 
            // pbCloud
            // 
            this.pbCloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCloud.Location = new System.Drawing.Point(157, 190);
            this.pbCloud.Name = "pbCloud";
            this.pbCloud.Size = new System.Drawing.Size(440, 350);
            this.pbCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCloud.TabIndex = 6;
            this.pbCloud.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 636);
            this.Controls.Add(this.tlpPage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpWeather.ResumeLayout(false);
            this.tlpWeather.PerformLayout();
            this.tlpPage.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpWeather;
        private System.Windows.Forms.TableLayoutPanel tlpPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.PictureBox pbCloud;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Label windDirLabel;
    }
}

