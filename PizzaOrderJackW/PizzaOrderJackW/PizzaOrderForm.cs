/*
 * Created by: Jack Wright
 * Created on: 23-March-2019
 * Created for: ICS3U Programming
 * Assignment #5b - Pizza Order
 * This program emulates a pizza store where you can choose toppings, size, amount of pizzas etc.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderJackW
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        // Declaring constants
        const double ONE_TOPPING = 0.75;
        const double TWO_TOPPINGS = 1.35;
        const double THREE_TOPPINGS = 2.15;
        const double FOUR_TOPPINGS = 2.75;
        const double FIVE_TOPPINGS = 3.55;
        const double SIZE_MEDIUM = 6.99;
        const double SIZE_LARGE = 9.99;
        const double SIZE_XL = 12.99;
        const double ONE_PIZZA = 1;
        const double TWO_PIZZAS = 2;
        const double DRINK = 3.00;
        const double NO_DRINK = 0;
        const double HST = 1.13;

        // Declaring variables
        double sizePrice;
        double toppingsPrice;
        double drinkPrice;
        double amountOfPizzas;
        double subtotal;
        double total;

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {

        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of the size of pizza
            sizePrice = SIZE_MEDIUM;
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of the size of pizza
            sizePrice = SIZE_LARGE;
        }

        private void radExtraLarge_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of the size of pizza
            sizePrice = SIZE_XL;
        }

        private void radPizzas1_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the amount of pizzas
            amountOfPizzas = ONE_PIZZA;
        }

        private void radPizzas2_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the amount of pizzas
            amountOfPizzas = TWO_PIZZAS;
        }

        private void radToppings1_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of toppings
            toppingsPrice = ONE_TOPPING;
        }

        private void radToppings2_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of toppings
            toppingsPrice = TWO_TOPPINGS;
        }

        private void radToppings3_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of toppings
            toppingsPrice = THREE_TOPPINGS;
        }

        private void radToppings4_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of toppings
            toppingsPrice = FOUR_TOPPINGS;
        }

        private void radToppings5_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of toppings
            toppingsPrice = FIVE_TOPPINGS;
        }

        private void radDrinkYes_CheckedChanged(object sender, EventArgs e)
        {
            //Sets the price of the drink
            drinkPrice = DRINK;
        }

        private void radDrinkNo_CheckedChanged(object sender, EventArgs e)
        {
            //sets the price of the drink to 0 because the user does not want one
            drinkPrice = NO_DRINK;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //Calculates the subtotal
            subtotal = Math.Round (100 *(sizePrice + toppingsPrice + drinkPrice) * amountOfPizzas)/100;

            //Calculates the total
            total = Math.Round (100 *(subtotal * HST))/100;

            //Displays the subtotal
            lblSubtotal.Text = String.Format("Subtotal: ${0:0.00}", subtotal);

            //Displays the total
            lblTotal.Text = String.Format("Subtotal: ${0:0.00}", total);

        }
    }
}
