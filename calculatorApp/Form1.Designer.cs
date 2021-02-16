namespace calculatorApp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.resultsTxt = new System.Windows.Forms.TextBox();
			this.clearBtn = new System.Windows.Forms.Button();
			this.sqlRootBtn = new System.Windows.Forms.Button();
			this.raisePowerBtn = new System.Windows.Forms.Button();
			this.sevenBtn = new System.Windows.Forms.Button();
			this.eightBtn = new System.Windows.Forms.Button();
			this.nineBtn = new System.Windows.Forms.Button();
			this.divideBtn = new System.Windows.Forms.Button();
			this.fourBtn = new System.Windows.Forms.Button();
			this.fiveBtn = new System.Windows.Forms.Button();
			this.multBtn = new System.Windows.Forms.Button();
			this.sixBtn = new System.Windows.Forms.Button();
			this.func1Btn = new System.Windows.Forms.Button();
			this.subtractBtn = new System.Windows.Forms.Button();
			this.threeBtn = new System.Windows.Forms.Button();
			this.twoBtn = new System.Windows.Forms.Button();
			this.oneBtn = new System.Windows.Forms.Button();
			this.plusBtn = new System.Windows.Forms.Button();
			this.decimalBtn = new System.Windows.Forms.Button();
			this.zeroBtn = new System.Windows.Forms.Button();
			this.EqualsBtn = new System.Windows.Forms.Button();
			this.func2Btn = new System.Windows.Forms.Button();
			this.equationPrint = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// resultsTxt
			// 
			this.resultsTxt.BackColor = System.Drawing.SystemColors.MenuBar;
			this.resultsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultsTxt.Location = new System.Drawing.Point(7, 61);
			this.resultsTxt.Multiline = true;
			this.resultsTxt.Name = "resultsTxt";
			this.resultsTxt.Size = new System.Drawing.Size(754, 40);
			this.resultsTxt.TabIndex = 0;
			this.resultsTxt.Text = "0";
			this.resultsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// clearBtn
			// 
			this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearBtn.Location = new System.Drawing.Point(7, 107);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(146, 93);
			this.clearBtn.TabIndex = 1;
			this.clearBtn.Text = "C";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// sqlRootBtn
			// 
			this.sqlRootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sqlRootBtn.Location = new System.Drawing.Point(159, 107);
			this.sqlRootBtn.Name = "sqlRootBtn";
			this.sqlRootBtn.Size = new System.Drawing.Size(146, 93);
			this.sqlRootBtn.TabIndex = 2;
			this.sqlRootBtn.Text = "SQR Root";
			this.sqlRootBtn.UseVisualStyleBackColor = true;
			this.sqlRootBtn.Click += new System.EventHandler(this.sqlRootBtn_Click);
			// 
			// raisePowerBtn
			// 
			this.raisePowerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.raisePowerBtn.Location = new System.Drawing.Point(311, 107);
			this.raisePowerBtn.Name = "raisePowerBtn";
			this.raisePowerBtn.Size = new System.Drawing.Size(146, 93);
			this.raisePowerBtn.TabIndex = 3;
			this.raisePowerBtn.Text = "Raise Power";
			this.raisePowerBtn.UseVisualStyleBackColor = true;
			this.raisePowerBtn.Click += new System.EventHandler(this.raisePowerBtn_Click);
			// 
			// sevenBtn
			// 
			this.sevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sevenBtn.Location = new System.Drawing.Point(12, 206);
			this.sevenBtn.Name = "sevenBtn";
			this.sevenBtn.Size = new System.Drawing.Size(141, 93);
			this.sevenBtn.TabIndex = 4;
			this.sevenBtn.Text = "7";
			this.sevenBtn.UseVisualStyleBackColor = true;
			this.sevenBtn.Click += new System.EventHandler(this.Seven_Click);
			// 
			// eightBtn
			// 
			this.eightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eightBtn.Location = new System.Drawing.Point(159, 206);
			this.eightBtn.Name = "eightBtn";
			this.eightBtn.Size = new System.Drawing.Size(146, 93);
			this.eightBtn.TabIndex = 5;
			this.eightBtn.Text = "8";
			this.eightBtn.UseVisualStyleBackColor = true;
			this.eightBtn.Click += new System.EventHandler(this.Eight_Click);
			// 
			// nineBtn
			// 
			this.nineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nineBtn.Location = new System.Drawing.Point(311, 206);
			this.nineBtn.Name = "nineBtn";
			this.nineBtn.Size = new System.Drawing.Size(146, 93);
			this.nineBtn.TabIndex = 6;
			this.nineBtn.Text = "9";
			this.nineBtn.UseVisualStyleBackColor = true;
			this.nineBtn.Click += new System.EventHandler(this.Nine_Click);
			// 
			// divideBtn
			// 
			this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.divideBtn.Location = new System.Drawing.Point(463, 206);
			this.divideBtn.Name = "divideBtn";
			this.divideBtn.Size = new System.Drawing.Size(146, 93);
			this.divideBtn.TabIndex = 7;
			this.divideBtn.Text = "/";
			this.divideBtn.UseVisualStyleBackColor = true;
			this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
			// 
			// fourBtn
			// 
			this.fourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fourBtn.Location = new System.Drawing.Point(12, 305);
			this.fourBtn.Name = "fourBtn";
			this.fourBtn.Size = new System.Drawing.Size(141, 93);
			this.fourBtn.TabIndex = 8;
			this.fourBtn.Text = "4";
			this.fourBtn.UseVisualStyleBackColor = true;
			this.fourBtn.Click += new System.EventHandler(this.Four_Click);
			// 
			// fiveBtn
			// 
			this.fiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fiveBtn.Location = new System.Drawing.Point(159, 305);
			this.fiveBtn.Name = "fiveBtn";
			this.fiveBtn.Size = new System.Drawing.Size(146, 93);
			this.fiveBtn.TabIndex = 9;
			this.fiveBtn.Text = "5";
			this.fiveBtn.UseVisualStyleBackColor = true;
			this.fiveBtn.Click += new System.EventHandler(this.Five_Click);
			// 
			// multBtn
			// 
			this.multBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.multBtn.Location = new System.Drawing.Point(463, 305);
			this.multBtn.Name = "multBtn";
			this.multBtn.Size = new System.Drawing.Size(146, 93);
			this.multBtn.TabIndex = 11;
			this.multBtn.Text = "*";
			this.multBtn.UseVisualStyleBackColor = true;
			this.multBtn.Click += new System.EventHandler(this.multBtn_Click);
			// 
			// sixBtn
			// 
			this.sixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sixBtn.Location = new System.Drawing.Point(311, 305);
			this.sixBtn.Name = "sixBtn";
			this.sixBtn.Size = new System.Drawing.Size(146, 93);
			this.sixBtn.TabIndex = 10;
			this.sixBtn.Text = "6";
			this.sixBtn.UseVisualStyleBackColor = true;
			this.sixBtn.Click += new System.EventHandler(this.Six_Click);
			// 
			// func1Btn
			// 
			this.func1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.func1Btn.Location = new System.Drawing.Point(463, 107);
			this.func1Btn.Name = "func1Btn";
			this.func1Btn.Size = new System.Drawing.Size(146, 93);
			this.func1Btn.TabIndex = 12;
			this.func1Btn.Text = "Future Func 1";
			this.func1Btn.UseVisualStyleBackColor = true;
			this.func1Btn.Click += new System.EventHandler(this.func1Btn_Click);
			// 
			// subtractBtn
			// 
			this.subtractBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.subtractBtn.Location = new System.Drawing.Point(463, 404);
			this.subtractBtn.Name = "subtractBtn";
			this.subtractBtn.Size = new System.Drawing.Size(146, 93);
			this.subtractBtn.TabIndex = 17;
			this.subtractBtn.Text = "-";
			this.subtractBtn.UseVisualStyleBackColor = true;
			this.subtractBtn.Click += new System.EventHandler(this.subtractBtn_Click);
			// 
			// threeBtn
			// 
			this.threeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.threeBtn.Location = new System.Drawing.Point(311, 404);
			this.threeBtn.Name = "threeBtn";
			this.threeBtn.Size = new System.Drawing.Size(146, 93);
			this.threeBtn.TabIndex = 16;
			this.threeBtn.Text = "3";
			this.threeBtn.UseVisualStyleBackColor = true;
			this.threeBtn.Click += new System.EventHandler(this.Three_Click);
			// 
			// twoBtn
			// 
			this.twoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.twoBtn.Location = new System.Drawing.Point(159, 404);
			this.twoBtn.Name = "twoBtn";
			this.twoBtn.Size = new System.Drawing.Size(146, 93);
			this.twoBtn.TabIndex = 15;
			this.twoBtn.Text = "2";
			this.twoBtn.UseVisualStyleBackColor = true;
			this.twoBtn.Click += new System.EventHandler(this.Two_Click);
			// 
			// oneBtn
			// 
			this.oneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.oneBtn.Location = new System.Drawing.Point(12, 404);
			this.oneBtn.Name = "oneBtn";
			this.oneBtn.Size = new System.Drawing.Size(141, 93);
			this.oneBtn.TabIndex = 14;
			this.oneBtn.Text = "1";
			this.oneBtn.UseVisualStyleBackColor = true;
			this.oneBtn.Click += new System.EventHandler(this.One_Click);
			// 
			// plusBtn
			// 
			this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plusBtn.Location = new System.Drawing.Point(463, 503);
			this.plusBtn.Name = "plusBtn";
			this.plusBtn.Size = new System.Drawing.Size(146, 93);
			this.plusBtn.TabIndex = 20;
			this.plusBtn.Text = "+";
			this.plusBtn.UseVisualStyleBackColor = true;
			this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
			// 
			// decimalBtn
			// 
			this.decimalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decimalBtn.Location = new System.Drawing.Point(311, 503);
			this.decimalBtn.Name = "decimalBtn";
			this.decimalBtn.Size = new System.Drawing.Size(146, 93);
			this.decimalBtn.TabIndex = 19;
			this.decimalBtn.Text = ".";
			this.decimalBtn.UseVisualStyleBackColor = true;
			this.decimalBtn.Click += new System.EventHandler(this.decimal_Btn);
			// 
			// zeroBtn
			// 
			this.zeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zeroBtn.Location = new System.Drawing.Point(12, 503);
			this.zeroBtn.Name = "zeroBtn";
			this.zeroBtn.Size = new System.Drawing.Size(293, 93);
			this.zeroBtn.TabIndex = 18;
			this.zeroBtn.Text = "0";
			this.zeroBtn.UseVisualStyleBackColor = true;
			this.zeroBtn.Click += new System.EventHandler(this.Zero_Click);
			// 
			// EqualsBtn
			// 
			this.EqualsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EqualsBtn.Location = new System.Drawing.Point(615, 206);
			this.EqualsBtn.Name = "EqualsBtn";
			this.EqualsBtn.Size = new System.Drawing.Size(146, 390);
			this.EqualsBtn.TabIndex = 21;
			this.EqualsBtn.Text = "=";
			this.EqualsBtn.UseVisualStyleBackColor = true;
			this.EqualsBtn.Click += new System.EventHandler(this.EqualsBtn_Click);
			// 
			// func2Btn
			// 
			this.func2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.func2Btn.Location = new System.Drawing.Point(615, 107);
			this.func2Btn.Name = "func2Btn";
			this.func2Btn.Size = new System.Drawing.Size(146, 93);
			this.func2Btn.TabIndex = 22;
			this.func2Btn.Text = "Future Func 2";
			this.func2Btn.UseVisualStyleBackColor = true;
			this.func2Btn.Click += new System.EventHandler(this.func2Btn_Click);
			// 
			// equationPrint
			// 
			this.equationPrint.BackColor = System.Drawing.SystemColors.Control;
			this.equationPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equationPrint.Location = new System.Drawing.Point(7, 22);
			this.equationPrint.Multiline = true;
			this.equationPrint.Name = "equationPrint";
			this.equationPrint.Size = new System.Drawing.Size(754, 33);
			this.equationPrint.TabIndex = 23;
			this.equationPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(773, 605);
			this.Controls.Add(this.equationPrint);
			this.Controls.Add(this.func2Btn);
			this.Controls.Add(this.EqualsBtn);
			this.Controls.Add(this.plusBtn);
			this.Controls.Add(this.decimalBtn);
			this.Controls.Add(this.zeroBtn);
			this.Controls.Add(this.subtractBtn);
			this.Controls.Add(this.threeBtn);
			this.Controls.Add(this.twoBtn);
			this.Controls.Add(this.oneBtn);
			this.Controls.Add(this.func1Btn);
			this.Controls.Add(this.multBtn);
			this.Controls.Add(this.sixBtn);
			this.Controls.Add(this.fiveBtn);
			this.Controls.Add(this.fourBtn);
			this.Controls.Add(this.divideBtn);
			this.Controls.Add(this.nineBtn);
			this.Controls.Add(this.eightBtn);
			this.Controls.Add(this.sevenBtn);
			this.Controls.Add(this.raisePowerBtn);
			this.Controls.Add(this.sqlRootBtn);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.resultsTxt);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gonzalez - Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox resultsTxt;
		private System.Windows.Forms.Button clearBtn;
		private System.Windows.Forms.Button sqlRootBtn;
		private System.Windows.Forms.Button raisePowerBtn;
		private System.Windows.Forms.Button sevenBtn;
		private System.Windows.Forms.Button eightBtn;
		private System.Windows.Forms.Button nineBtn;
		private System.Windows.Forms.Button divideBtn;
		private System.Windows.Forms.Button fourBtn;
		private System.Windows.Forms.Button fiveBtn;
		private System.Windows.Forms.Button multBtn;
		private System.Windows.Forms.Button sixBtn;
		private System.Windows.Forms.Button func1Btn;
		private System.Windows.Forms.Button subtractBtn;
		private System.Windows.Forms.Button threeBtn;
		private System.Windows.Forms.Button twoBtn;
		private System.Windows.Forms.Button oneBtn;
		private System.Windows.Forms.Button plusBtn;
		private System.Windows.Forms.Button decimalBtn;
		private System.Windows.Forms.Button zeroBtn;
		private System.Windows.Forms.Button EqualsBtn;
		private System.Windows.Forms.Button func2Btn;
		private System.Windows.Forms.TextBox equationPrint;
	}
}

