/*
 * Created by SharpDevelop.
 * User: CC2_PC28
 * Date: 27/10/2026
 * Time: 07:22 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace OperacionesBasicas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSuma = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtnum1 = new System.Windows.Forms.TextBox();
			this.txtnum2 = new System.Windows.Forms.TextBox();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnDivicion = new System.Windows.Forms.Button();
			this.btnMulti = new System.Windows.Forms.Button();
			this.btnModulo = new System.Windows.Forms.Button();
			this.btnFormula = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSuma
			// 
			this.btnSuma.Location = new System.Drawing.Point(23, 99);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(97, 43);
			this.btnSuma.TabIndex = 0;
			this.btnSuma.Text = "Suma";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Numero 1:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Numero 2:";
			// 
			// txtnum1
			// 
			this.txtnum1.Location = new System.Drawing.Point(128, 6);
			this.txtnum1.Multiline = true;
			this.txtnum1.Name = "txtnum1";
			this.txtnum1.Size = new System.Drawing.Size(100, 26);
			this.txtnum1.TabIndex = 6;
			// 
			// txtnum2
			// 
			this.txtnum2.Location = new System.Drawing.Point(128, 55);
			this.txtnum2.Multiline = true;
			this.txtnum2.Name = "txtnum2";
			this.txtnum2.Size = new System.Drawing.Size(100, 26);
			this.txtnum2.TabIndex = 7;
			// 
			// btnResta
			// 
			this.btnResta.Location = new System.Drawing.Point(166, 99);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(97, 43);
			this.btnResta.TabIndex = 8;
			this.btnResta.Text = "Resta";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnDivicion
			// 
			this.btnDivicion.Location = new System.Drawing.Point(166, 158);
			this.btnDivicion.Name = "btnDivicion";
			this.btnDivicion.Size = new System.Drawing.Size(97, 43);
			this.btnDivicion.TabIndex = 9;
			this.btnDivicion.Text = "Divicion";
			this.btnDivicion.UseVisualStyleBackColor = true;
			this.btnDivicion.Click += new System.EventHandler(this.BtnDivicionClick);
			// 
			// btnMulti
			// 
			this.btnMulti.Location = new System.Drawing.Point(23, 158);
			this.btnMulti.Name = "btnMulti";
			this.btnMulti.Size = new System.Drawing.Size(97, 43);
			this.btnMulti.TabIndex = 10;
			this.btnMulti.Text = "Multiplicacion";
			this.btnMulti.UseVisualStyleBackColor = true;
			this.btnMulti.Click += new System.EventHandler(this.BtnMultiClick);
			// 
			// btnModulo
			// 
			this.btnModulo.Location = new System.Drawing.Point(25, 207);
			this.btnModulo.Name = "btnModulo";
			this.btnModulo.Size = new System.Drawing.Size(97, 43);
			this.btnModulo.TabIndex = 11;
			this.btnModulo.Text = "Modulo";
			this.btnModulo.UseVisualStyleBackColor = true;
			this.btnModulo.Click += new System.EventHandler(this.BtnModuloClick);
			// 
			// btnFormula
			// 
			this.btnFormula.Location = new System.Drawing.Point(166, 207);
			this.btnFormula.Name = "btnFormula";
			this.btnFormula.Size = new System.Drawing.Size(97, 43);
			this.btnFormula.TabIndex = 12;
			this.btnFormula.Text = "Formula general";
			this.btnFormula.UseVisualStyleBackColor = true;
			this.btnFormula.Click += new System.EventHandler(this.BtnFormulaClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnFormula);
			this.Controls.Add(this.btnModulo);
			this.Controls.Add(this.btnMulti);
			this.Controls.Add(this.btnDivicion);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.txtnum2);
			this.Controls.Add(this.txtnum1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSuma);
			this.Name = "MainForm";
			this.Text = "OperacionesBasicas";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnFormula;
		private System.Windows.Forms.Button btnModulo;
		private System.Windows.Forms.Button btnMulti;
		private System.Windows.Forms.Button btnDivicion;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.TextBox txtnum2;
		private System.Windows.Forms.TextBox txtnum1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSuma;
	}
}
