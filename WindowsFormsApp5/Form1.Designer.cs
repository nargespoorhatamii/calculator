
namespace WindowsFormsApp5
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
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_mines = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_res
            // 
            this.lbl_res.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_res.Location = new System.Drawing.Point(536, 303);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(207, 106);
            this.lbl_res.TabIndex = 1;
            this.lbl_res.Text = "Result";
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(540, 125);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(76, 50);
            this.btn_mul.TabIndex = 2;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mines
            // 
            this.btn_mines.Location = new System.Drawing.Point(681, 200);
            this.btn_mines.Name = "btn_mines";
            this.btn_mines.Size = new System.Drawing.Size(76, 50);
            this.btn_mines.TabIndex = 3;
            this.btn_mines.Text = "-";
            this.btn_mines.UseVisualStyleBackColor = true;
            this.btn_mines.Click += new System.EventHandler(this.btn_mines_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(540, 200);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(76, 50);
            this.btn_sum.TabIndex = 4;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Location = new System.Drawing.Point(681, 127);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(76, 50);
            this.btn_divide.TabIndex = 5;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(109, 88);
            this.txt_num1.Multiline = true;
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(137, 37);
            this.txt_num1.TabIndex = 6;
            this.txt_num1.TextChanged += new System.EventHandler(this.txt_num1_TextChanged);
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(109, 213);
            this.txt_num2.Multiline = true;
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(137, 37);
            this.txt_num2.TabIndex = 7;
            this.txt_num2.TextChanged += new System.EventHandler(this.txt_num2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(105, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(105, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number 1:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(187, 325);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(76, 50);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(41, 325);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(76, 50);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_mines);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.lbl_res);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_mines;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_clear;
    }
}

