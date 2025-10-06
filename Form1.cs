using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        private readonly StoreManager store = new StoreManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshStoreItems();
            RefreshCart();
        }

        private void RefreshStoreItems()
        {
            listBoxStore.Items.Clear();
            foreach (var item in store.GetStoreItems())
            {
                listBoxStore.Items.Add($"{item.Value.Name} - Rs.{item.Value.Price} (Stock: {item.Value.Stock})");
            }
        }

        private void RefreshCart()
        {
            listBoxCart.Items.Clear();
            foreach (var item in store.GetCartItems())
            {
                listBoxCart.Items.Add($"{item.Name} x {item.Quantity} = Rs.{item.Price * item.Quantity}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtItemName.Text.Trim();
            if (!int.TryParse(txtQuantity.Text.Trim(), out int qty))
            {
                MessageBox.Show("Enter a valid quantity!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool added = store.AddToCart(name, qty);
            if (added)
            {
                MessageBox.Show($"{qty} x {name} added to cart.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCart();
                RefreshStoreItems();
            }
            else
            {
                MessageBox.Show("Invalid item name or insufficient stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = txtItemName.Text.Trim();
            bool removed = store.RemoveFromCart(name);
            if (removed)
            {
                MessageBox.Show($"{name} removed from cart.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshCart();
                RefreshStoreItems();
            }
            else
            {
                MessageBox.Show("Item not found in cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            bool wrap = chkGiftWrap.Checked;
            string promo = txtPromo.Text.Trim();

            int total = store.Checkout(wrap, promo);
            MessageBox.Show($"Final Total: Rs.{total}", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshCart();
            RefreshStoreItems();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            string top = store.GetTopItem();
            int total = store.GetTotalSales();
            MessageBox.Show($"Total Sales: Rs.{total}\nMost sold: {top}", "Sales Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStoreItems();
            RefreshCart();
        }

        private void listBoxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStore.SelectedItem == null) return;
            string s = listBoxStore.SelectedItem.ToString();
            int idx = s.IndexOf(" - Rs", StringComparison.Ordinal);
            if (idx > 0)
            {
                txtItemName.Text = s.Substring(0, idx);
            }
            else
            {
                txtItemName.Text = s;
            }
        }
    }
}
