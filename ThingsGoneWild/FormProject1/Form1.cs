using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject1
{
    public partial class Form1 : Form
    {
        int totalPrice = 0;
        string[] products = new string[] { "Tomatoes 4$", "Carrots 5$", "Potatoes 2$", "Spinach 7$", "Melon 10$", "Watermelon 17$", "Ketchup 25$", "Mayonnaise 24$", "BBQ Sauce 47$", "Hot Sauce 57$" };
        int[] prices = new int[] { 4, 5, 2, 7, 10, 17, 25, 24, 47, 57 };
        string paymentText = "Salam";
        public Form1()
        {
            InitializeComponent();
        }
       
        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string removeFromCartText = "Remove From Cart!";
            string cartText = "Cart";
            string productsText = "Products";
            string addToCartText = "Add To Cart!";
            string paymentText = "Total Price = " + totalPrice.ToString()+"$";
            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartText;
            btnPayment.Text = paymentText;
            


            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);

            }
           
            btnRemoveFromCart.Enabled = false;
            

           
            
            
            
            //for (int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);
            //}

            /*
            lbxProducts.Items.Add("Tomatoes");
            lbxProducts.Items.Add("Carrots");
            lbxProducts.Items.Add("Potatoes");
            lbxProducts.Items.Add("Spinach");
            lbxProducts.Items.Add("Melon");
            lbxProducts.Items.Add("Watermelon");
            */
        }

        private void lbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            

            if (lbxProducts.SelectedItem != null )
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                
                btnRemoveFromCart.Enabled = true;
                for (int i = 0; i < products.Length; i++)
                {
                    if (lbxProducts.SelectedItem.ToString()==products[i])
                    {
                        totalPrice = totalPrice + prices[i];
                    }
                }
                lbxProducts.Items.Remove(lbxProducts.SelectedItem);
                
            }

            if (lbxProducts.Items.Count == 0)
            {
                btnAddToCart.Enabled = false;

            }
            paymentText = "Total Price = " + totalPrice.ToString() + "$";
            btnPayment.Text = paymentText;
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
           
            if (lbxCart.SelectedItem != null)
            {
                lbxProducts.Items.Add(lbxCart.SelectedItem);
                
                btnAddToCart.Enabled = true;
                for (int i = 0; i < products.Length; i++)
                {
                    if (lbxCart.SelectedItem.ToString() == products[i])
                    {
                        totalPrice = totalPrice - prices[i];
                    }
                
               }
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }

          
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;

            }

            paymentText = "Total Price = " + totalPrice.ToString() + "$";
            btnPayment.Text = paymentText;
        }

     

        private void btnPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your bill is "+totalPrice.ToString()+"$");
        }
    }
}
