namespace SUBD
{
    partial class adm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(124, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите таблицу";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(51, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 44);
            this.button4.TabIndex = 1;
            this.button4.Text = "Client";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(256, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 44);
            this.button5.TabIndex = 1;
            this.button5.Text = "Dealership";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(51, 297);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 44);
            this.button7.TabIndex = 1;
            this.button7.Text = "Manager";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button10.Location = new System.Drawing.Point(51, 129);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(127, 46);
            this.button10.TabIndex = 1;
            this.button10.Text = "Brand";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button11.Location = new System.Drawing.Point(256, 129);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(139, 46);
            this.button11.TabIndex = 1;
            this.button11.Text = "Car";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button12.Location = new System.Drawing.Point(256, 297);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(139, 44);
            this.button12.TabIndex = 1;
            this.button12.Text = "Model";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button13.Location = new System.Drawing.Point(459, 129);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(137, 46);
            this.button13.TabIndex = 1;
            this.button13.Text = "Car_with_defect";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button14.Location = new System.Drawing.Point(459, 216);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(137, 44);
            this.button14.TabIndex = 1;
            this.button14.Text = "Defect";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button15.Location = new System.Drawing.Point(459, 297);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(137, 38);
            this.button15.TabIndex = 1;
            this.button15.Text = "Paper";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 399);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label1);
            this.Name = "adm";
            this.Text = "adm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
    }
}