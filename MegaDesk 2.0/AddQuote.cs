using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_Muzo.Desk;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Muzo
{
    public partial class AddQuote : Form
    {
        public AddQuote()



        {
            InitializeComponent();

            // Set the minimum and maximum values for the width and depth 
            WidthNum.Minimum = Desk.MinWidth;
            WidthNum.Maximum = Desk.MaxWidth;
            DepthNum.Minimum = Desk.MinDepth;
            DepthNum.Maximum = Desk.MaxDepth;

            // Set the minimum and maximum values for drawers
            DrawersNum.Minimum = 0;
            DrawersNum.Maximum = 7;
            

            // Add items to the Surface materials combo box
            foreach (DesktopMaterial material in Enum.GetValues(typeof(DesktopMaterial)))
            {
                SurCombo.Items.Add(material.ToString().ToLower());
            }

            // Add items to Delivery combo box
            DelCombo.Items.Add("3 days");
            DelCombo.Items.Add("5 days");
            DelCombo.Items.Add("7 days");
            // Attach event handler to GetQuoteButton Click event
            getquotebutton.Click += GetQuoteButton_Click;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
        private void GetQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input values from the form
                int width = (int)WidthNum.Value;
                int depth = (int)DepthNum.Value;
                int drawers = (int)DrawersNum.Value;
                string customerName = textBox1.Text;
                string surfaceMaterial = SurCombo.SelectedItem?.ToString();
                string deliveryTime = DelCombo.SelectedItem?.ToString();

                // Validate the input values
                if (string.IsNullOrEmpty(customerName))
                {
                    throw new Exception("Please enter the customer name.");
                }

                if (drawers < 1 || drawers > 7)
                {
                    throw new Exception("Invalid number of drawers. Please enter a value between 1 and 7.");
                }

                if (width < Desk.MinWidth || width > Desk.MaxWidth)
                {
                    throw new Exception("Invalid width value. Please enter a value between " + Desk.MinWidth + " and " + Desk.MaxWidth + ".");
                }

                if (depth < Desk.MinDepth || depth > Desk.MaxDepth)
                {
                    throw new Exception("Invalid depth value. Please enter a value between " + Desk.MinDepth + " and " + Desk.MaxDepth + ".");
                }

                if (string.IsNullOrEmpty(surfaceMaterial))
                {
                    throw new Exception("Please select a surface material.");
                }

                if (string.IsNullOrEmpty(deliveryTime))
                {
                    throw new Exception("Please select a delivery time.");
                }

                // Your code for calculating the quote goes here...

                MessageBox.Show("Quote calculated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating quote: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}