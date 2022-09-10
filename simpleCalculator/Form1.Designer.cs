namespace calcu
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
            this.clearButton = new System.Windows.Forms.Button();
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.substractionButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.calculatorShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.clearButton.Location = new System.Drawing.Point(13, 124);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(272, 58);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorDisplay.ForeColor = System.Drawing.Color.White;
            this.calculatorDisplay.Location = new System.Drawing.Point(13, 46);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(364, 68);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.twoButton.Location = new System.Drawing.Point(104, 304);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(90, 58);
            this.twoButton.TabIndex = 8;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(13, 304);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(90, 58);
            this.oneButton.TabIndex = 10;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.fiveButton.Location = new System.Drawing.Point(104, 244);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(90, 58);
            this.fiveButton.TabIndex = 11;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.fourButton.Location = new System.Drawing.Point(13, 244);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(90, 58);
            this.fourButton.TabIndex = 12;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.threeButton.Location = new System.Drawing.Point(195, 304);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(90, 58);
            this.threeButton.TabIndex = 13;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nineButton.Location = new System.Drawing.Point(195, 184);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(90, 58);
            this.nineButton.TabIndex = 14;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.eightButton.Location = new System.Drawing.Point(104, 184);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(90, 58);
            this.eightButton.TabIndex = 15;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sevenButton.Location = new System.Drawing.Point(13, 184);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(90, 58);
            this.sevenButton.TabIndex = 16;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sixButton.Location = new System.Drawing.Point(195, 244);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(90, 58);
            this.sixButton.TabIndex = 17;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.multiplyButton.Location = new System.Drawing.Point(287, 184);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(90, 58);
            this.multiplyButton.TabIndex = 18;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.divideButton.Location = new System.Drawing.Point(287, 124);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(90, 58);
            this.divideButton.TabIndex = 19;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dotButton.Location = new System.Drawing.Point(104, 364);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(90, 58);
            this.dotButton.TabIndex = 21;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.zeroButton.Location = new System.Drawing.Point(13, 364);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(90, 58);
            this.zeroButton.TabIndex = 22;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // substractionButton
            // 
            this.substractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.substractionButton.Location = new System.Drawing.Point(287, 244);
            this.substractionButton.Name = "substractionButton";
            this.substractionButton.Size = new System.Drawing.Size(90, 58);
            this.substractionButton.TabIndex = 24;
            this.substractionButton.Text = "-";
            this.substractionButton.UseVisualStyleBackColor = true;
            this.substractionButton.Click += new System.EventHandler(this.substractionButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.resultButton.Location = new System.Drawing.Point(195, 364);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(182, 58);
            this.resultButton.TabIndex = 25;
            this.resultButton.Text = "=";
            this.resultButton.UseVisualStyleBackColor = false;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.addButton.Location = new System.Drawing.Point(287, 304);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(90, 58);
            this.addButton.TabIndex = 26;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // calculatorShow
            // 
            this.calculatorShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(18)))), ((int)(((byte)(36)))));
            this.calculatorShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.calculatorShow.Location = new System.Drawing.Point(13, 17);
            this.calculatorShow.Name = "calculatorShow";
            this.calculatorShow.Size = new System.Drawing.Size(364, 29);
            this.calculatorShow.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 437);
            this.Controls.Add(this.calculatorShow);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultButton);
            this.Controls.Add(this.substractionButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.clearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button substractionButton;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label calculatorShow;
    }
}

