namespace FallingObjectsJackW
{
    partial class frmFallingObjects
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
            this.lblStatement1 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblStatement2 = new System.Windows.Forms.Label();
            this.lblStatement3 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radGravEarth = new System.Windows.Forms.RadioButton();
            this.radGravMars = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatement1
            // 
            this.lblStatement1.AutoSize = true;
            this.lblStatement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStatement1.Location = new System.Drawing.Point(35, 181);
            this.lblStatement1.Name = "lblStatement1";
            this.lblStatement1.Size = new System.Drawing.Size(396, 24);
            this.lblStatement1.TabIndex = 0;
            this.lblStatement1.Text = "A person drops an object off a 100 m cliff. After";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(448, 186);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.TextChanged += new System.EventHandler(this.txtAnswer_TextChanged);
            // 
            // lblStatement2
            // 
            this.lblStatement2.AutoSize = true;
            this.lblStatement2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStatement2.Location = new System.Drawing.Point(554, 181);
            this.lblStatement2.Name = "lblStatement2";
            this.lblStatement2.Size = new System.Drawing.Size(197, 24);
            this.lblStatement2.TabIndex = 2;
            this.lblStatement2.Text = "seconds the object is: ";
            this.lblStatement2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStatement3
            // 
            this.lblStatement3.AutoSize = true;
            this.lblStatement3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStatement3.Location = new System.Drawing.Point(327, 336);
            this.lblStatement3.Name = "lblStatement3";
            this.lblStatement3.Size = new System.Drawing.Size(221, 24);
            this.lblStatement3.TabIndex = 3;
            this.lblStatement3.Text = "meters above the ground";
            this.lblStatement3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAnswer.Location = new System.Drawing.Point(442, 266);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGravMars);
            this.groupBox1.Controls.Add(this.radGravEarth);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gravity Options";
            // 
            // radGravEarth
            // 
            this.radGravEarth.AutoSize = true;
            this.radGravEarth.Location = new System.Drawing.Point(27, 46);
            this.radGravEarth.Name = "radGravEarth";
            this.radGravEarth.Size = new System.Drawing.Size(50, 17);
            this.radGravEarth.TabIndex = 6;
            this.radGravEarth.TabStop = true;
            this.radGravEarth.Text = "Earth";
            this.radGravEarth.UseVisualStyleBackColor = true;
            this.radGravEarth.CheckedChanged += new System.EventHandler(this.radGravEarth_CheckedChanged);
            // 
            // radGravMars
            // 
            this.radGravMars.AutoSize = true;
            this.radGravMars.Location = new System.Drawing.Point(27, 98);
            this.radGravMars.Name = "radGravMars";
            this.radGravMars.Size = new System.Drawing.Size(48, 17);
            this.radGravMars.TabIndex = 7;
            this.radGravMars.TabStop = true;
            this.radGravMars.Text = "Mars";
            this.radGravMars.UseVisualStyleBackColor = true;
            this.radGravMars.CheckedChanged += new System.EventHandler(this.radGravMars_CheckedChanged);
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblStatement3);
            this.Controls.Add(this.lblStatement2);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblStatement1);
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects by Jack W";
            this.Load += new System.EventHandler(this.frmFallingObjects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatement1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblStatement2;
        private System.Windows.Forms.Label lblStatement3;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radGravMars;
        private System.Windows.Forms.RadioButton radGravEarth;
    }
}

