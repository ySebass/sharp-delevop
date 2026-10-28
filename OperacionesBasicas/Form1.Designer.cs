/*
 * Creado por SharpDevelop.
 * Usuario: Admin
 * Fecha: 27/10/2026
 * Hora: 08:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace OperacionesBasicas
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txta = new System.Windows.Forms.TextBox();
			this.txtb = new System.Windows.Forms.TextBox();
			this.txtc = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(80, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "A:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(80, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "B:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(80, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "C:";
			// 
			// txta
			// 
			this.txta.Location = new System.Drawing.Point(113, 18);
			this.txta.Name = "txta";
			this.txta.Size = new System.Drawing.Size(100, 20);
			this.txta.TabIndex = 3;
			// 
			// txtb
			// 
			this.txtb.Location = new System.Drawing.Point(113, 52);
			this.txtb.Name = "txtb";
			this.txtb.Size = new System.Drawing.Size(100, 20);
			this.txtb.TabIndex = 4;
			// 
			// txtc
			// 
			this.txtc.Location = new System.Drawing.Point(113, 84);
			this.txtc.Name = "txtc";
			this.txtc.Size = new System.Drawing.Size(100, 20);
			this.txtc.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.Highlight;
			this.button1.Location = new System.Drawing.Point(94, 138);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 57);
			this.button1.TabIndex = 6;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtc);
			this.Controls.Add(this.txtb);
			this.Controls.Add(this.txta);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtc;
		private System.Windows.Forms.TextBox txtb;
		private System.Windows.Forms.TextBox txta;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
