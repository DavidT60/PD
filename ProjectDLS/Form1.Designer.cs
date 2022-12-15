
namespace ProjectDLS
{
    partial class Form1
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
        ///         private System.Windows.Forms.Panel panel1;


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaveApp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.emailinput = new System.Windows.Forms.TextBox();
            this.active = new System.Windows.Forms.Panel();
            this.ActionsActive = new System.Windows.Forms.Label();
            this.CancelPss = new System.Windows.Forms.Button();
            this.indicator = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SendRequest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.active.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.leaveApp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.B);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 450);
            this.panel1.TabIndex = 0;
            // 
            // leaveApp
            // 
            this.leaveApp.BackColor = System.Drawing.Color.Black;
            this.leaveApp.ForeColor = System.Drawing.Color.White;
            this.leaveApp.Location = new System.Drawing.Point(0, 0);
            this.leaveApp.Name = "leaveApp";
            this.leaveApp.Size = new System.Drawing.Size(60, 26);
            this.leaveApp.TabIndex = 24;
            this.leaveApp.Text = "<- 🚪";
            this.leaveApp.UseVisualStyleBackColor = false;
            this.leaveApp.Click += new System.EventHandler(this.leaveApp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "2022";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "copyright©️ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servicio Dentista";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B.ForeColor = System.Drawing.Color.White;
            this.B.Location = new System.Drawing.Point(45, 214);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(157, 31);
            this.B.TabIndex = 2;
            this.B.Text = "Bienvenido ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ProjectDLS.Properties.Resources.dentist_icon_with_png_and_vector_format_for_free_unlimited_696507;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // emailinput
            // 
            this.emailinput.Location = new System.Drawing.Point(80, 214);
            this.emailinput.Name = "emailinput";
            this.emailinput.Size = new System.Drawing.Size(190, 20);
            this.emailinput.TabIndex = 10;
            this.emailinput.TextChanged += new System.EventHandler(this.emailinput_TextChanged);
            // 
            // active
            // 
            this.active.BackColor = System.Drawing.Color.White;
            this.active.Controls.Add(this.ActionsActive);
            this.active.Controls.Add(this.CancelPss);
            this.active.Controls.Add(this.indicator);
            this.active.Controls.Add(this.panel2);
            this.active.Controls.Add(this.SendRequest);
            this.active.Controls.Add(this.label6);
            this.active.Controls.Add(this.password);
            this.active.Controls.Add(this.label2);
            this.active.Controls.Add(this.pictureBox2);
            this.active.Controls.Add(this.emailinput);
            this.active.Dock = System.Windows.Forms.DockStyle.Fill;
            this.active.Location = new System.Drawing.Point(257, 0);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(543, 450);
            this.active.TabIndex = 15;
            // 
            // ActionsActive
            // 
            this.ActionsActive.AutoSize = true;
            this.ActionsActive.ForeColor = System.Drawing.Color.White;
            this.ActionsActive.Location = new System.Drawing.Point(6, 416);
            this.ActionsActive.Name = "ActionsActive";
            this.ActionsActive.Size = new System.Drawing.Size(35, 13);
            this.ActionsActive.TabIndex = 23;
            this.ActionsActive.Text = "label5";
            // 
            // CancelPss
            // 
            this.CancelPss.BackColor = System.Drawing.Color.Red;
            this.CancelPss.ForeColor = System.Drawing.Color.White;
            this.CancelPss.Location = new System.Drawing.Point(79, 359);
            this.CancelPss.Name = "CancelPss";
            this.CancelPss.Size = new System.Drawing.Size(80, 38);
            this.CancelPss.TabIndex = 22;
            this.CancelPss.Text = "x";
            this.CancelPss.UseVisualStyleBackColor = false;
            this.CancelPss.Click += new System.EventHandler(this.CancelPss_Click);
            // 
            // indicator
            // 
            this.indicator.AutoSize = true;
            this.indicator.Location = new System.Drawing.Point(159, 188);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(0, 13);
            this.indicator.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(363, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 450);
            this.panel2.TabIndex = 19;
            // 
            // SendRequest
            // 
            this.SendRequest.Location = new System.Drawing.Point(202, 359);
            this.SendRequest.Name = "SendRequest";
            this.SendRequest.Size = new System.Drawing.Size(83, 38);
            this.SendRequest.TabIndex = 18;
            this.SendRequest.Text = "Acceder";
            this.SendRequest.UseVisualStyleBackColor = true;
            this.SendRequest.Click += new System.EventHandler(this.SendRequest_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Clave de Acceso";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(80, 286);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(190, 20);
            this.password.TabIndex = 15;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Email";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjectDLS.Properties.Resources.e4b72ecbb7c98f492629cbeee66435e8;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(100, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.active);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.active.ResumeLayout(false);
            this.active.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox emailinput;
        private System.Windows.Forms.Panel active;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendRequest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label indicator;
        private System.Windows.Forms.Button CancelPss;
        private System.Windows.Forms.Label ActionsActive;
        private System.Windows.Forms.Button leaveApp;
    }
}

