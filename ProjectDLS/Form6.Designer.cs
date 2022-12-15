
namespace ProjectDLS
{
    partial class from6
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
            this.ActivePatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.reportCosnult = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.ReporInactiveEmployer = new System.Windows.Forms.DataGridView();
            this.reportesPatient = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.reportCosnult.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporInactiveEmployer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivePatient
            // 
            this.ActivePatient.Location = new System.Drawing.Point(389, 14);
            this.ActivePatient.Name = "ActivePatient";
            this.ActivePatient.Size = new System.Drawing.Size(84, 33);
            this.ActivePatient.TabIndex = 7;
            this.ActivePatient.Text = "Activar🔛";
            this.ActivePatient.UseVisualStyleBackColor = true;
            this.ActivePatient.Click += new System.EventHandler(this.ActivePatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.BackBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 450);
            this.panel1.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(51, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ventana";
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(0, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 34);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "<-";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estados P & D";
            // 
            // reportCosnult
            // 
            this.reportCosnult.Controls.Add(this.tabPage1);
            this.reportCosnult.Dock = System.Windows.Forms.DockStyle.Left;
            this.reportCosnult.Location = new System.Drawing.Point(213, 0);
            this.reportCosnult.Name = "reportCosnult";
            this.reportCosnult.SelectedIndex = 0;
            this.reportCosnult.Size = new System.Drawing.Size(575, 450);
            this.reportCosnult.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ReporInactiveEmployer);
            this.tabPage1.Controls.Add(this.reportesPatient);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ActivePatient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(30, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Todos Los Empleados Inactivos";
            // 
            // ReporInactiveEmployer
            // 
            this.ReporInactiveEmployer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReporInactiveEmployer.Location = new System.Drawing.Point(22, 240);
            this.ReporInactiveEmployer.Name = "ReporInactiveEmployer";
            this.ReporInactiveEmployer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReporInactiveEmployer.Size = new System.Drawing.Size(509, 137);
            this.ReporInactiveEmployer.TabIndex = 9;
            this.ReporInactiveEmployer.Click += new System.EventHandler(this.ReporInactiveEmployer_Click);
            // 
            // reportesPatient
            // 
            this.reportesPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportesPatient.Location = new System.Drawing.Point(22, 53);
            this.reportesPatient.Name = "reportesPatient";
            this.reportesPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportesPatient.Size = new System.Drawing.Size(509, 137);
            this.reportesPatient.TabIndex = 8;
            this.reportesPatient.Click += new System.EventHandler(this.reportesPatient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Todos Los Pacientes Inactivos";
            // 
            // from6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportCosnult);
            this.Controls.Add(this.panel1);
            this.Name = "from6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.from6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.reportCosnult.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporInactiveEmployer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesPatient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ActivePatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl reportCosnult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView reportesPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ReporInactiveEmployer;
    }
}