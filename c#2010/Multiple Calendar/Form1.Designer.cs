namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axCalendar1 = new AxCALENDARLib.AxCalendar();
            this.axCalendar2 = new AxCALENDARLib.AxCalendar();
            this.axCalendar3 = new AxCALENDARLib.AxCalendar();
            this.axCalendar4 = new AxCALENDARLib.AxCalendar();
            this.axCalendar5 = new AxCALENDARLib.AxCalendar();
            this.axCalendar6 = new AxCALENDARLib.AxCalendar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar6)).BeginInit();
            this.SuspendLayout();
            // 
            // axCalendar1
            // 
            this.axCalendar1.Enabled = true;
            this.axCalendar1.Location = new System.Drawing.Point(1, 33);
            this.axCalendar1.Name = "axCalendar1";
            this.axCalendar1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar1.OcxState")));
            this.axCalendar1.Size = new System.Drawing.Size(401, 295);
            this.axCalendar1.TabIndex = 0;
            // 
            // axCalendar2
            // 
            this.axCalendar2.Enabled = true;
            this.axCalendar2.Location = new System.Drawing.Point(408, 33);
            this.axCalendar2.Name = "axCalendar2";
            this.axCalendar2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar2.OcxState")));
            this.axCalendar2.Size = new System.Drawing.Size(399, 295);
            this.axCalendar2.TabIndex = 1;
            // 
            // axCalendar3
            // 
            this.axCalendar3.Enabled = true;
            this.axCalendar3.Location = new System.Drawing.Point(813, 33);
            this.axCalendar3.Name = "axCalendar3";
            this.axCalendar3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar3.OcxState")));
            this.axCalendar3.Size = new System.Drawing.Size(401, 295);
            this.axCalendar3.TabIndex = 2;
            // 
            // axCalendar4
            // 
            this.axCalendar4.Enabled = true;
            this.axCalendar4.Location = new System.Drawing.Point(1, 346);
            this.axCalendar4.Name = "axCalendar4";
            this.axCalendar4.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar4.OcxState")));
            this.axCalendar4.Size = new System.Drawing.Size(401, 301);
            this.axCalendar4.TabIndex = 3;
            // 
            // axCalendar5
            // 
            this.axCalendar5.Enabled = true;
            this.axCalendar5.Location = new System.Drawing.Point(408, 346);
            this.axCalendar5.Name = "axCalendar5";
            this.axCalendar5.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar5.OcxState")));
            this.axCalendar5.Size = new System.Drawing.Size(399, 301);
            this.axCalendar5.TabIndex = 4;
            // 
            // axCalendar6
            // 
            this.axCalendar6.Enabled = true;
            this.axCalendar6.Location = new System.Drawing.Point(813, 346);
            this.axCalendar6.Name = "axCalendar6";
            this.axCalendar6.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCalendar6.OcxState")));
            this.axCalendar6.Size = new System.Drawing.Size(401, 309);
            this.axCalendar6.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Highlight Importance days";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axCalendar6);
            this.Controls.Add(this.axCalendar5);
            this.Controls.Add(this.axCalendar4);
            this.Controls.Add(this.axCalendar3);
            this.Controls.Add(this.axCalendar2);
            this.Controls.Add(this.axCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCalendar6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxCALENDARLib.AxCalendar axCalendar1;
        private AxCALENDARLib.AxCalendar axCalendar2;
        private AxCALENDARLib.AxCalendar axCalendar3;
        private AxCALENDARLib.AxCalendar axCalendar4;
        private AxCALENDARLib.AxCalendar axCalendar5;
        private AxCALENDARLib.AxCalendar axCalendar6;
        private System.Windows.Forms.Button button1;
    }
}

