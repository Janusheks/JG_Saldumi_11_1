namespace JG_Saldumi_11
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
            this.button1 = new System.Windows.Forms.Button();
            this.daudzums = new System.Windows.Forms.TextBox();
            this.daudzums_kg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button1.Location = new System.Drawing.Point(294, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aprekini";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // daudzums
            // 
            this.daudzums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.daudzums.Location = new System.Drawing.Point(76, 190);
            this.daudzums.Multiline = true;
            this.daudzums.Name = "daudzums";
            this.daudzums.Size = new System.Drawing.Size(164, 30);
            this.daudzums.TabIndex = 1;
            this.daudzums.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // daudzums_kg
            // 
            this.daudzums_kg.Location = new System.Drawing.Point(578, 190);
            this.daudzums_kg.Multiline = true;
            this.daudzums_kg.Name = "daudzums_kg";
            this.daudzums_kg.Size = new System.Drawing.Size(146, 30);
            this.daudzums_kg.TabIndex = 2;
            this.daudzums_kg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(29, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ievadiet cenu par kadu gribat pirkt saldumus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(498, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Daudzums, cik saldumus varat nopirkt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(153, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldumu cena uz kg = 9,88.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(642, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saldumu cenas aprekinasana!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daudzums_kg);
            this.Controls.Add(this.daudzums);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox daudzums;
        private System.Windows.Forms.TextBox daudzums_kg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

