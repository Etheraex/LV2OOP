﻿namespace LabV2OOP
{
    partial class FormStatisticalData
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
            this.txtBoxMoist = new System.Windows.Forms.TextBox();
            this.txtBoxPress = new System.Windows.Forms.TextBox();
            this.txtBoxTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblPres = new System.Windows.Forms.Label();
            this.lblHumid = new System.Windows.Forms.Label();
            this.lblVrednost = new System.Windows.Forms.Label();
            this.chkBoxStats = new System.Windows.Forms.CheckBox();
            this.txtBoxStats = new System.Windows.Forms.TextBox();
            this.errorStats = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorStats)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxMoist
            // 
            this.txtBoxMoist.Location = new System.Drawing.Point(136, 110);
            this.txtBoxMoist.Name = "txtBoxMoist";
            this.txtBoxMoist.Size = new System.Drawing.Size(94, 20);
            this.txtBoxMoist.TabIndex = 13;
            // 
            // txtBoxPress
            // 
            this.txtBoxPress.Location = new System.Drawing.Point(136, 70);
            this.txtBoxPress.Name = "txtBoxPress";
            this.txtBoxPress.Size = new System.Drawing.Size(94, 20);
            this.txtBoxPress.TabIndex = 12;
            // 
            // txtBoxTemp
            // 
            this.txtBoxTemp.Location = new System.Drawing.Point(136, 30);
            this.txtBoxTemp.Name = "txtBoxTemp";
            this.txtBoxTemp.Size = new System.Drawing.Size(94, 20);
            this.txtBoxTemp.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Vlaznost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pritisak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Temperatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Prosek: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Prosek: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Prosek: ";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(345, 33);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(35, 13);
            this.lblTemp.TabIndex = 17;
            this.lblTemp.Text = "label7";
            // 
            // lblPres
            // 
            this.lblPres.AutoSize = true;
            this.lblPres.Location = new System.Drawing.Point(345, 73);
            this.lblPres.Name = "lblPres";
            this.lblPres.Size = new System.Drawing.Size(35, 13);
            this.lblPres.TabIndex = 18;
            this.lblPres.Text = "label8";
            // 
            // lblHumid
            // 
            this.lblHumid.AutoSize = true;
            this.lblHumid.Location = new System.Drawing.Point(345, 115);
            this.lblHumid.Name = "lblHumid";
            this.lblHumid.Size = new System.Drawing.Size(35, 13);
            this.lblHumid.TabIndex = 19;
            this.lblHumid.Text = "label9";
            // 
            // lblVrednost
            // 
            this.lblVrednost.AutoSize = true;
            this.lblVrednost.Location = new System.Drawing.Point(236, 158);
            this.lblVrednost.Name = "lblVrednost";
            this.lblVrednost.Size = new System.Drawing.Size(50, 13);
            this.lblVrednost.TabIndex = 19;
            this.lblVrednost.Text = "vrednosti";
            // 
            // chkBoxStats
            // 
            this.chkBoxStats.AutoSize = true;
            this.chkBoxStats.Location = new System.Drawing.Point(15, 157);
            this.chkBoxStats.Name = "chkBoxStats";
            this.chkBoxStats.Size = new System.Drawing.Size(165, 17);
            this.chkBoxStats.TabIndex = 20;
            this.chkBoxStats.Text = "Uradi statistiku za poslednjih: ";
            this.chkBoxStats.UseVisualStyleBackColor = true;
            this.chkBoxStats.CheckedChanged += new System.EventHandler(this.chkBoxStats_CheckedChanged);
            // 
            // txtBoxStats
            // 
            this.txtBoxStats.Location = new System.Drawing.Point(186, 155);
            this.txtBoxStats.Name = "txtBoxStats";
            this.txtBoxStats.Size = new System.Drawing.Size(44, 20);
            this.txtBoxStats.TabIndex = 13;
            this.txtBoxStats.TextChanged += new System.EventHandler(this.txtBoxStats_TextChanged);
            // 
            // errorStats
            // 
            this.errorStats.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorStats.ContainerControl = this;
            // 
            // FormStatisticalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(718, 183);
            this.Controls.Add(this.chkBoxStats);
            this.Controls.Add(this.lblVrednost);
            this.Controls.Add(this.lblHumid);
            this.Controls.Add(this.lblPres);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxStats);
            this.Controls.Add(this.txtBoxMoist);
            this.Controls.Add(this.txtBoxPress);
            this.Controls.Add(this.txtBoxTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(734, 221);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(734, 221);
            this.Name = "FormStatisticalData";
            this.Text = "FormStatisticalData";
            ((System.ComponentModel.ISupportInitialize)(this.errorStats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMoist;
        private System.Windows.Forms.TextBox txtBoxPress;
        private System.Windows.Forms.TextBox txtBoxTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblPres;
        private System.Windows.Forms.Label lblHumid;
        private System.Windows.Forms.Label lblVrednost;
        private System.Windows.Forms.CheckBox chkBoxStats;
        private System.Windows.Forms.TextBox txtBoxStats;
        private System.Windows.Forms.ErrorProvider errorStats;
    }
}