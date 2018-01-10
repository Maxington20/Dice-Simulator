using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//System.IO had to be added for writing to a file
using System.IO;

namespace Dice_Simulator
{
	public partial class Form1 : Form
	{

		//set the images from resources to allow them to be changed depending on the rolls
		Bitmap roll1 = Properties.Resources.Die1;
		Bitmap roll2 = Properties.Resources.Die2;
		Bitmap roll3 = Properties.Resources.Die3;
		Bitmap roll4 = Properties.Resources.Die4;
		Bitmap roll5 = Properties.Resources.Die5;
		Bitmap roll6 = Properties.Resources.Die6;

		public Form1()
		{
			InitializeComponent();
		}
		private void exitBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void rollBtn_Click(object sender, EventArgs e)
		{
			//generate random numbers between 1-6 for each die
			Random rnd = new Random();
			int die1 = rnd.Next(1, 7);
			int die2 = rnd.Next(1, 7);

			//die 1 image changes
			if (die1 == 1)
			{
				die1Img.Image = roll1;
			}
			else if (die1 == 2)
			{
				die1Img.Image = roll2;
			}
			else if (die1 == 3)
			{
				die1Img.Image = roll3;
			}
			else if (die1 == 4)
			{
				die1Img.Image = roll4;
			}
			else if (die1 == 5)
			{
				die1Img.Image = roll5;
			}
			else
			{
				die1Img.Image = roll6;
			}

			//die 2 image changes
			if (die2 == 1)
			{
				die2Img.Image = roll1;
			}

			else if (die2 == 2)
			{
				die2Img.Image = roll2;
			}
			else if (die2 == 3)
			{
				die2Img.Image = roll3;
			}
			else if (die2 == 4)
			{
				die2Img.Image = roll4;
			}
			else if (die2 == 5)
			{
				die2Img.Image = roll5;
			}
			else
			{
				die2Img.Image = roll6;
			}

			//convert the random int to a string in order to display in the
				//two text boxes
			die1Txtbox.Text = Convert.ToString(die1);
			die2Txtbox.Text = Convert.ToString(die2);

			//create/update the rolls.txt file with the results of the dice rolls
			StreamWriter rollResult = new StreamWriter ("C:\\Users\\m_a_x\\Documents\\Software_Dev" +
				"\\Assignment5\\Max's Dice Simulator\\rolls.txt",true);
			rollResult.WriteLine("die 1: " + die1Txtbox.Text + "     die 2: " + die2Txtbox.Text);
			rollResult.Close();
			
		}

		private void resetBtn_Click(object sender, EventArgs e)
		{
			//clear out the text boxes and reset the images to their defaults
			die1Txtbox.Text = "";
			die2Txtbox.Text = "";
			die1Img.Image = roll1;
			die2Img.Image = roll1;

			//clear out the data within the rolls.txt file
			//altered the file path after getting the feedback grom Vikas during the presentation
			StreamWriter rollResult = new StreamWriter(@"C:\Users\m_a_x\Documents\Software_Dev" +
				@"\Assignment5\Max's Dice Simulator\rolls.txt");
			rollResult.Write("");
			rollResult.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
