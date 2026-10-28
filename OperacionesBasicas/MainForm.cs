/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 27/10/2026
 * Time: 07:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OperacionesBasicas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		double num1, num2, suma, resta, multiplicacion, divicion, modulo;
		void BtnSumaClick(object sender, EventArgs e)
		{
			num1=Convert.ToDouble(txtnum1.Text);
			num2=Convert.ToDouble(txtnum2.Text);
			suma=num1+num2;
			MessageBox.Show("SUMA: "+suma);
		}
		
		void BtnRestaClick(object sender, EventArgs e)
		{
			num1=Convert.ToDouble(txtnum1.Text);
			num2=Convert.ToDouble(txtnum2.Text);
			resta=num1-num2;
			MessageBox.Show("RESTA: "+resta);
		}
		
		void BtnMultiClick(object sender, EventArgs e)
		{
			num1=Convert.ToDouble(txtnum1.Text);
			num2=Convert.ToDouble(txtnum2.Text);
			multiplicacion=num1*num2;
			MessageBox.Show("MULTIPLICACION: "+multiplicacion);
		}
		
		void BtnDivicionClick(object sender, EventArgs e)
		{
			num1=Convert.ToDouble(txtnum1.Text);
			num2=Convert.ToDouble(txtnum2.Text);
			divicion=num1/num2;
			MessageBox.Show("DIVICION: "+divicion);
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			num1=Convert.ToDouble(txtnum1.Text);
			num2=Convert.ToDouble(txtnum2.Text);
			modulo=num1%num2;
			MessageBox.Show("Modulo: "+modulo);
		}
		
		void BtnFormulaClick(object sender, EventArgs e)
		{
			Form1 f=new Form1();
			f.Show();
			this.Hide();
		}
	}
}
