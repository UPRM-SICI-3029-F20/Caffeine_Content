namespace Caffeine_Content
{
    partial class CaffeineForm
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
            this.LblDrink = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMiligrams = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink: ";
            // 
            // LblDrink
            // 
            this.LblDrink.Location = new System.Drawing.Point(78, 27);
            this.LblDrink.Name = "LblDrink";
            this.LblDrink.Size = new System.Drawing.Size(149, 13);
            this.LblDrink.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Caffeine: ";
            // 
            // LblMiligrams
            // 
            this.LblMiligrams.Location = new System.Drawing.Point(78, 53);
            this.LblMiligrams.Name = "LblMiligrams";
            this.LblMiligrams.Size = new System.Drawing.Size(30, 23);
            this.LblMiligrams.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "( mg )";
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(117, 87);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Source";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CaffeineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblMiligrams);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblDrink);
            this.Controls.Add(this.label1);
            this.Name = "CaffeineForm";
            this.Text = "CaffeineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnClose;
        public System.Windows.Forms.Label LblDrink;
        public System.Windows.Forms.Label LblMiligrams;
        private System.Windows.Forms.Button button1;
    }
}