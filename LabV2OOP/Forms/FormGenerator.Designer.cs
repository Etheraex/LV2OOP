namespace LabV2OOP
{
    partial class FormGenerator
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxTemp = new System.Windows.Forms.TextBox();
            this.txtBoxPressure = new System.Windows.Forms.TextBox();
            this.txtBoxHumidity = new System.Windows.Forms.TextBox();
            this.txtBoxInterval = new System.Windows.Forms.TextBox();
            this.chkBoxGranice = new System.Windows.Forms.CheckBox();
            this.chkBoxAutomatic = new System.Windows.Forms.CheckBox();
            this.btnProsledi = new System.Windows.Forms.Button();
            this.btnHumidity = new System.Windows.Forms.Button();
            this.btnPressure = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pritisak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vlaznost";
            // 
            // txtBoxTemp
            // 
            this.txtBoxTemp.Location = new System.Drawing.Point(137, 33);
            this.txtBoxTemp.Name = "txtBoxTemp";
            this.txtBoxTemp.Size = new System.Drawing.Size(135, 20);
            this.txtBoxTemp.TabIndex = 5;
            // 
            // txtBoxPressure
            // 
            this.txtBoxPressure.Location = new System.Drawing.Point(137, 73);
            this.txtBoxPressure.Name = "txtBoxPressure";
            this.txtBoxPressure.Size = new System.Drawing.Size(135, 20);
            this.txtBoxPressure.TabIndex = 6;
            // 
            // txtBoxHumidity
            // 
            this.txtBoxHumidity.Location = new System.Drawing.Point(137, 113);
            this.txtBoxHumidity.Name = "txtBoxHumidity";
            this.txtBoxHumidity.Size = new System.Drawing.Size(135, 20);
            this.txtBoxHumidity.TabIndex = 7;
            // 
            // txtBoxInterval
            // 
            this.txtBoxInterval.Location = new System.Drawing.Point(317, 209);
            this.txtBoxInterval.Name = "txtBoxInterval";
            this.txtBoxInterval.Size = new System.Drawing.Size(38, 20);
            this.txtBoxInterval.TabIndex = 8;
            this.txtBoxInterval.TextChanged += new System.EventHandler(this.txtBoxInterval_TextChanged);
            // 
            // chkBoxGranice
            // 
            this.chkBoxGranice.AutoSize = true;
            this.chkBoxGranice.Location = new System.Drawing.Point(16, 188);
            this.chkBoxGranice.Name = "chkBoxGranice";
            this.chkBoxGranice.Size = new System.Drawing.Size(97, 17);
            this.chkBoxGranice.TabIndex = 9;
            this.chkBoxGranice.Text = "Ignorisi granice";
            this.chkBoxGranice.UseVisualStyleBackColor = true;
            // 
            // chkBoxAutomatic
            // 
            this.chkBoxAutomatic.AutoSize = true;
            this.chkBoxAutomatic.Location = new System.Drawing.Point(16, 211);
            this.chkBoxAutomatic.Name = "chkBoxAutomatic";
            this.chkBoxAutomatic.Size = new System.Drawing.Size(295, 17);
            this.chkBoxAutomatic.TabIndex = 10;
            this.chkBoxAutomatic.Text = "Automatsko generisanje podataka. Interval u sekundama";
            this.chkBoxAutomatic.UseVisualStyleBackColor = true;
            this.chkBoxAutomatic.CheckedChanged += new System.EventHandler(this.chkBoxAutomatic_CheckedChanged);
            // 
            // btnProsledi
            // 
            this.btnProsledi.Location = new System.Drawing.Point(170, 139);
            this.btnProsledi.Name = "btnProsledi";
            this.btnProsledi.Size = new System.Drawing.Size(103, 39);
            this.btnProsledi.TabIndex = 11;
            this.btnProsledi.Text = "Prosledi";
            this.btnProsledi.UseVisualStyleBackColor = true;
            this.btnProsledi.Click += new System.EventHandler(this.btnProsledi_Click);
            // 
            // btnHumidity
            // 
            this.btnHumidity.Location = new System.Drawing.Point(303, 110);
            this.btnHumidity.Name = "btnHumidity";
            this.btnHumidity.Size = new System.Drawing.Size(32, 23);
            this.btnHumidity.TabIndex = 12;
            this.btnHumidity.Text = "*";
            this.btnHumidity.UseVisualStyleBackColor = true;
            this.btnHumidity.Click += new System.EventHandler(this.btnHumidity_Click);
            // 
            // btnPressure
            // 
            this.btnPressure.Location = new System.Drawing.Point(303, 70);
            this.btnPressure.Name = "btnPressure";
            this.btnPressure.Size = new System.Drawing.Size(32, 23);
            this.btnPressure.TabIndex = 13;
            this.btnPressure.Text = "*";
            this.btnPressure.UseVisualStyleBackColor = true;
            this.btnPressure.Click += new System.EventHandler(this.btnPressure_Click);
            // 
            // btnTemperature
            // 
            this.btnTemperature.Location = new System.Drawing.Point(303, 30);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(32, 23);
            this.btnTemperature.TabIndex = 14;
            this.btnTemperature.Text = "*";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.btnPressure);
            this.Controls.Add(this.btnHumidity);
            this.Controls.Add(this.btnProsledi);
            this.Controls.Add(this.chkBoxAutomatic);
            this.Controls.Add(this.chkBoxGranice);
            this.Controls.Add(this.txtBoxInterval);
            this.Controls.Add(this.txtBoxHumidity);
            this.Controls.Add(this.txtBoxPressure);
            this.Controls.Add(this.txtBoxTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(400, 274);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 274);
            this.MinimizeBox = false;
            this.Name = "FormGenerator";
            this.Text = "FormGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTemp;
        private System.Windows.Forms.TextBox txtBoxPressure;
        private System.Windows.Forms.TextBox txtBoxHumidity;
        private System.Windows.Forms.TextBox txtBoxInterval;
        private System.Windows.Forms.CheckBox chkBoxGranice;
        private System.Windows.Forms.CheckBox chkBoxAutomatic;
        private System.Windows.Forms.Button btnProsledi;
        private System.Windows.Forms.Button btnHumidity;
        private System.Windows.Forms.Button btnPressure;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Timer timer;
    }
}