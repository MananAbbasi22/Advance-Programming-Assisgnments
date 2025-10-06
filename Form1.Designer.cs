namespace ConsoleApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxStore;
        private System.Windows.Forms.ListBox listBoxCart;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.CheckBox chkGiftWrap;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPromo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxStore = new System.Windows.Forms.ListBox();
            this.listBoxCart = new System.Windows.Forms.ListBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.chkGiftWrap = new System.Windows.Forms.CheckBox();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPromo = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // listBoxStore
            this.listBoxStore.FormattingEnabled = true;
            this.listBoxStore.ItemHeight = 16;
            this.listBoxStore.Location = new System.Drawing.Point(12, 29);
            this.listBoxStore.Name = "listBoxStore";
            this.listBoxStore.Size = new System.Drawing.Size(360, 292);
            this.listBoxStore.TabIndex = 0;
            this.listBoxStore.SelectedIndexChanged += new System.EventHandler(this.listBoxStore_SelectedIndexChanged);

            // listBoxCart
            this.listBoxCart.FormattingEnabled = true;
            this.listBoxCart.ItemHeight = 16;
            this.listBoxCart.Location = new System.Drawing.Point(392, 29);
            this.listBoxCart.Name = "listBoxCart";
            this.listBoxCart.Size = new System.Drawing.Size(360, 292);
            this.listBoxCart.TabIndex = 1;

            // txtItemName
            this.txtItemName.Location = new System.Drawing.Point(94, 335);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(278, 22);
            this.txtItemName.TabIndex = 2;

            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(94, 367);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 3;

            // chkGiftWrap
            this.chkGiftWrap.AutoSize = true;
            this.chkGiftWrap.Location = new System.Drawing.Point(392, 333);
            this.chkGiftWrap.Name = "chkGiftWrap";
            this.chkGiftWrap.Size = new System.Drawing.Size(170, 21);
            this.chkGiftWrap.TabIndex = 4;
            this.chkGiftWrap.Text = "Gift Wrap (Rs.200 each)";
            this.chkGiftWrap.UseVisualStyleBackColor = true;

            // txtPromo
            this.txtPromo.Location = new System.Drawing.Point(392, 366);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(170, 22);
            this.txtPromo.TabIndex = 5;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(12, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnRemove
            this.btnRemove.Location = new System.Drawing.Point(128, 405);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 30);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // btnCheckout
            this.btnCheckout.Location = new System.Drawing.Point(392, 405);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(110, 30);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

            // btnReport
            this.btnReport.Location = new System.Drawing.Point(508, 405);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(110, 30);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(624, 405);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 30);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // Labels
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(12, 9);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(84, 17);
            this.lblStore.TabIndex = 11;
            this.lblStore.Text = "Store Items";

            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(389, 9);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(68, 17);
            this.lblCart.TabIndex = 12;
            this.lblCart.Text = "Cart Items";

            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(12, 338);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(76, 17);
            this.lblItemName.TabIndex = 13;
            this.lblItemName.Text = "Item Name";

            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 370);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity";

            this.lblPromo.AutoSize = true;
            this.lblPromo.Location = new System.Drawing.Point(392, 346);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Size = new System.Drawing.Size(83, 17);
            this.lblPromo.TabIndex = 15;
            this.lblPromo.Text = "Promo Code";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lblStore);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.chkGiftWrap);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.listBoxCart);
            this.Controls.Add(this.listBoxStore);
            this.Name = "Form1";
            this.Text = "Clothing Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
