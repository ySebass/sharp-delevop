/*
 * Creado por SharpDevelop.
 * Usuario: Admin
 * Fecha: 27/10/2026
 * Hora: 08:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OperacionesBasicas
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double raiz,x1,x2;
			double a = Convert.ToDouble(txta.Text);
		    double b = Convert.ToDouble(txtb.Text);
		    double c = Convert.ToDouble(txtc.Text);
		    raiz = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
		    x1 = (-b + raiz) / (2 * a);
		    x2 = (-b - raiz) / (2 * a);
		    MessageBox.Show(" x1: "+x1+"\n"+" x2: "+x2);
		}
	}
}
