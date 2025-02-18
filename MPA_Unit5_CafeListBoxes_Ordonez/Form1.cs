using CafeMenuItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Izac Ordonez
//this is the CafeListBoxes program Unit 5
//Feb 24 2024

//make a list box with all the menu items
//make a list box parallel that shows the items selected and the price
//make a delete selected item from the order listbox click event
//calculate the total of all the items from the order list box
//add tax 5.5%
//display subtotal tax and total

namespace MPA_Unit5_CafeListBoxes_Ordonez
{
    public partial class Form1 : Form
    {
        public static double TAXRATE = 0.055;
        public Form1()
        {
            InitializeComponent();

        }

        private void MenuListBox_SelectedIndexChanged(object sender, EventArgs e)
        {//this adds the items from the menu listbox to the order list box
            orderListBox.Items.Add(MenuListBox.SelectedItem);
        }

        private void orderListBox_Click(object sender, EventArgs e)
        {//this removes items from the order list box by clicking on them
            int i;
            i = orderListBox.SelectedIndex;
            orderListBox.Items.RemoveAt(i);
            orderListBox.SelectedIndex = -1;
        }

        private void Calculatebutton_Click(object sender, EventArgs e)
        {// recieved some help for this
         //declare variables
            double tax=0,total=0,subtotal = 0;
            //const double TAXRATE = 0.055;

            //this foreach loop splits the string allowing
            //a price to be found to do the calculations
            

            foreach (var item in orderListBox.Items)
            {

                var mycmiitem = (CMI)item;
                double price = (double)mycmiitem.Price;
                subtotal += price;


                //var price = (double)((CMI)item).Price;
                //    //the split happens at the '$' and the Last() has it so
                //    //it is the last '$' in the sting it chooses to split
                //    var itemPriceString = item.ToString().Split('$').Last();
                //    var itemPrice = double.Parse(itemPriceString);

                //   //this += takes the items and adds them to the subtotal 
                //subtotal += price;
                //tax = subtotal * TAXRATE;
                //total = tax + subtotal;
            }
            var taxtotal = (TAXRATE * subtotal); 
            var ordertotal = subtotal + taxtotal;




            //clears the listbox befor putting in the new subtotal, tax and total
            recieptListBox.Items.Clear();
            //displays calculations in a listbox
            recieptListBox.Items.Add("Subtotal : "+ subtotal.ToString("C"));
            recieptListBox.Items.Add("Tax : " + taxtotal  .ToString("C"));
            recieptListBox.Items.Add("Total : " + ordertotal.ToString("C"));



        }

        private void calcLabel_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderListBox.Items.Clear();
            recieptListBox.Items.Clear();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult drResult;
            drResult = MessageBox.Show("Are you sure?", "Exit?", MessageBoxButtons.OKCancel);
            if (drResult == DialogResult.OK)
                e.Cancel = false; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CMI[] cafeitems = new CMI[]
            {
               new CMI("Small coffee",1.25m, _Category.Beverage),
               new CMI("large coffee",1.75m, _Category.Beverage),
               new CMI("cappuccino",2.75m, _Category.Beverage),
               new CMI("mocha cappucino",3.25m, _Category.Beverage),
               new CMI("Cafe au lait",3.00m, _Category.Beverage),
               new CMI("orange juice",1.25m, _Category.Beverage),
               new CMI("apple juice",1.25m, _Category.Beverage),
               new CMI("bagel plain",1.85m, _Category.Food),
               new CMI("bagel whole wheat",1.85m, _Category.Food),
               new CMI("bagel raisin",1.85m, _Category.Food),
               new CMI("scone",2.25m, _Category.Food),
               new CMI("muffine",2.15m, _Category.Food),
 
            };
            foreach (CMI c in cafeitems)
            { MenuListBox.Items.Add(c);
            };
        }
    }
}


