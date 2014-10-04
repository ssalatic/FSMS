namespace FSMS
{
    partial class InputForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTheory = new System.Windows.Forms.TabPage();
            this.tabFlights = new System.Windows.Forms.TabPage();
            this.tabFinance = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabTheory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTheory);
            this.tabControl1.Controls.Add(this.tabFlights);
            this.tabControl1.Controls.Add(this.tabFinance);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 884);
            this.tabControl1.TabIndex = 0;
            // 
            // tabTheory
            // 
            this.tabTheory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTheory.Controls.Add(this.groupBox1);
            this.tabTheory.Location = new System.Drawing.Point(4, 29);
            this.tabTheory.Name = "tabTheory";
            this.tabTheory.Padding = new System.Windows.Forms.Padding(3);
            this.tabTheory.Size = new System.Drawing.Size(1219, 851);
            this.tabTheory.TabIndex = 0;
            this.tabTheory.Text = "Theory";
            this.tabTheory.UseVisualStyleBackColor = true;
            // 
            // tabFlights
            // 
            this.tabFlights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabFlights.Location = new System.Drawing.Point(4, 29);
            this.tabFlights.Name = "tabFlights";
            this.tabFlights.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlights.Size = new System.Drawing.Size(1219, 851);
            this.tabFlights.TabIndex = 1;
            this.tabFlights.Text = "Flights";
            this.tabFlights.UseVisualStyleBackColor = true;
            // 
            // tabFinance
            // 
            this.tabFinance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabFinance.Location = new System.Drawing.Point(4, 29);
            this.tabFinance.Name = "tabFinance";
            this.tabFinance.Size = new System.Drawing.Size(1219, 851);
            this.tabFinance.TabIndex = 2;
            this.tabFinance.Text = "Finance";
            this.tabFinance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(205, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 595);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 909);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "InputForm";
            this.ShowIcon = false;
            this.Text = "InputForm";
            this.tabControl1.ResumeLayout(false);
            this.tabTheory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTheory;
        private System.Windows.Forms.TabPage tabFlights;
        private System.Windows.Forms.TabPage tabFinance;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}