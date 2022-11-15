using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			cmbSelect.Text = "靠左三角形";
		}

		private void btnshow_Click(object sender, EventArgs e)
		{
			int height;
			try
			{
				height = IsTrueValue(txtInput.Text);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			if (cmbSelect.Text == "靠左三角形") LeftTriangle(height);
			if (cmbSelect.Text == "靠右三角形") RightTriangle(height);
			if (cmbSelect.Text == "等腰三角形") IsoscelesTriangle(height);
		}

		private int IsTrueValue(string input)
		{
			bool isTrue = int.TryParse(input, out int result);
			if (!isTrue) throw new Exception("輸入值非數字");
			else if (result < 1 || result > 10) throw new Exception("超過[1, 10]");

			return result;
		}

		private void LeftTriangle(int height)
		{
			string output = string.Empty;
			for(int i = 1; i <= height; i++)
			{
				for(int j = 1; j <= i; j++)
				{
					output += "*";
				}
				output += "\r\n";
			}
			txtShow.Text = output;
		}

		private void RightTriangle(int height)
		{
			string output = string.Empty;
			for(int i = 1; i <= height; i++)
			{
				for(int j = 1; j <= height; j++)
				{
					if (j <= height - i ) output += "  ";
					else output += "*";
				}
				output += "\r\n";
			}
			txtShow.Text = output;
		}

		private void IsoscelesTriangle(int height)
		{
			string output = string.Empty;
			for(int i = 1; i <= height; i++)
			{
				for(int j = 1; j <= height + i - 1; j++)
				{
					if (j < height - i + 1) output += "  ";
					else output += "*";
				}
				output += "\r\n";
			}
			txtShow.Text = output;
		}
	}
}
