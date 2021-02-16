//Mary Gonzalez
//Calculator that can add, subtract, divide, multiply, square root, and raise power of any two numbers
//Date Created: 2/6/2020


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
	public partial class Form1 : Form
	{
		//Temporary hold of numbers
		string input = string.Empty;

		//First number clicked
		string operand1 = string.Empty;
		//Second number clicked
		string operand2 = string.Empty;

		//Variable to check operation (+,-,/,*)
		string operation;

		//Holds parsed numbers
		double n1, n2;

		//Variable to check func1 or func2 btn
		string function;	



		public Form1()
		{
			InitializeComponent();
			resultsTxt.SelectionStart = 0;
		}

		
		//Method to determine what math logic to perform
		private void DoCalculate()
		{

			try
			{
				//Parse numbers clicked to doubles			
				double.TryParse(operand1, out n1);
				double.TryParse(operand2, out n2);
			}
			catch (Exception ex)
			{

				MessageBox.Show("HI");
			}

			double sum;
						
			switch (operation)
				{
					//Operation is addition
					case "+":
						//Call Addition method						
						sum = this.AddValues(n1, n2);

						//Convert sum to string and print to results textbox
						resultsTxt.Text = sum.ToString();
						break;

					//Operation is subtraction
					case "-":
						//Call subtraction method
						sum = this.SubtractValues(n1, n2);

						//Convert sum to string and print to results textbox
						resultsTxt.Text = sum.ToString();
						break;

					//Operation is division
					case "/":
						//Call division method
						sum = this.DivideValues(n1, n2);

						//Convert sum to string and print to results textbox
						resultsTxt.Text = sum.ToString();
						break;

					//Operation is multiplication
					case "*":
						//Call multiplication method
						sum = this.MultiplyValues(n1, n2);

						//Convert sum to string and print to results textbox
						resultsTxt.Text = sum.ToString();
						break;

					//Operation is square root
					case "\u221A":
						//Call square root method
						sum = this.SquareRootValues(n1, n2);

						//Convert sum to string and print to results textbox
						resultsTxt.Text = sum.ToString();
						break;

					//Operation is raise power
					case "^":
						//Call raise power method
						sum = this.RaisePowerValues(n1, n2);

						//Convert sum to string and print to results textbox
						resultsTxt.Text = sum.ToString();
						break;
						
			}
			

		}

		private void EqualsBtn_Click(object sender, EventArgs e)
		{ //try
			
			//Move second input number to operand2
			operand2 = input;


			//If operation is square root
			if (operation == "\u221A")
			{
				equationPrint.Text = (operation + operand1);
			}
			//Operation is anything else
			else
			{
				//Print operand1, operation, and operand2 to equation box
				equationPrint.Text = (operand1 + operation + operand2);
			}


			//Checking for two numbers
			//If operation is not square root
				if (operation != "\u221A")
				{
					//Check that operand2 has a value, if not show message box
					if (operand2 == string.Empty)
					{
						MessageBox.Show("You must enter two numbers to perform your calculation. Please try again.", "Gonzalez - Calculator", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					}
					//If value is present, call method
					else
					{
						try
						{
							DoCalculate();
						}
						catch (Exception ex)
						{

							MessageBox.Show(ex.Message);
						}
				}
				}
				//If operation is square root, call method
				else
				{
				//Call doCalculate method
					try
					{
						DoCalculate();
					}
					catch (Exception ex)
					{

						MessageBox.Show(ex.Message);
					}
				}
					   
		}
				

		private void FutureFeatureNotAvailable()
		{
			switch (function)
			{
				//If future function 1 button is clicked
				case "1":
					MessageBox.Show("Future Function 1 is not Available for this version", "Gonzalez - Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;

				//If future function 2 button is clicked
				case "2":
					MessageBox.Show("Future Function 2 is not Available for this version", "Gonzalez - Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
			}
			
		}



		/***********MATH METHODS**************/
		
		//Addition Method
	    private double AddValues(double x, double y)
		{			
			return x + y;
		}

		//Division Method
		private double DivideValues(double x, double y)
		{
			return x / y;
		}

		//Subtraction Method
		private double SubtractValues(double x, double y)
		{
			return x - y;
		}

		//Multiply Method
		private double MultiplyValues(double x, double y)
		{
			return x * y;
		}

		//Square Root Method
		private double SquareRootValues(double x, double y)
		{
			return  (Math.Sqrt(x));
		}

		//Raise Power Method
		private double RaisePowerValues(double x, double y)
		{
			return (Math.Pow(x, y));
		}

		//Clears fields
		private void ClearForm()
		{
			//Reset results box to 0
			resultsTxt.Text = "0";

			//Clear equation box
			equationPrint.Clear();

			//empty input, operand1 & operand2 strings
			this.input = string.Empty;
			this.operand1 = string.Empty;
			this.operand2 = string.Empty;

			operation = "";

		}
		


		/*************BUTTONS**********/

		//Clear Button
		private void clearBtn_Click(object sender, EventArgs e)
		{		
			//Calls clear function
			this.ClearForm();
		}

		//Addition Button Click
		private void plusBtn_Click(object sender, EventArgs e)
		{
				//Move first clicked number from input to operand1
				operand1 = input;

				// Set operation to +
				operation = "+";

				//Clear input variable
				input = string.Empty;

				//Print equation to display expression box
				equationPrint.Text = (operand1 + "+");
			
			
				//MessageBox.Show("No data has been entered to perform calculation. Please try again.");
			
			
		}

		//Subtraction Button Click
		private void subtractBtn_Click(object sender, EventArgs e)
		{
			//Move first clicked number from input to operand1
			operand1 = input;

			// Set operation to -
			operation = "-";

			//Clear input variable
			input = string.Empty;

			//Print equation to display expression box
			equationPrint.Text = (operand1 + "-");
		}

		//Multiplication Button Click
		private void multBtn_Click(object sender, EventArgs e)
		{
			//Move first clicked number from input to operand1
			operand1 = input;

			// Set operation to *
			operation = "*";

			//Clear input variable
			input = string.Empty;

			//Print equation to display expression box
			equationPrint.Text = (operand1 + "*");
		}

		//Division Button Click
		private void divideBtn_Click(object sender, EventArgs e)
		{
			//Move first clicked number from input to operand1
			operand1 = input;

			// Set operation to /
			operation = "/";

			//Clear input variable
			input = string.Empty;

			//Print equation to display expression box
			equationPrint.Text = (operand1 + "/");
		}

		//Square Root Button Click
		private void sqlRootBtn_Click(object sender, EventArgs e)
		{
			//Move first clicked number from input to operand1
			operand1 = input;

			// Set operation to sqr
			operation = "\u221A";

			//Print equation to display expression box
			equationPrint.Text = ("\u221A" + operand1);

			//Clear input variable
			input = string.Empty;

		}

		//Raise Power Button Click
		private void raisePowerBtn_Click(object sender, EventArgs e)
		{
			//Move first clicked number from input to operand1
			operand1 = input;

			// Set operation to ^
			operation = "^";

			//Clear input variable
			input = string.Empty;

			//Print equation to display expression box
			equationPrint.Text = (operand1 + "^");
		}

		/*************NUMBERS**********/
		private void One_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 1
			input += "1";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Two_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 2
			input += "2";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Three_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 3
			input += "3";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Four_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 4
			input += "4";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Five_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 5
			input += "5";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Six_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 6
			input += "6";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Seven_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 7
			input += "7";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Eight_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 8
			input += "8";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}
		
		private void Nine_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 9
			input += "9";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void Zero_Click(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to 0
			input += "0";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}

		private void decimal_Btn(object sender, EventArgs e)
		{
			//Clear resultsTxt
			this.resultsTxt.Text = "";

			//Declare input to .
			input += ".";

			//Print input to resultsTxt
			this.resultsTxt.Text += input;

			//Print input to equation box
			equationPrint.Text = (operand1 + operation + input);
		}


		/*************FUNCTION 1 & 2**********/
		private void func1Btn_Click(object sender, EventArgs e)
		{
			//Declare function as 1
			function = "1";

			//Send to Future Feature Not Available Method
			this.FutureFeatureNotAvailable();
		}

		
		private void func2Btn_Click(object sender, EventArgs e)
		{
			//Declare function as 2
			function = "2";

			//Send to Future Feature Not Available Method
			this.FutureFeatureNotAvailable();
		}

	}
}
