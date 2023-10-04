namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputBox = new TextBox();
            clearBtn = new Button();
            clearABtn = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            equal = new Button();
            button17 = new Button();
            button18 = new Button();
            equation = new Label();
            SuspendLayout();
            // 
            // inputBox
            // 
            inputBox.Location = new Point(36, 37);
            inputBox.Multiline = true;
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(240, 35);
            inputBox.TabIndex = 0;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(36, 89);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(76, 29);
            clearBtn.TabIndex = 1;
            clearBtn.Text = "clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // clearABtn
            // 
            clearABtn.Location = new Point(122, 89);
            clearABtn.Name = "clearABtn";
            clearABtn.Size = new Size(76, 29);
            clearABtn.TabIndex = 2;
            clearABtn.Text = "clear all";
            clearABtn.UseVisualStyleBackColor = true;
            clearABtn.Click += clearABtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(36, 138);
            button3.Name = "button3";
            button3.Size = new Size(49, 35);
            button3.TabIndex = 3;
            button3.Text = "7";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_click;
            // 
            // button4
            // 
            button4.Location = new Point(100, 138);
            button4.Name = "button4";
            button4.Size = new Size(49, 35);
            button4.TabIndex = 4;
            button4.Text = "8";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_click;
            // 
            // button5
            // 
            button5.Location = new Point(227, 138);
            button5.Name = "button5";
            button5.Size = new Size(49, 35);
            button5.TabIndex = 6;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            button5.Click += operator_click;
            // 
            // button6
            // 
            button6.Location = new Point(163, 138);
            button6.Name = "button6";
            button6.Size = new Size(49, 35);
            button6.TabIndex = 5;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_click;
            // 
            // button7
            // 
            button7.Location = new Point(227, 188);
            button7.Name = "button7";
            button7.Size = new Size(49, 35);
            button7.TabIndex = 10;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += operator_click;
            // 
            // button8
            // 
            button8.Location = new Point(163, 188);
            button8.Name = "button8";
            button8.Size = new Size(49, 35);
            button8.TabIndex = 9;
            button8.Text = "6";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_click;
            // 
            // button9
            // 
            button9.Location = new Point(100, 188);
            button9.Name = "button9";
            button9.Size = new Size(49, 35);
            button9.TabIndex = 8;
            button9.Text = "5";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_click;
            // 
            // button10
            // 
            button10.Location = new Point(36, 188);
            button10.Name = "button10";
            button10.Size = new Size(49, 35);
            button10.TabIndex = 7;
            button10.Text = "4";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_click;
            // 
            // button11
            // 
            button11.Location = new Point(227, 238);
            button11.Name = "button11";
            button11.Size = new Size(49, 35);
            button11.TabIndex = 14;
            button11.Text = "*";
            button11.UseVisualStyleBackColor = true;
            button11.Click += operator_click;
            // 
            // button12
            // 
            button12.Location = new Point(163, 238);
            button12.Name = "button12";
            button12.Size = new Size(49, 35);
            button12.TabIndex = 13;
            button12.Text = "3";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_click;
            // 
            // button13
            // 
            button13.Location = new Point(100, 238);
            button13.Name = "button13";
            button13.Size = new Size(49, 35);
            button13.TabIndex = 12;
            button13.Text = "2";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_click;
            // 
            // button14
            // 
            button14.Location = new Point(36, 238);
            button14.Name = "button14";
            button14.Size = new Size(49, 35);
            button14.TabIndex = 11;
            button14.Text = "1";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button_click;
            // 
            // button15
            // 
            button15.Location = new Point(227, 293);
            button15.Name = "button15";
            button15.Size = new Size(49, 35);
            button15.TabIndex = 18;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = true;
            button15.Click += operator_click;
            // 
            // equal
            // 
            equal.Location = new Point(163, 293);
            equal.Name = "equal";
            equal.Size = new Size(49, 35);
            equal.TabIndex = 17;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += equal_Click;
            // 
            // button17
            // 
            button17.Location = new Point(100, 293);
            button17.Name = "button17";
            button17.Size = new Size(49, 35);
            button17.TabIndex = 16;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button_click;
            // 
            // button18
            // 
            button18.Location = new Point(36, 293);
            button18.Name = "button18";
            button18.Size = new Size(49, 35);
            button18.TabIndex = 15;
            button18.Text = "0";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_click;
            // 
            // equation
            // 
            equation.AutoSize = true;
            equation.Location = new Point(37, 9);
            equation.Name = "equation";
            equation.Size = new Size(0, 15);
            equation.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 361);
            Controls.Add(equation);
            Controls.Add(button15);
            Controls.Add(equal);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(clearABtn);
            Controls.Add(clearBtn);
            Controls.Add(inputBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputBox;
        private Button clearBtn;
        private Button clearABtn;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button equal;
        private Button button17;
        private Button button18;
        private Label equation;
    }
}