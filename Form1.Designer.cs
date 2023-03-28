
namespace BiciPlaza
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
            this.dtp_dropoff = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtp_dropoff
            // 
            this.dtp_dropoff.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_dropoff.Location = new System.Drawing.Point(390, 200);
            this.dtp_dropoff.Name = "dtp_dropoff";
            this.dtp_dropoff.ShowUpDown = true;
            this.dtp_dropoff.Size = new System.Drawing.Size(110, 20);
            this.dtp_dropoff.TabIndex = 0;
            this.dtp_dropoff.Value = new System.DateTime(2023, 3, 27, 6, 0, 0, 0);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(12, 200);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(372, 16);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Seleccione la hora en la que desea dejar de usar la bicicleta:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(157, 142);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(227, 16);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Seleccione el tamaño de la bicicleta:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Triciclo",
            "8-10 años",
            "10-13 años",
            "13-16 años",
            "Adulto",
            "Adulto Grande"});
            this.comboBox1.Location = new System.Drawing.Point(391, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dtp_dropoff);
            this.Name = "Form1";
            this.Text = "BiciPlaza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_dropoff;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

