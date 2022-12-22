namespace Grocery
{
    partial class MainForm
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
            this.chickenBtn = new System.Windows.Forms.Button();
            this.porkBtn = new System.Windows.Forms.Button();
            this.beefBtn = new System.Windows.Forms.Button();
            this.soapBtn = new System.Windows.Forms.Button();
            this.waterBtn = new System.Windows.Forms.Button();
            this.dishBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.UpDownBtn = new System.Windows.Forms.NumericUpDown();
            this.currentCart = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.totalBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // chickenBtn
            // 
            this.chickenBtn.Location = new System.Drawing.Point(50, 64);
            this.chickenBtn.Name = "chickenBtn";
            this.chickenBtn.Size = new System.Drawing.Size(94, 53);
            this.chickenBtn.TabIndex = 0;
            this.chickenBtn.Text = "chickenBtn";
            this.chickenBtn.UseVisualStyleBackColor = true;
            this.chickenBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // porkBtn
            // 
            this.porkBtn.Location = new System.Drawing.Point(164, 64);
            this.porkBtn.Name = "porkBtn";
            this.porkBtn.Size = new System.Drawing.Size(87, 53);
            this.porkBtn.TabIndex = 1;
            this.porkBtn.Text = "porkBtn";
            this.porkBtn.UseVisualStyleBackColor = true;
            this.porkBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // beefBtn
            // 
            this.beefBtn.Location = new System.Drawing.Point(267, 64);
            this.beefBtn.Name = "beefBtn";
            this.beefBtn.Size = new System.Drawing.Size(89, 53);
            this.beefBtn.TabIndex = 2;
            this.beefBtn.Text = "beefBtn";
            this.beefBtn.UseVisualStyleBackColor = true;
            this.beefBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // soapBtn
            // 
            this.soapBtn.Location = new System.Drawing.Point(50, 123);
            this.soapBtn.Name = "soapBtn";
            this.soapBtn.Size = new System.Drawing.Size(94, 52);
            this.soapBtn.TabIndex = 3;
            this.soapBtn.Text = "soapBtn";
            this.soapBtn.UseVisualStyleBackColor = true;
            this.soapBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // waterBtn
            // 
            this.waterBtn.Location = new System.Drawing.Point(164, 123);
            this.waterBtn.Name = "waterBtn";
            this.waterBtn.Size = new System.Drawing.Size(87, 52);
            this.waterBtn.TabIndex = 4;
            this.waterBtn.Text = "waterBtn";
            this.waterBtn.UseVisualStyleBackColor = true;
            this.waterBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // dishBtn
            // 
            this.dishBtn.Location = new System.Drawing.Point(267, 123);
            this.dishBtn.Name = "dishBtn";
            this.dishBtn.Size = new System.Drawing.Size(89, 52);
            this.dishBtn.TabIndex = 5;
            this.dishBtn.Text = "dishBtn";
            this.dishBtn.UseVisualStyleBackColor = true;
            this.dishBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(176, 221);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "deleteBtn";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // UpDownBtn
            // 
            this.UpDownBtn.Location = new System.Drawing.Point(50, 223);
            this.UpDownBtn.Name = "UpDownBtn";
            this.UpDownBtn.Size = new System.Drawing.Size(120, 20);
            this.UpDownBtn.TabIndex = 9;
            this.UpDownBtn.ValueChanged += new System.EventHandler(this.UpDownBtn_ValueChanged);
            this.UpDownBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpDownBtn_MouseClick);
            // 
            // currentCart
            // 
            this.currentCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Quantity,
            this.Price});
            this.currentCart.HideSelection = false;
            this.currentCart.Location = new System.Drawing.Point(362, 12);
            this.currentCart.Name = "currentCart";
            this.currentCart.Size = new System.Drawing.Size(426, 389);
            this.currentCart.TabIndex = 12;
            this.currentCart.UseCompatibleStateImageBehavior = false;
            this.currentCart.View = System.Windows.Forms.View.Details;
            this.currentCart.ItemActivate += new System.EventHandler(this.currentCart_ItemActivate);
            // 
            // Product
            // 
            this.Product.Text = "Product";
            this.Product.Width = 291;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(267, 221);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(75, 23);
            this.purchaseBtn.TabIndex = 13;
            this.purchaseBtn.Text = "purchaseBtn";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(688, 407);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(100, 20);
            this.totalBox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.currentCart);
            this.Controls.Add(this.UpDownBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.dishBtn);
            this.Controls.Add(this.waterBtn);
            this.Controls.Add(this.soapBtn);
            this.Controls.Add(this.beefBtn);
            this.Controls.Add(this.porkBtn);
            this.Controls.Add(this.chickenBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chickenBtn;
        private System.Windows.Forms.Button porkBtn;
        private System.Windows.Forms.Button beefBtn;
        private System.Windows.Forms.Button soapBtn;
        private System.Windows.Forms.Button waterBtn;
        private System.Windows.Forms.Button dishBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.NumericUpDown UpDownBtn;
        private System.Windows.Forms.ListView currentCart;
        public System.Windows.Forms.ColumnHeader Product;
        public System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.TextBox totalBox;
    }
}