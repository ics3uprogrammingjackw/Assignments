namespace PizzaOrderJackW
{
    partial class frmPizzaOrder
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
            this.grbSizes = new System.Windows.Forms.GroupBox();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.lblPizzas = new System.Windows.Forms.Label();
            this.grbPizzas = new System.Windows.Forms.GroupBox();
            this.radPizzas1 = new System.Windows.Forms.RadioButton();
            this.radPizzas2 = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radExtraLarge = new System.Windows.Forms.RadioButton();
            this.radToppings1 = new System.Windows.Forms.RadioButton();
            this.radToppings3 = new System.Windows.Forms.RadioButton();
            this.radToppings2 = new System.Windows.Forms.RadioButton();
            this.radToppings4 = new System.Windows.Forms.RadioButton();
            this.radToppings5 = new System.Windows.Forms.RadioButton();
            this.lblDrink = new System.Windows.Forms.Label();
            this.grbDrink = new System.Windows.Forms.GroupBox();
            this.radDrinkYes = new System.Windows.Forms.RadioButton();
            this.radDrinkNo = new System.Windows.Forms.RadioButton();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grbSizes.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.grbPizzas.SuspendLayout();
            this.grbDrink.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSizes
            // 
            this.grbSizes.Controls.Add(this.radExtraLarge);
            this.grbSizes.Controls.Add(this.radLarge);
            this.grbSizes.Controls.Add(this.radMedium);
            this.grbSizes.Location = new System.Drawing.Point(30, 92);
            this.grbSizes.Name = "grbSizes";
            this.grbSizes.Size = new System.Drawing.Size(93, 129);
            this.grbSizes.TabIndex = 0;
            this.grbSizes.TabStop = false;
            this.grbSizes.Text = "Sizes";
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.radToppings5);
            this.grbToppings.Controls.Add(this.radToppings4);
            this.grbToppings.Controls.Add(this.radToppings2);
            this.grbToppings.Controls.Add(this.radToppings3);
            this.grbToppings.Controls.Add(this.radToppings1);
            this.grbToppings.Location = new System.Drawing.Point(30, 271);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(93, 142);
            this.grbToppings.TabIndex = 1;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "Toppings";
            // 
            // lblPizzas
            // 
            this.lblPizzas.AutoSize = true;
            this.lblPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPizzas.Location = new System.Drawing.Point(231, 92);
            this.lblPizzas.Name = "lblPizzas";
            this.lblPizzas.Size = new System.Drawing.Size(212, 20);
            this.lblPizzas.TabIndex = 0;
            this.lblPizzas.Text = "Would you like 1 or 2 pizzas?";
            // 
            // grbPizzas
            // 
            this.grbPizzas.Controls.Add(this.radPizzas2);
            this.grbPizzas.Controls.Add(this.radPizzas1);
            this.grbPizzas.Location = new System.Drawing.Point(241, 132);
            this.grbPizzas.Name = "grbPizzas";
            this.grbPizzas.Size = new System.Drawing.Size(177, 52);
            this.grbPizzas.TabIndex = 2;
            this.grbPizzas.TabStop = false;
            this.grbPizzas.Text = "Pizzas";
            // 
            // radPizzas1
            // 
            this.radPizzas1.AutoSize = true;
            this.radPizzas1.Location = new System.Drawing.Point(29, 19);
            this.radPizzas1.Name = "radPizzas1";
            this.radPizzas1.Size = new System.Drawing.Size(31, 17);
            this.radPizzas1.TabIndex = 0;
            this.radPizzas1.TabStop = true;
            this.radPizzas1.Text = "1";
            this.radPizzas1.UseVisualStyleBackColor = true;
            this.radPizzas1.CheckedChanged += new System.EventHandler(this.radPizzas1_CheckedChanged);
            // 
            // radPizzas2
            // 
            this.radPizzas2.AutoSize = true;
            this.radPizzas2.Location = new System.Drawing.Point(89, 19);
            this.radPizzas2.Name = "radPizzas2";
            this.radPizzas2.Size = new System.Drawing.Size(31, 17);
            this.radPizzas2.TabIndex = 1;
            this.radPizzas2.TabStop = true;
            this.radPizzas2.Text = "2";
            this.radPizzas2.UseVisualStyleBackColor = true;
            this.radPizzas2.CheckedChanged += new System.EventHandler(this.radPizzas2_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(6, 29);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 3;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(6, 52);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 4;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radExtraLarge
            // 
            this.radExtraLarge.AutoSize = true;
            this.radExtraLarge.Location = new System.Drawing.Point(6, 75);
            this.radExtraLarge.Name = "radExtraLarge";
            this.radExtraLarge.Size = new System.Drawing.Size(79, 17);
            this.radExtraLarge.TabIndex = 5;
            this.radExtraLarge.TabStop = true;
            this.radExtraLarge.Text = "Extra Large";
            this.radExtraLarge.UseVisualStyleBackColor = true;
            this.radExtraLarge.CheckedChanged += new System.EventHandler(this.radExtraLarge_CheckedChanged);
            // 
            // radToppings1
            // 
            this.radToppings1.AutoSize = true;
            this.radToppings1.Location = new System.Drawing.Point(6, 29);
            this.radToppings1.Name = "radToppings1";
            this.radToppings1.Size = new System.Drawing.Size(31, 17);
            this.radToppings1.TabIndex = 3;
            this.radToppings1.TabStop = true;
            this.radToppings1.Text = "1";
            this.radToppings1.UseVisualStyleBackColor = true;
            this.radToppings1.CheckedChanged += new System.EventHandler(this.radToppings1_CheckedChanged);
            // 
            // radToppings3
            // 
            this.radToppings3.AutoSize = true;
            this.radToppings3.Location = new System.Drawing.Point(6, 72);
            this.radToppings3.Name = "radToppings3";
            this.radToppings3.Size = new System.Drawing.Size(31, 17);
            this.radToppings3.TabIndex = 4;
            this.radToppings3.TabStop = true;
            this.radToppings3.Text = "3";
            this.radToppings3.UseVisualStyleBackColor = true;
            this.radToppings3.CheckedChanged += new System.EventHandler(this.radToppings3_CheckedChanged);
            // 
            // radToppings2
            // 
            this.radToppings2.AutoSize = true;
            this.radToppings2.Location = new System.Drawing.Point(6, 49);
            this.radToppings2.Name = "radToppings2";
            this.radToppings2.Size = new System.Drawing.Size(31, 17);
            this.radToppings2.TabIndex = 4;
            this.radToppings2.TabStop = true;
            this.radToppings2.Text = "2";
            this.radToppings2.UseVisualStyleBackColor = true;
            this.radToppings2.CheckedChanged += new System.EventHandler(this.radToppings2_CheckedChanged);
            // 
            // radToppings4
            // 
            this.radToppings4.AutoSize = true;
            this.radToppings4.Location = new System.Drawing.Point(6, 95);
            this.radToppings4.Name = "radToppings4";
            this.radToppings4.Size = new System.Drawing.Size(31, 17);
            this.radToppings4.TabIndex = 5;
            this.radToppings4.TabStop = true;
            this.radToppings4.Text = "4";
            this.radToppings4.UseVisualStyleBackColor = true;
            this.radToppings4.CheckedChanged += new System.EventHandler(this.radToppings4_CheckedChanged);
            // 
            // radToppings5
            // 
            this.radToppings5.AutoSize = true;
            this.radToppings5.Location = new System.Drawing.Point(6, 118);
            this.radToppings5.Name = "radToppings5";
            this.radToppings5.Size = new System.Drawing.Size(31, 17);
            this.radToppings5.TabIndex = 6;
            this.radToppings5.TabStop = true;
            this.radToppings5.Text = "5";
            this.radToppings5.UseVisualStyleBackColor = true;
            this.radToppings5.CheckedChanged += new System.EventHandler(this.radToppings5_CheckedChanged);
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDrink.Location = new System.Drawing.Point(248, 201);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(170, 20);
            this.lblDrink.TabIndex = 3;
            this.lblDrink.Text = "Would you like a drink?";
            // 
            // grbDrink
            // 
            this.grbDrink.Controls.Add(this.radDrinkNo);
            this.grbDrink.Controls.Add(this.radDrinkYes);
            this.grbDrink.Location = new System.Drawing.Point(235, 248);
            this.grbDrink.Name = "grbDrink";
            this.grbDrink.Size = new System.Drawing.Size(200, 69);
            this.grbDrink.TabIndex = 4;
            this.grbDrink.TabStop = false;
            this.grbDrink.Text = "Drink";
            // 
            // radDrinkYes
            // 
            this.radDrinkYes.AutoSize = true;
            this.radDrinkYes.Location = new System.Drawing.Point(6, 29);
            this.radDrinkYes.Name = "radDrinkYes";
            this.radDrinkYes.Size = new System.Drawing.Size(43, 17);
            this.radDrinkYes.TabIndex = 5;
            this.radDrinkYes.TabStop = true;
            this.radDrinkYes.Text = "Yes";
            this.radDrinkYes.UseVisualStyleBackColor = true;
            this.radDrinkYes.CheckedChanged += new System.EventHandler(this.radDrinkYes_CheckedChanged);
            // 
            // radDrinkNo
            // 
            this.radDrinkNo.AutoSize = true;
            this.radDrinkNo.Location = new System.Drawing.Point(87, 29);
            this.radDrinkNo.Name = "radDrinkNo";
            this.radDrinkNo.Size = new System.Drawing.Size(39, 17);
            this.radDrinkNo.TabIndex = 6;
            this.radDrinkNo.TabStop = true;
            this.radDrinkNo.Text = "No";
            this.radDrinkNo.UseVisualStyleBackColor = true;
            this.radDrinkNo.CheckedChanged += new System.EventHandler(this.radDrinkNo_CheckedChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWelcome.Location = new System.Drawing.Point(231, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(229, 20);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome to Jack\'s Pizza Shop!";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOrder.Location = new System.Drawing.Point(281, 354);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(97, 40);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSubtotal.Location = new System.Drawing.Point(467, 155);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 20);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotal.Location = new System.Drawing.Point(467, 248);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 20);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 598);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.grbDrink);
            this.Controls.Add(this.lblDrink);
            this.Controls.Add(this.grbPizzas);
            this.Controls.Add(this.lblPizzas);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbSizes);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Jack W";
            this.Load += new System.EventHandler(this.frmPizzaOrder_Load);
            this.grbSizes.ResumeLayout(false);
            this.grbSizes.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.grbPizzas.ResumeLayout(false);
            this.grbPizzas.PerformLayout();
            this.grbDrink.ResumeLayout(false);
            this.grbDrink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSizes;
        private System.Windows.Forms.RadioButton radExtraLarge;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.RadioButton radToppings5;
        private System.Windows.Forms.RadioButton radToppings4;
        private System.Windows.Forms.RadioButton radToppings2;
        private System.Windows.Forms.RadioButton radToppings3;
        private System.Windows.Forms.RadioButton radToppings1;
        private System.Windows.Forms.Label lblPizzas;
        private System.Windows.Forms.GroupBox grbPizzas;
        private System.Windows.Forms.RadioButton radPizzas2;
        private System.Windows.Forms.RadioButton radPizzas1;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.GroupBox grbDrink;
        private System.Windows.Forms.RadioButton radDrinkNo;
        private System.Windows.Forms.RadioButton radDrinkYes;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

