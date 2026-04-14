using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentGrading
{
	public partial class Form1 : Form
	{
		MySqlConnection con = new MySqlConnection("datasource=localhost; username=root;password=;database=dbplmun");
		MySqlCommand cmd =new MySqlCommand();
		MySqlDataReader dtr; 

		double MQ1Ave, MQ2Ave, MQ3Ave, MQ4Ave, MEAve;
		double FQ1Ave, FQ2Ave, FQ3Ave, FQ4Ave, FEAve;

		double MCP, MA, MLectureGrade, MLabGrade, MidtermGrade;
		double FCP, FA, FLectureGrade, FLabGrade, FinalGrade;
		double FinalAverage;


		private void txtMCP_TextChanged(object sender, EventArgs e)
		{
			computeGrade();
		}

		private void txtMA_TextChanged(object sender, EventArgs e)
		{
			computeGrade();
		}

		private void txtMLabGrade_TextChanged(object sender, EventArgs e)
		{
			computeGrade();
		}

		private void txtFinalAve_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void finalGradingTab_Click(object sender, EventArgs e)
		{

		}

		private void txtFLabGrade_TextChanged(object sender, EventArgs e)
		{
			computeGrade();
		}


		private void txtFA_TextChanged(object sender, EventArgs e)
		{
			computeGrade();
		}

		
		private void txtFCP_TextChanged(object sender, EventArgs e)
		{
			computeGrade();
		}

		public void computeGrade()
		{

			double.TryParse(txtMCP.Text, out MCP);
			double.TryParse(txtMA.Text, out MA);
			double.TryParse(txtMQ1Ave.Text, out MQ1Ave);
			double.TryParse(txtMQ2Ave.Text, out MQ2Ave);
			double.TryParse(txtMQ3Ave.Text, out MQ3Ave);
			double.TryParse(txtMQ4Ave.Text, out MQ4Ave);
			double.TryParse(txtMEAve.Text, out MEAve);

			double.TryParse(txtMLabGrade.Text, out MLabGrade);

			MLectureGrade = (MA * .10) + (MCP * .20) + ((MQ1Ave + MQ2Ave + MQ3Ave + MQ4Ave) / 4 * .30) + (MEAve * .40);
			MidtermGrade = (MLectureGrade * .60) + (MLabGrade * .40);
			txtMidtermGrade.Text = MidtermGrade.ToString("F2");

			//Finals

			double.TryParse(txtFCP.Text, out FCP);
			double.TryParse(txtFA.Text, out FA);
			double.TryParse(txtFQ1Ave.Text, out FQ1Ave);
			double.TryParse(txtFQ2Ave.Text, out FQ2Ave);
			double.TryParse(txtFQ3Ave.Text, out FQ3Ave);
			double.TryParse(txtFQ4Ave.Text, out FQ4Ave);
			double.TryParse(txtFEAve.Text, out FEAve);

			double.TryParse(txtFLabGrade.Text, out FLabGrade);


			FLectureGrade = (FA * .10) + (FCP * .20) + ((FQ1Ave + FQ2Ave + FQ3Ave + FQ4Ave) / 4 * .30) + (FEAve * .40);
			FinalGrade = (FLectureGrade * .60) + (FLabGrade * .40);
			txtFinalGrade.Text = FinalGrade.ToString("F2");

			FinalAverage = (MidtermGrade + FinalGrade) / 2;

			(double equivalent, string remarks) = GetEquivalentandRemarks(FinalAverage);

			txtFinalAve.Text = FinalAverage.ToString("F2") + " / " +  equivalent.ToString("F2");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			loadrecords();
		}

		private (double, string) GetEquivalentandRemarks(double average)
		{
			if (FinalAverage == 4.00)
				return (4.00, "incomplete");
			else if (FinalAverage == 6.00)
				return (6.00, "UW");

			if (FinalAverage >= 97.00 && FinalAverage <= 100.00)
				return (1.00, "Passed");
			else if (FinalAverage >= 94.00 && FinalAverage < 97.00)
				return (1.25, "Passed");
			else if (FinalAverage >= 91.00 && FinalAverage < 94.00)
				return (1.50, "Passed");
			else if (FinalAverage >= 88.00 && FinalAverage < 91.00)
				return (1.75, "Passed");
			else if (FinalAverage >= 85.00 && FinalAverage < 88.00)
				return (2.00, "Passed");
			else if (FinalAverage >= 82.00 && FinalAverage < 85.00)
				return (2.25, "Passed");
			else if (FinalAverage >= 79.00 && FinalAverage < 82.00)
				return (2.50, "Passed");
			else if (FinalAverage >= 76.00 && FinalAverage < 79.00)
				return (2.75, "Passed");
			else if (FinalAverage >= 74.00 && FinalAverage < 76.00)
				return (3.00, "Passed");
			else if (FinalAverage < 74.00)
				return (5.00, "Failed");

			return (0, "Invalid Grade");
		}

		private void txtSA_TextChanged(object sender, EventArgs e)
		{
			if (txtSA.Text == "4")
			{
				FinalAverage = 4.00;
				(double equivalent, string remarks) = GetEquivalentandRemarks(FinalAverage);
				txtFinalAve.Text = FinalAverage.ToString("F2") + " / " + equivalent.ToString("F2");
			}

			else if (txtSA.Text == "6")
			{
				FinalAverage = 6.00;
				(double equivalent, string remarks) = GetEquivalentandRemarks(FinalAverage);
				txtFinalAve.Text = FinalAverage.ToString("F2") + " / " + equivalent.ToString("F2");
			}
		}

		public void loadrecords()
		{
			try
			{
				con.Open();
				string sql = "SELECT s.studNum, s.surname, .s.firstname, s.year, s.program, s.subject, g.saved, g.uploaded, g.remarks FROM tblstudents s INNER JOIN tblgrades g ON s.studNum = g.studNum";
				MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
				DataTable dt = new DataTable();

				da.Fill(dt);
				dgvStudents.DataSource = dt;
			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);

			}
			finally
			{
				con.Close();
			}
		}


		private void txtFQ2_TextChanged(object sender, EventArgs e)
		{
			string FItemsQ2 = cboFItemsQ2.SelectedItem.ToString();

			double FQ2;
			double.TryParse(txtFQ2.Text, out FQ2);

			FQ2Ave = (FQ2 / Convert.ToDouble(FItemsQ2)) * 60 + 40;
			txtFQ2Ave.Text = FQ2Ave.ToString("F2");
			computeGrade();
		}

		private void txtFQ3_TextChanged(object sender, EventArgs e)
		{
			string FItemsQ3 = cboFItemsQ3.SelectedItem.ToString();

			double FQ3;
			double.TryParse(txtFQ3.Text, out FQ3);

			FQ3Ave = (FQ3 / Convert.ToDouble(FItemsQ3)) * 60 + 40;
			txtFQ3Ave.Text = FQ3Ave.ToString("F2");
			computeGrade();
		}

		private void txtFQ4_TextChanged(object sender, EventArgs e)
		{
			string FItemsQ4 = cboFItemsQ4.SelectedItem.ToString();

			double FQ4;
			double.TryParse(txtFQ4.Text, out FQ4);

			FQ4Ave = (FQ4 / Convert.ToDouble(FItemsQ4)) * 60 + 40;
			txtFQ4Ave.Text = FQ4Ave.ToString("F2");
			computeGrade();
		}

		private void txtFE_TextChanged(object sender, EventArgs e)
		{
			string FItemsFE = cboFItemsFE.SelectedItem.ToString();

			double FE;
			double.TryParse(txtFE.Text, out FE);

			FEAve = (FE / Convert.ToDouble(FItemsFE)) * 60 + 40;
			txtFEAve.Text = FEAve.ToString("F2");
			computeGrade();
		}

		private void txtFQ1_TextChanged(object sender, EventArgs e)
		{
			string FItemsQ1 = cboFItemsQ1.SelectedItem.ToString();

			double FQ1;
			double.TryParse(txtFQ1.Text, out FQ1);

			FQ1Ave = (FQ1 / Convert.ToDouble(FItemsQ1)) * 60 + 40;
			txtFQ1Ave.Text = FQ1Ave.ToString("F2");
			computeGrade();
		}

		private void txtMQ3_TextChanged(object sender, EventArgs e)
		{
			string MItemsQ3 = cboMItemsQ3.SelectedItem.ToString();

			double MQ3;
			double.TryParse(txtMQ3.Text, out MQ3);

			MQ3Ave = (MQ3 / Convert.ToDouble(MItemsQ3)) * 60 + 40;
			txtMQ3Ave.Text = MQ3Ave.ToString("F2");
			computeGrade();
		}

		private void txtMQ4_TextChanged(object sender, EventArgs e)
		{
			string MItemsQ4 = cboMItemsQ4.SelectedItem.ToString();

			double MQ4;
			double.TryParse(txtMQ4.Text, out MQ4);

			MQ4Ave = (MQ4 / Convert.ToDouble(MItemsQ4)) * 60 + 40;
			txtMQ4Ave.Text = MQ4Ave.ToString("F2");
			computeGrade();
		}

		private void txtMe_TextChanged(object sender, EventArgs e)
		{
			string MItemsME = cboMItemsME.SelectedItem.ToString();

			double ME;
			double.TryParse(txtME.Text, out ME);

			MEAve = (ME / Convert.ToDouble(MItemsME)) * 60 + 40;
			txtMEAve.Text = MEAve.ToString("F2");
			computeGrade();
		}

		private void txtMQ2_TextChanged(object sender, EventArgs e)
		{
			string MItemsQ2 = cboMItemsQ2.SelectedItem.ToString();

			double MQ2;
			double.TryParse(txtMQ2.Text, out MQ2);

			MQ2Ave = (MQ2 / Convert.ToDouble(MItemsQ2)) * 60 + 40;
			txtMQ2Ave.Text = MQ2Ave.ToString("F2");
			computeGrade();
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void txtSA_Enter(object sender, EventArgs e)
		{
			txtSA.Clear();
		}

		private void txtSA_Leave(object sender, EventArgs e)
		{
			txtSA.Text = "encode here";
		}


		private void txtMQ1_TextChanged(object sender, EventArgs e)
		{
			string MItemsQ1 = cboMItemsQ1.SelectedItem.ToString();

			double MQ1;
			double.TryParse(txtMQ1.Text, out MQ1);

			MQ1Ave = (MQ1 / Convert.ToDouble(MItemsQ1)) * 60 + 40;
			txtMQ1Ave.Text = MQ1Ave.ToString("F2");
			computeGrade();
		}
	}
}
