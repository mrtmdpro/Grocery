namespace Grocery
{
    partial class CheckoutForm
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
            this.totalBox = new System.Windows.Forms.TextBox();
            this.totalLb = new System.Windows.Forms.Label();
            this.ShippingMethodLb = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.noteLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(335, 153);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(186, 20);
            this.totalBox.TabIndex = 0;
            // 
            // totalLb
            // 
            this.totalLb.AutoSize = true;
            this.totalLb.Location = new System.Drawing.Point(291, 160);
            this.totalLb.Name = "totalLb";
            this.totalLb.Size = new System.Drawing.Size(31, 13);
            this.totalLb.TabIndex = 1;
            this.totalLb.Text = "Total";
            // 
            // ShippingMethodLb
            // 
            this.ShippingMethodLb.AutoSize = true;
            this.ShippingMethodLb.Location = new System.Drawing.Point(43, 153);
            this.ShippingMethodLb.Name = "ShippingMethodLb";
            this.ShippingMethodLb.Size = new System.Drawing.Size(86, 13);
            this.ShippingMethodLb.TabIndex = 5;
            this.ShippingMethodLb.Text = "Shipping method";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(46, 179);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Self checkout";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(46, 209);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "By car";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(46, 239);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "By truck";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(335, 343);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(186, 47);
            this.confirmBtn.TabIndex = 9;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(335, 197);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(186, 140);
            this.noteBox.TabIndex = 10;
            // 
            // noteLb
            // 
            this.noteLb.AutoSize = true;
            this.noteLb.Location = new System.Drawing.Point(294, 257);
            this.noteLb.Name = "noteLb";
            this.noteLb.Size = new System.Drawing.Size(30, 13);
            this.noteLb.TabIndex = 11;
            this.noteLb.Text = "Note";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noteLb);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.ShippingMethodLb);
            this.Controls.Add(this.totalLb);
            this.Controls.Add(this.totalBox);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label totalLb;
        private System.Windows.Forms.Label ShippingMethodLb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label noteLb;
    }
}