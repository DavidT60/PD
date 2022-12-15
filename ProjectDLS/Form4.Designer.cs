
namespace ProjectDLS
{
    partial class Form4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackF1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.getDataFacturation = new System.Windows.Forms.TabPage();
            this.AddFacturation = new System.Windows.Forms.Button();
            this.AddFacturationPatient = new System.Windows.Forms.Panel();
            this.Paymend = new System.Windows.Forms.Label();
            this.PaymendBox = new System.Windows.Forms.Label();
            this.AddFacturationToDataGrid = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.GetIDN = new System.Windows.Forms.Label();
            this.getEMail = new System.Windows.Forms.Label();
            this.labelGetlastName = new System.Windows.Forms.Label();
            this.labelGetname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PayMode = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.typeOftratamient = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.FacturationG = new System.Windows.Forms.Panel();
            this.tratamient = new System.Windows.Forms.Label();
            this.personName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetIdPayment = new System.Windows.Forms.TextBox();
            this.totalPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn1 = new System.Windows.Forms.Button();
            this.InfLoaderCalculation = new System.Windows.Forms.Button();
            this.codeFact = new System.Windows.Forms.TextBox();
            this.dataGetFacturation = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.getDataFacturation.SuspendLayout();
            this.AddFacturationPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.FacturationG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetFacturation)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.BackF1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 525);
            this.panel1.TabIndex = 0;
            // 
            // BackF1
            // 
            this.BackF1.Location = new System.Drawing.Point(0, 0);
            this.BackF1.Name = "BackF1";
            this.BackF1.Size = new System.Drawing.Size(47, 39);
            this.BackF1.TabIndex = 1;
            this.BackF1.Text = "<-";
            this.BackF1.UseVisualStyleBackColor = true;
            this.BackF1.Click += new System.EventHandler(this.BackF1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paciente IDN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.getDataFacturation);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(227, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 525);
            this.tabControl1.TabIndex = 1;
            // 
            // getDataFacturation
            // 
            this.getDataFacturation.Controls.Add(this.AddFacturation);
            this.getDataFacturation.Controls.Add(this.AddFacturationPatient);
            this.getDataFacturation.Controls.Add(this.label12);
            this.getDataFacturation.Controls.Add(this.label11);
            this.getDataFacturation.Controls.Add(this.PayMode);
            this.getDataFacturation.Controls.Add(this.dateTimePicker1);
            this.getDataFacturation.Controls.Add(this.typeOftratamient);
            this.getDataFacturation.Controls.Add(this.label9);
            this.getDataFacturation.Controls.Add(this.p2);
            this.getDataFacturation.Controls.Add(this.label6);
            this.getDataFacturation.Controls.Add(this.p1);
            this.getDataFacturation.Controls.Add(this.label3);
            this.getDataFacturation.Controls.Add(this.label2);
            this.getDataFacturation.Controls.Add(this.FacturationG);
            this.getDataFacturation.Location = new System.Drawing.Point(4, 22);
            this.getDataFacturation.Name = "getDataFacturation";
            this.getDataFacturation.Padding = new System.Windows.Forms.Padding(3);
            this.getDataFacturation.Size = new System.Drawing.Size(768, 499);
            this.getDataFacturation.TabIndex = 0;
            this.getDataFacturation.Text = "Facturar";
            this.getDataFacturation.UseVisualStyleBackColor = true;
            // 
            // AddFacturation
            // 
            this.AddFacturation.Location = new System.Drawing.Point(363, 198);
            this.AddFacturation.Name = "AddFacturation";
            this.AddFacturation.Size = new System.Drawing.Size(42, 23);
            this.AddFacturation.TabIndex = 27;
            this.AddFacturation.Text = "🔎";
            this.AddFacturation.UseVisualStyleBackColor = true;
            this.AddFacturation.Click += new System.EventHandler(this.AddFacturation_Click);
            // 
            // AddFacturationPatient
            // 
            this.AddFacturationPatient.Controls.Add(this.Paymend);
            this.AddFacturationPatient.Controls.Add(this.PaymendBox);
            this.AddFacturationPatient.Controls.Add(this.AddFacturationToDataGrid);
            this.AddFacturationPatient.Controls.Add(this.label18);
            this.AddFacturationPatient.Controls.Add(this.GetIDN);
            this.AddFacturationPatient.Controls.Add(this.getEMail);
            this.AddFacturationPatient.Controls.Add(this.labelGetlastName);
            this.AddFacturationPatient.Controls.Add(this.labelGetname);
            this.AddFacturationPatient.Controls.Add(this.pictureBox1);
            this.AddFacturationPatient.Location = new System.Drawing.Point(459, 3);
            this.AddFacturationPatient.Name = "AddFacturationPatient";
            this.AddFacturationPatient.Size = new System.Drawing.Size(308, 215);
            this.AddFacturationPatient.TabIndex = 23;
            // 
            // Paymend
            // 
            this.Paymend.AutoSize = true;
            this.Paymend.Location = new System.Drawing.Point(20, 174);
            this.Paymend.Name = "Paymend";
            this.Paymend.Size = new System.Drawing.Size(37, 13);
            this.Paymend.TabIndex = 31;
            this.Paymend.Text = "Total :";
            // 
            // PaymendBox
            // 
            this.PaymendBox.AutoSize = true;
            this.PaymendBox.Location = new System.Drawing.Point(61, 174);
            this.PaymendBox.Name = "PaymendBox";
            this.PaymendBox.Size = new System.Drawing.Size(21, 13);
            this.PaymendBox.TabIndex = 30;
            this.PaymendBox.Text = "--l: ";
            // 
            // AddFacturationToDataGrid
            // 
            this.AddFacturationToDataGrid.Location = new System.Drawing.Point(149, 174);
            this.AddFacturationToDataGrid.Name = "AddFacturationToDataGrid";
            this.AddFacturationToDataGrid.Size = new System.Drawing.Size(159, 35);
            this.AddFacturationToDataGrid.TabIndex = 29;
            this.AddFacturationToDataGrid.Text = "Agregar a la Factura";
            this.AddFacturationToDataGrid.UseVisualStyleBackColor = true;
            this.AddFacturationToDataGrid.Click += new System.EventHandler(this.AddFacturationToDataGrid_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(236, -3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Paciente Inf--";
            // 
            // GetIDN
            // 
            this.GetIDN.AutoSize = true;
            this.GetIDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetIDN.Location = new System.Drawing.Point(20, 110);
            this.GetIDN.Name = "GetIDN";
            this.GetIDN.Size = new System.Drawing.Size(36, 18);
            this.GetIDN.TabIndex = 28;
            this.GetIDN.Text = "IDN";
            // 
            // getEMail
            // 
            this.getEMail.AutoSize = true;
            this.getEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getEMail.Location = new System.Drawing.Point(20, 82);
            this.getEMail.Name = "getEMail";
            this.getEMail.Size = new System.Drawing.Size(50, 18);
            this.getEMail.TabIndex = 27;
            this.getEMail.Text = "Email";
            // 
            // labelGetlastName
            // 
            this.labelGetlastName.AutoSize = true;
            this.labelGetlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetlastName.Location = new System.Drawing.Point(132, 51);
            this.labelGetlastName.Name = "labelGetlastName";
            this.labelGetlastName.Size = new System.Drawing.Size(67, 18);
            this.labelGetlastName.TabIndex = 26;
            this.labelGetlastName.Text = "Apellido";
            // 
            // labelGetname
            // 
            this.labelGetname.AutoSize = true;
            this.labelGetname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGetname.Location = new System.Drawing.Point(132, 16);
            this.labelGetname.Name = "labelGetname";
            this.labelGetname.Size = new System.Drawing.Size(68, 18);
            this.labelGetname.TabIndex = 25;
            this.labelGetname.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDLS.Properties.Resources.e4b72ecbb7c98f492629cbeee66435e8;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(116, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 18);
            this.label12.TabIndex = 20;
            this.label12.Text = "Modo de Pago";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(199, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "Fecha";
            // 
            // PayMode
            // 
            this.PayMode.FormattingEnabled = true;
            this.PayMode.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.PayMode.Location = new System.Drawing.Point(119, 246);
            this.PayMode.Name = "PayMode";
            this.PayMode.Size = new System.Drawing.Size(134, 21);
            this.PayMode.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // typeOftratamient
            // 
            this.typeOftratamient.FormattingEnabled = true;
            this.typeOftratamient.Location = new System.Drawing.Point(216, 198);
            this.typeOftratamient.Name = "typeOftratamient";
            this.typeOftratamient.Size = new System.Drawing.Size(130, 21);
            this.typeOftratamient.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(213, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tratamiento";
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(37, 198);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(130, 20);
            this.p2.TabIndex = 11;
            this.p2.TextChanged += new System.EventHandler(this.p2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Doc IDN";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(28, 107);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(130, 20);
            this.p1.TabIndex = 5;
            this.p1.TextChanged += new System.EventHandler(this.p1_TextChanged);
            // 
            // FacturationG
            // 
            this.FacturationG.Controls.Add(this.tratamient);
            this.FacturationG.Controls.Add(this.personName);
            this.FacturationG.Controls.Add(this.label8);
            this.FacturationG.Controls.Add(this.label4);
            this.FacturationG.Controls.Add(this.GetIdPayment);
            this.FacturationG.Controls.Add(this.totalPayment);
            this.FacturationG.Controls.Add(this.label5);
            this.FacturationG.Controls.Add(this.label13);
            this.FacturationG.Controls.Add(this.label7);
            this.FacturationG.Controls.Add(this.Btn1);
            this.FacturationG.Controls.Add(this.InfLoaderCalculation);
            this.FacturationG.Controls.Add(this.codeFact);
            this.FacturationG.Controls.Add(this.dataGetFacturation);
            this.FacturationG.Location = new System.Drawing.Point(2, 289);
            this.FacturationG.Name = "FacturationG";
            this.FacturationG.Size = new System.Drawing.Size(732, 207);
            this.FacturationG.TabIndex = 34;
            // 
            // tratamient
            // 
            this.tratamient.AutoSize = true;
            this.tratamient.Location = new System.Drawing.Point(26, 69);
            this.tratamient.Name = "tratamient";
            this.tratamient.Size = new System.Drawing.Size(0, 13);
            this.tratamient.TabIndex = 36;
            // 
            // personName
            // 
            this.personName.AutoSize = true;
            this.personName.Location = new System.Drawing.Point(26, 42);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(0, 13);
            this.personName.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ultimo Pago en:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tabla de Facturras";
            // 
            // GetIdPayment
            // 
            this.GetIdPayment.Location = new System.Drawing.Point(427, 19);
            this.GetIdPayment.Name = "GetIdPayment";
            this.GetIdPayment.Size = new System.Drawing.Size(100, 20);
            this.GetIdPayment.TabIndex = 30;
            this.GetIdPayment.TextChanged += new System.EventHandler(this.GetIdPayment_TextChanged);
            // 
            // totalPayment
            // 
            this.totalPayment.Location = new System.Drawing.Point(556, 19);
            this.totalPayment.Name = "totalPayment";
            this.totalPayment.Size = new System.Drawing.Size(100, 20);
            this.totalPayment.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "PACIENTE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(553, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "MONTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "CODE FACTURA\r\n";
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Red;
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(31, 106);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(105, 39);
            this.Btn1.TabIndex = 26;
            this.Btn1.Text = "Cancelar";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // InfLoaderCalculation
            // 
            this.InfLoaderCalculation.Location = new System.Drawing.Point(31, 151);
            this.InfLoaderCalculation.Name = "InfLoaderCalculation";
            this.InfLoaderCalculation.Size = new System.Drawing.Size(105, 41);
            this.InfLoaderCalculation.TabIndex = 22;
            this.InfLoaderCalculation.Text = "Facturar";
            this.InfLoaderCalculation.UseVisualStyleBackColor = true;
            this.InfLoaderCalculation.Click += new System.EventHandler(this.InfLoaderCalculation_Click);
            // 
            // codeFact
            // 
            this.codeFact.Location = new System.Drawing.Point(312, 19);
            this.codeFact.Name = "codeFact";
            this.codeFact.Size = new System.Drawing.Size(100, 20);
            this.codeFact.TabIndex = 31;
            // 
            // dataGetFacturation
            // 
            this.dataGetFacturation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGetFacturation.Location = new System.Drawing.Point(142, 42);
            this.dataGetFacturation.Name = "dataGetFacturation";
            this.dataGetFacturation.Size = new System.Drawing.Size(529, 150);
            this.dataGetFacturation.TabIndex = 25;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.getDataFacturation.ResumeLayout(false);
            this.getDataFacturation.PerformLayout();
            this.AddFacturationPatient.ResumeLayout(false);
            this.AddFacturationPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.FacturationG.ResumeLayout(false);
            this.FacturationG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGetFacturation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackF1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage getDataFacturation;
        private System.Windows.Forms.ComboBox typeOftratamient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox p2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button InfLoaderCalculation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox PayMode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel AddFacturationPatient;
        private System.Windows.Forms.Label GetIDN;
        private System.Windows.Forms.Label getEMail;
        private System.Windows.Forms.Label labelGetlastName;
        private System.Windows.Forms.Label labelGetname;
        private System.Windows.Forms.Button AddFacturationToDataGrid;
        private System.Windows.Forms.DataGridView dataGetFacturation;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button AddFacturation;
        private System.Windows.Forms.Label PaymendBox;
        private System.Windows.Forms.Label Paymend;
        private System.Windows.Forms.TextBox totalPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codeFact;
        private System.Windows.Forms.TextBox GetIdPayment;
        private System.Windows.Forms.Panel FacturationG;
        private System.Windows.Forms.Label tratamient;
        private System.Windows.Forms.Label personName;
        private System.Windows.Forms.Label label8;
    }
}