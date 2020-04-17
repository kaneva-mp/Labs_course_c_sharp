namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.multy = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonSeven, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonEight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNine, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.plus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonFour, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonFive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSix, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonOne, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonTwo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonThree, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.multy, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.divide, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonZero, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.clear, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.equal, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 846);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonSeven
            // 
            this.buttonSeven.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSeven.BackColor = System.Drawing.Color.DimGray;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSeven.Location = new System.Drawing.Point(3, 143);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(137, 134);
            this.buttonSeven.TabIndex = 0;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // buttonEight
            // 
            this.buttonEight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEight.BackColor = System.Drawing.Color.DimGray;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEight.Location = new System.Drawing.Point(146, 143);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(137, 134);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // buttonNine
            // 
            this.buttonNine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNine.BackColor = System.Drawing.Color.DimGray;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNine.Location = new System.Drawing.Point(289, 143);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(137, 134);
            this.buttonNine.TabIndex = 2;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // plus
            // 
            this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plus.BackColor = System.Drawing.Color.DimGray;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus.Location = new System.Drawing.Point(432, 143);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(139, 134);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.tappedOperationButton);
            // 
            // buttonFour
            // 
            this.buttonFour.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFour.BackColor = System.Drawing.Color.DimGray;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFour.Location = new System.Drawing.Point(3, 283);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(137, 134);
            this.buttonFour.TabIndex = 4;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // buttonFive
            // 
            this.buttonFive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFive.BackColor = System.Drawing.Color.DimGray;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFive.Location = new System.Drawing.Point(146, 283);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(137, 134);
            this.buttonFive.TabIndex = 5;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // buttonSix
            // 
            this.buttonSix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSix.BackColor = System.Drawing.Color.DimGray;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSix.Location = new System.Drawing.Point(289, 283);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(137, 134);
            this.buttonSix.TabIndex = 6;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // minus
            // 
            this.minus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minus.BackColor = System.Drawing.Color.DimGray;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.Location = new System.Drawing.Point(432, 283);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(139, 134);
            this.minus.TabIndex = 7;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.tappedOperationButton);
            // 
            // buttonOne
            // 
            this.buttonOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOne.BackColor = System.Drawing.Color.DimGray;
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOne.Location = new System.Drawing.Point(3, 423);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(137, 134);
            this.buttonOne.TabIndex = 8;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTwo.BackColor = System.Drawing.Color.DimGray;
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTwo.Location = new System.Drawing.Point(146, 423);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(137, 134);
            this.buttonTwo.TabIndex = 9;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // buttonThree
            // 
            this.buttonThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThree.BackColor = System.Drawing.Color.DimGray;
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonThree.Location = new System.Drawing.Point(289, 423);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(137, 134);
            this.buttonThree.TabIndex = 10;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // multy
            // 
            this.multy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multy.BackColor = System.Drawing.Color.DimGray;
            this.multy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multy.Location = new System.Drawing.Point(432, 423);
            this.multy.Name = "multy";
            this.multy.Size = new System.Drawing.Size(139, 134);
            this.multy.TabIndex = 11;
            this.multy.Text = "*";
            this.multy.UseVisualStyleBackColor = false;
            this.multy.Click += new System.EventHandler(this.tappedOperationButton);
            // 
            // divide
            // 
            this.divide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divide.BackColor = System.Drawing.Color.DimGray;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divide.Location = new System.Drawing.Point(432, 563);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(139, 134);
            this.divide.TabIndex = 12;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.tappedOperationButton);
            // 
            // dot
            // 
            this.dot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dot.BackColor = System.Drawing.Color.DimGray;
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dot.Location = new System.Drawing.Point(289, 563);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(137, 134);
            this.dot.TabIndex = 13;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // buttonZero
            // 
            this.buttonZero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZero.BackColor = System.Drawing.Color.DimGray;
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonZero.Location = new System.Drawing.Point(146, 563);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(137, 134);
            this.buttonZero.TabIndex = 14;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = false;
            this.buttonZero.Click += new System.EventHandler(this.tappedNumberButton);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.BackColor = System.Drawing.Color.DimGray;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(3, 563);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(137, 134);
            this.clear.TabIndex = 15;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.tappedClearButton);
            // 
            // equal
            // 
            this.equal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equal.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.SetColumnSpan(this.equal, 4);
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.equal.Location = new System.Drawing.Point(3, 703);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(568, 140);
            this.equal.TabIndex = 16;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.tappedEqualButton);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBox, 4);
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox.Location = new System.Drawing.Point(3, 15);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(568, 109);
            this.textBox.TabIndex = 17;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(574, 846);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 1017);
            this.MinimumSize = new System.Drawing.Size(600, 917);
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button multy;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox textBox;
    }
}

