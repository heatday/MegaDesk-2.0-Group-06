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
        QuoteManager QuoteManager;
        MainMenu menu;
        public AddQuote(ref QuoteManager quoteManager, MainMenu menu)
        {
            QuoteManager = quoteManager;
            this.menu = menu;
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
            foreach (SurfaceMaterial material in Enum.GetValues(typeof(SurfaceMaterial)))
            {
                SurCombo.Items.Add(material.ToString().ToLower());
            }

            // Add items to Delivery combo box
            DelCombo.Items.Add("None");
            DelCombo.Items.Add("3 days");
            DelCombo.Items.Add("5 days");
            DelCombo.Items.Add("7 days");
        }



        private void getquotebutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(WidthNum.Text);
                double depth = double.Parse(DepthNum.Text);
                int drawerCount = int.Parse(DrawersNum.Text);
                string material = SurCombo.Text.ToLower().TrimEnd();
                string name = textBox1.Text;
                string rush = DelCombo.Text;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a customer name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(material))
                {
                    MessageBox.Show("Please select a surface material.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(rush))
                {
                    MessageBox.Show("Please select a rush option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (drawerCount < 1 || drawerCount > 7)
                {
                    MessageBox.Show("Invalid drawer count. Please select a value between 1 and 7.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                QuoteManager.AddQuote(depth, width, drawerCount, material, name, rush);
                QuoteManager.SaveQuote();
                this.Close();
                menu.Show();

                MessageBox.Show("Quote added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values for width and depth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}