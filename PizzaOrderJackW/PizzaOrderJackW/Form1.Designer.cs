namespace PizzaOrderJackW
{
    partial class Form1
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
            this.numToppings = new System.Windows.Forms.NumericUpDown();
            this.lblToppingsQuestion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // numToppings
            // 
            this.numToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numToppings.Location = new System.Drawing.Point(399, 105);
            this.numToppings.Name = "numToppings";
            this.numToppings.Size = new System.Drawing.Size(120, 26);
            this.numToppings.TabIndex = 0;
            // 
            // lblToppingsQuestion
            // 
            this.lblToppingsQuestion.AutoSize = true;
            this.lblToppingsQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblToppingsQuestion.Location = new System.Drawing.Point(126, 107);
            this.lblToppingsQuestion.Name = "lblToppingsQuestion";
            this.lblToppingsQuestion.Size = new System.Drawing.Size(258, 20);
            this.lblToppingsQuestion.TabIndex = 1;
            this.lblToppingsQuestion.Text = "How many toppings would you like?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToppingsQuestion);
            this.Controls.Add(this.numToppings);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numToppings;
        private System.Windows.Forms.Label lblToppingsQuestion;
    }
}

