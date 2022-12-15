
namespace ProjectDLS
{
    partial class Form2
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
            this.hello = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Panel();
            this.Reporte = new System.Windows.Forms.Button();
            this.ApplicationClose = new System.Windows.Forms.Button();
            this.StaffAd = new System.Windows.Forms.Button();
            this.GoStaff = new System.Windows.Forms.Button();
            this.OpenPasienteForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Reports = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hello
            // 
            this.hello.AutoSize = true;
            this.hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello.Location = new System.Drawing.Point(311, 56);
            this.hello.Name = "hello";
            this.hello.Size = new System.Drawing.Size(272, 55);
            this.hello.TabIndex = 0;
            this.hello.Text = "Bienvenido";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DodgerBlue;
            this.menu.Controls.Add(this.Reports);
            this.menu.Controls.Add(this.Reporte);
            this.menu.Controls.Add(this.ApplicationClose);
            this.menu.Controls.Add(this.StaffAd);
            this.menu.Controls.Add(this.GoStaff);
            this.menu.Controls.Add(this.OpenPasienteForm);
            this.menu.Controls.Add(this.label1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(259, 540);
            this.menu.TabIndex = 1;
            // 
            // Reporte
            // 
            this.Reporte.BackColor = System.Drawing.Color.White;
            this.Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reporte.Location = new System.Drawing.Point(0, 320);
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(259, 44);
            this.Reporte.TabIndex = 5;
            this.Reporte.Text = "Estados P & D";
            this.Reporte.UseVisualStyleBackColor = false;
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // ApplicationClose
            // 
            this.ApplicationClose.BackColor = System.Drawing.Color.White;
            this.ApplicationClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationClose.Location = new System.Drawing.Point(0, 496);
            this.ApplicationClose.Name = "ApplicationClose";
            this.ApplicationClose.Size = new System.Drawing.Size(259, 44);
            this.ApplicationClose.TabIndex = 4;
            this.ApplicationClose.Text = "Salir ";
            this.ApplicationClose.UseVisualStyleBackColor = false;
            this.ApplicationClose.Click += new System.EventHandler(this.ApplicationClose_Click);
            // 
            // StaffAd
            // 
            this.StaffAd.BackColor = System.Drawing.Color.White;
            this.StaffAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffAd.Location = new System.Drawing.Point(0, 279);
            this.StaffAd.Name = "StaffAd";
            this.StaffAd.Size = new System.Drawing.Size(259, 44);
            this.StaffAd.TabIndex = 3;
            this.StaffAd.Text = "Control";
            this.StaffAd.UseVisualStyleBackColor = false;
            this.StaffAd.Click += new System.EventHandler(this.StaffAd_Click);
            // 
            // GoStaff
            // 
            this.GoStaff.BackColor = System.Drawing.Color.White;
            this.GoStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoStaff.Location = new System.Drawing.Point(0, 152);
            this.GoStaff.Name = "GoStaff";
            this.GoStaff.Size = new System.Drawing.Size(259, 44);
            this.GoStaff.TabIndex = 2;
            this.GoStaff.Text = "Facturacion";
            this.GoStaff.UseVisualStyleBackColor = false;
            this.GoStaff.Click += new System.EventHandler(this.GoStaff_Click);
            // 
            // OpenPasienteForm
            // 
            this.OpenPasienteForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenPasienteForm.Location = new System.Drawing.Point(0, 113);
            this.OpenPasienteForm.Name = "OpenPasienteForm";
            this.OpenPasienteForm.Size = new System.Drawing.Size(259, 44);
            this.OpenPasienteForm.TabIndex = 1;
            this.OpenPasienteForm.Text = "Pacientes";
            this.OpenPasienteForm.UseVisualStyleBackColor = true;
            this.OpenPasienteForm.Click += new System.EventHandler(this.OpenPasienteForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDLS.Properties.Resources.dentist_icon_with_png_and_vector_format_for_free_unlimited_6965071;
            this.pictureBox1.Location = new System.Drawing.Point(337, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.White;
            this.Reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.Location = new System.Drawing.Point(0, 359);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(259, 44);
            this.Reports.TabIndex = 6;
            this.Reports.Text = "Reportes";
            this.Reports.UseVisualStyleBackColor = false;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.hello);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hello;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button ApplicationClose;
        private System.Windows.Forms.Button StaffAd;
        private System.Windows.Forms.Button GoStaff;
        private System.Windows.Forms.Button OpenPasienteForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Reporte;
        private System.Windows.Forms.Button Reports;
    }
}