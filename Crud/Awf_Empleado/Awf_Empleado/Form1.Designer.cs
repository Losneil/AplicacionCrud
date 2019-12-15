namespace Awf_Empleado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtLASTNAME = new System.Windows.Forms.TextBox();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtSALARY = new System.Windows.Forms.TextBox();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCONSULT = new System.Windows.Forms.Button();
            this.btnUPDATE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVaciar = new System.Windows.Forms.Button();
            this.dvgEmpleado = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(63, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(63, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(63, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(63, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(66, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtID.Location = new System.Drawing.Point(176, 78);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 24);
            this.txtID.TabIndex = 5;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // txtNAME
            // 
            this.txtNAME.BackColor = System.Drawing.SystemColors.Window;
            this.txtNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNAME.Location = new System.Drawing.Point(176, 108);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(138, 24);
            this.txtNAME.TabIndex = 6;
            this.txtNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNAME_KeyPress);
            // 
            // txtLASTNAME
            // 
            this.txtLASTNAME.BackColor = System.Drawing.SystemColors.Window;
            this.txtLASTNAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLASTNAME.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLASTNAME.Location = new System.Drawing.Point(176, 138);
            this.txtLASTNAME.Name = "txtLASTNAME";
            this.txtLASTNAME.Size = new System.Drawing.Size(138, 24);
            this.txtLASTNAME.TabIndex = 7;
            this.txtLASTNAME.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLASTNAME_KeyPress);
            // 
            // txtPHONE
            // 
            this.txtPHONE.BackColor = System.Drawing.SystemColors.Window;
            this.txtPHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHONE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPHONE.Location = new System.Drawing.Point(176, 168);
            this.txtPHONE.MaxLength = 10;
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(138, 24);
            this.txtPHONE.TabIndex = 8;
            this.txtPHONE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPHONE_KeyPress);
            // 
            // txtSALARY
            // 
            this.txtSALARY.BackColor = System.Drawing.SystemColors.Window;
            this.txtSALARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALARY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSALARY.Location = new System.Drawing.Point(176, 197);
            this.txtSALARY.MaxLength = 5;
            this.txtSALARY.Name = "txtSALARY";
            this.txtSALARY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSALARY.Size = new System.Drawing.Size(138, 24);
            this.txtSALARY.TabIndex = 9;
            this.txtSALARY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSALARY_KeyPress);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.Blue;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSAVE.Location = new System.Drawing.Point(69, 248);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(87, 33);
            this.btnSAVE.TabIndex = 10;
            this.btnSAVE.Text = "Guardar";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnCONSULT
            // 
            this.btnCONSULT.BackColor = System.Drawing.Color.Blue;
            this.btnCONSULT.FlatAppearance.BorderSize = 0;
            this.btnCONSULT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCONSULT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCONSULT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCONSULT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCONSULT.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCONSULT.Location = new System.Drawing.Point(162, 248);
            this.btnCONSULT.Name = "btnCONSULT";
            this.btnCONSULT.Size = new System.Drawing.Size(93, 33);
            this.btnCONSULT.TabIndex = 11;
            this.btnCONSULT.Text = "Consultar";
            this.btnCONSULT.UseVisualStyleBackColor = false;
            this.btnCONSULT.Click += new System.EventHandler(this.btnCONSULT_Click);
            // 
            // btnUPDATE
            // 
            this.btnUPDATE.BackColor = System.Drawing.Color.Blue;
            this.btnUPDATE.FlatAppearance.BorderSize = 0;
            this.btnUPDATE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUPDATE.ForeColor = System.Drawing.SystemColors.Window;
            this.btnUPDATE.Location = new System.Drawing.Point(261, 248);
            this.btnUPDATE.Name = "btnUPDATE";
            this.btnUPDATE.Size = new System.Drawing.Size(95, 33);
            this.btnUPDATE.TabIndex = 12;
            this.btnUPDATE.Text = "Modificar";
            this.btnUPDATE.UseVisualStyleBackColor = false;
            this.btnUPDATE.Click += new System.EventHandler(this.btnUPDATE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.Blue;
            this.btnDELETE.FlatAppearance.BorderSize = 0;
            this.btnDELETE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDELETE.Location = new System.Drawing.Point(362, 248);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(83, 33);
            this.btnDELETE.TabIndex = 13;
            this.btnDELETE.Text = "Eliminar";
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Navy;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(62, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Datos del empleado";
            // 
            // btnVaciar
            // 
            this.btnVaciar.BackColor = System.Drawing.Color.Blue;
            this.btnVaciar.FlatAppearance.BorderSize = 0;
            this.btnVaciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVaciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVaciar.Location = new System.Drawing.Point(451, 248);
            this.btnVaciar.Name = "btnVaciar";
            this.btnVaciar.Size = new System.Drawing.Size(63, 33);
            this.btnVaciar.TabIndex = 15;
            this.btnVaciar.Text = "Vaciar";
            this.btnVaciar.UseVisualStyleBackColor = false;
            this.btnVaciar.Click += new System.EventHandler(this.btnVaciar_Click);
            // 
            // dvgEmpleado
            // 
            this.dvgEmpleado.AllowUserToAddRows = false;
            this.dvgEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgEmpleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgEmpleado.EnableHeadersVisualStyles = false;
            this.dvgEmpleado.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dvgEmpleado.Location = new System.Drawing.Point(69, 350);
            this.dvgEmpleado.Name = "dvgEmpleado";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgEmpleado.Size = new System.Drawing.Size(445, 160);
            this.dvgEmpleado.TabIndex = 16;
            this.dvgEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEmpleado_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(65, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Empleados registrados";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.BackColor = System.Drawing.SystemColors.Window;
            this.cmbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpleado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(362, 303);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(152, 23);
            this.cmbEmpleado.TabIndex = 18;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Navy;
            this.lblHora.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Cyan;
            this.lblHora.Location = new System.Drawing.Point(358, 182);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 22);
            this.lblHora.TabIndex = 19;
            this.lblHora.Text = "label8";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Navy;
            this.lblFecha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Lime;
            this.lblFecha.Location = new System.Drawing.Point(320, 203);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(50, 18);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "label8";
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Awf_Empleado.Properties.Resources.OnePay;
            this.pictureBox1.Location = new System.Drawing.Point(323, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(579, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dvgEmpleado);
            this.Controls.Add(this.btnVaciar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnUPDATE);
            this.Controls.Add(this.btnCONSULT);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.txtSALARY);
            this.Controls.Add(this.txtPHONE);
            this.Controls.Add(this.txtLASTNAME);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Empleados";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtLASTNAME;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtSALARY;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnCONSULT;
        private System.Windows.Forms.Button btnUPDATE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVaciar;
        private System.Windows.Forms.DataGridView dvgEmpleado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer FechaHora;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

