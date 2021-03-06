/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 2/25/2020
 * Time: 3:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UI
{
	partial class FrmAddSessionCustomer
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIdSessionCustomer;
		private System.Windows.Forms.TextBox txtFullNameSessionCustomer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPhoneSessionCustomer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmailSessionCustomer;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtUserSessionCustomer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPasswordSessionCustomer;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtpDateAquisition;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnSaveSessionCustomer;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox cboStatusSessionCustomer;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RichTextBox rtbRemarksSessionCustomer;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSessionCustomer));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdSessionCustomer = new System.Windows.Forms.TextBox();
			this.txtFullNameSessionCustomer = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhoneSessionCustomer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmailSessionCustomer = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUserSessionCustomer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPasswordSessionCustomer = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpDateAquisition = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.btnSaveSessionCustomer = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.cboStatusSessionCustomer = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.rtbRemarksSessionCustomer = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(680, 27);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(5, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(173, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nuevo Cliente de Sesion";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
			this.btnClose.Location = new System.Drawing.Point(654, 1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(23, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(388, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Identificacion:*";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIdSessionCustomer
			// 
			this.txtIdSessionCustomer.Location = new System.Drawing.Point(494, 74);
			this.txtIdSessionCustomer.MaxLength = 20;
			this.txtIdSessionCustomer.Name = "txtIdSessionCustomer";
			this.txtIdSessionCustomer.Size = new System.Drawing.Size(137, 20);
			this.txtIdSessionCustomer.TabIndex = 3;
			// 
			// txtFullNameSessionCustomer
			// 
			this.txtFullNameSessionCustomer.Location = new System.Drawing.Point(494, 110);
			this.txtFullNameSessionCustomer.MaxLength = 200;
			this.txtFullNameSessionCustomer.Name = "txtFullNameSessionCustomer";
			this.txtFullNameSessionCustomer.Size = new System.Drawing.Size(137, 20);
			this.txtFullNameSessionCustomer.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(342, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nombre Completo:*";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhoneSessionCustomer
			// 
			this.txtPhoneSessionCustomer.Location = new System.Drawing.Point(494, 146);
			this.txtPhoneSessionCustomer.MaxLength = 20;
			this.txtPhoneSessionCustomer.Name = "txtPhoneSessionCustomer";
			this.txtPhoneSessionCustomer.Size = new System.Drawing.Size(137, 20);
			this.txtPhoneSessionCustomer.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(342, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Telefono:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtEmailSessionCustomer
			// 
			this.txtEmailSessionCustomer.Location = new System.Drawing.Point(494, 184);
			this.txtEmailSessionCustomer.MaxLength = 60;
			this.txtEmailSessionCustomer.Name = "txtEmailSessionCustomer";
			this.txtEmailSessionCustomer.Size = new System.Drawing.Size(137, 20);
			this.txtEmailSessionCustomer.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(342, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "E-mail:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUserSessionCustomer
			// 
			this.txtUserSessionCustomer.Location = new System.Drawing.Point(494, 222);
			this.txtUserSessionCustomer.MaxLength = 45;
			this.txtUserSessionCustomer.Name = "txtUserSessionCustomer";
			this.txtUserSessionCustomer.Size = new System.Drawing.Size(137, 20);
			this.txtUserSessionCustomer.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(342, 220);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(146, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Usuario:*";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPasswordSessionCustomer
			// 
			this.txtPasswordSessionCustomer.Location = new System.Drawing.Point(494, 259);
			this.txtPasswordSessionCustomer.MaxLength = 45;
			this.txtPasswordSessionCustomer.Name = "txtPasswordSessionCustomer";
			this.txtPasswordSessionCustomer.Size = new System.Drawing.Size(137, 20);
			this.txtPasswordSessionCustomer.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(342, 257);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(146, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Password:*";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(305, 299);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(146, 23);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fecha de Adquisicion:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDateAquisition
			// 
			this.dtpDateAquisition.Location = new System.Drawing.Point(452, 301);
			this.dtpDateAquisition.Name = "dtpDateAquisition";
			this.dtpDateAquisition.Size = new System.Drawing.Size(179, 20);
			this.dtpDateAquisition.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(342, 341);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(146, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Estado:*";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSaveSessionCustomer
			// 
			this.btnSaveSessionCustomer.BackColor = System.Drawing.Color.DarkSlateGray;
			this.btnSaveSessionCustomer.FlatAppearance.BorderSize = 0;
			this.btnSaveSessionCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveSessionCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSessionCustomer.Image")));
			this.btnSaveSessionCustomer.Location = new System.Drawing.Point(540, 476);
			this.btnSaveSessionCustomer.Name = "btnSaveSessionCustomer";
			this.btnSaveSessionCustomer.Size = new System.Drawing.Size(60, 60);
			this.btnSaveSessionCustomer.TabIndex = 18;
			this.btnSaveSessionCustomer.UseVisualStyleBackColor = false;
			this.btnSaveSessionCustomer.Click += new System.EventHandler(this.BtnSaveSessionCustomerClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(59, 74);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 257);
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			// 
			// cboStatusSessionCustomer
			// 
			this.cboStatusSessionCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStatusSessionCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cboStatusSessionCustomer.FormattingEnabled = true;
			this.cboStatusSessionCustomer.Location = new System.Drawing.Point(494, 341);
			this.cboStatusSessionCustomer.Name = "cboStatusSessionCustomer";
			this.cboStatusSessionCustomer.Size = new System.Drawing.Size(121, 21);
			this.cboStatusSessionCustomer.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(236, 388);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(146, 23);
			this.label10.TabIndex = 22;
			this.label10.Text = "Observaciones:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbRemarksSessionCustomer
			// 
			this.rtbRemarksSessionCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbRemarksSessionCustomer.Location = new System.Drawing.Point(388, 388);
			this.rtbRemarksSessionCustomer.MaxLength = 200;
			this.rtbRemarksSessionCustomer.Name = "rtbRemarksSessionCustomer";
			this.rtbRemarksSessionCustomer.Size = new System.Drawing.Size(243, 70);
			this.rtbRemarksSessionCustomer.TabIndex = 23;
			this.rtbRemarksSessionCustomer.Text = "";
			// 
			// FrmAddSessionCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkCyan;
			this.ClientSize = new System.Drawing.Size(680, 558);
			this.Controls.Add(this.rtbRemarksSessionCustomer);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.cboStatusSessionCustomer);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnSaveSessionCustomer);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtpDateAquisition);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtPasswordSessionCustomer);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtUserSessionCustomer);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtEmailSessionCustomer);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPhoneSessionCustomer);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtFullNameSessionCustomer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIdSessionCustomer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmAddSessionCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nuevo Cliente de Sesion";
			this.Load += new System.EventHandler(this.FrmAddSessionCustomerLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
