using System;
using System.Windows.Forms;

namespace Empresa.Presentacion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnSalarioMN = new System.Windows.Forms.Button();
            this.btnSalarioMD = new System.Windows.Forms.Button();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.btnTotalE = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.lbSeguro = new System.Windows.Forms.Label();
            this.chkT = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.chkEmpV = new System.Windows.Forms.CheckBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkEmpD = new System.Windows.Forms.CheckBox();
            this.chkEmpN = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridEmpleadosD = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmpN = new System.Windows.Forms.Button();
            this.btnEliminarEmpD = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregarEmp = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.gridEmpleadosN = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVespertino = new System.Windows.Forms.Label();
            this.gridEmpleadosV = new System.Windows.Forms.DataGridView();
            this.btnEliminarEmpV = new System.Windows.Forms.Button();
            this.btnSalarioMV = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSalarioMT = new System.Windows.Forms.Button();
            this.gridEmpleadosT = new System.Windows.Forms.DataGridView();
            this.txtmotor = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lbmotor = new System.Windows.Forms.Label();
            this.lbplaca = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(408, 579);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(655, 59);
            this.txtInfo.TabIndex = 94;
            // 
            // btnGastos
            // 
            this.btnGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.Location = new System.Drawing.Point(12, 636);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(196, 23);
            this.btnGastos.TabIndex = 93;
            this.btnGastos.Text = "Gastos Generales";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click_1);
            // 
            // btnSalarioMN
            // 
            this.btnSalarioMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarioMN.Location = new System.Drawing.Point(214, 665);
            this.btnSalarioMN.Name = "btnSalarioMN";
            this.btnSalarioMN.Size = new System.Drawing.Size(177, 23);
            this.btnSalarioMN.TabIndex = 92;
            this.btnSalarioMN.Text = "Salario Mayor N";
            this.btnSalarioMN.UseVisualStyleBackColor = true;
            this.btnSalarioMN.Click += new System.EventHandler(this.btnSalarioMN_Click_1);
            // 
            // btnSalarioMD
            // 
            this.btnSalarioMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarioMD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalarioMD.Location = new System.Drawing.Point(214, 636);
            this.btnSalarioMD.Name = "btnSalarioMD";
            this.btnSalarioMD.Size = new System.Drawing.Size(177, 23);
            this.btnSalarioMD.TabIndex = 91;
            this.btnSalarioMD.Text = "Salario MayorD";
            this.btnSalarioMD.UseVisualStyleBackColor = true;
            this.btnSalarioMD.Click += new System.EventHandler(this.btnSalarioMD_Click_1);
            // 
            // btnPromedios
            // 
            this.btnPromedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedios.Location = new System.Drawing.Point(12, 602);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(196, 23);
            this.btnPromedios.TabIndex = 90;
            this.btnPromedios.Text = "PromGeneral Salarios";
            this.btnPromedios.UseVisualStyleBackColor = true;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromedios_Click_1);
            // 
            // btnTotalE
            // 
            this.btnTotalE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTotalE.Location = new System.Drawing.Point(12, 566);
            this.btnTotalE.Name = "btnTotalE";
            this.btnTotalE.Size = new System.Drawing.Size(196, 23);
            this.btnTotalE.TabIndex = 89;
            this.btnTotalE.Text = "Cantidad TotalEmp";
            this.btnTotalE.UseVisualStyleBackColor = true;
            this.btnTotalE.Click += new System.EventHandler(this.btnTotalE_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 694);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(196, 23);
            this.btnSalir.TabIndex = 88;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.txtmotor);
            this.panel1.Controls.Add(this.txtplaca);
            this.panel1.Controls.Add(this.lbmotor);
            this.panel1.Controls.Add(this.lbplaca);
            this.panel1.Controls.Add(this.txtSeguro);
            this.panel1.Controls.Add(this.lbSeguro);
            this.panel1.Controls.Add(this.chkT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCelular);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.lbCelular);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Controls.Add(this.chkEmpV);
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chkEmpD);
            this.panel1.Controls.Add(this.chkEmpN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 490);
            this.panel1.TabIndex = 80;
            this.panel1.Tag = "";
            // 
            // txtSeguro
            // 
            this.txtSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(164, 250);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSeguro.Size = new System.Drawing.Size(188, 26);
            this.txtSeguro.TabIndex = 69;
            // 
            // lbSeguro
            // 
            this.lbSeguro.AutoSize = true;
            this.lbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeguro.Location = new System.Drawing.Point(11, 254);
            this.lbSeguro.Name = "lbSeguro";
            this.lbSeguro.Size = new System.Drawing.Size(158, 18);
            this.lbSeguro.TabIndex = 68;
            this.lbSeguro.Text = "Caballlos de fuerza:";
            this.lbSeguro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkT
            // 
            this.chkT.AutoSize = true;
            this.chkT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkT.Location = new System.Drawing.Point(5, 345);
            this.chkT.Name = "chkT";
            this.chkT.Size = new System.Drawing.Size(172, 29);
            this.chkT.TabIndex = 67;
            this.chkT.Text = "Vehículo Mixto";
            this.chkT.UseVisualStyleBackColor = true;
            this.chkT.CheckStateChanged += new System.EventHandler(this.chkTemporal_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Color:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(164, 221);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCelular.Size = new System.Drawing.Size(188, 26);
            this.txtCelular.TabIndex = 65;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(162, 189);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCorreo.Size = new System.Drawing.Size(188, 26);
            this.txtCorreo.TabIndex = 64;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbCelular.Location = new System.Drawing.Point(11, 211);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(83, 29);
            this.lbCelular.TabIndex = 63;
            this.lbCelular.Text = "Serie:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbEmail.Location = new System.Drawing.Point(11, 182);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(65, 29);
            this.lbEmail.TabIndex = 62;
            this.lbEmail.Text = "Año:";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // chkEmpV
            // 
            this.chkEmpV.AutoSize = true;
            this.chkEmpV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpV.Location = new System.Drawing.Point(148, 455);
            this.chkEmpV.Name = "chkEmpV";
            this.chkEmpV.Size = new System.Drawing.Size(202, 29);
            this.chkEmpV.TabIndex = 61;
            this.chkEmpV.Text = "Vehículo Maritimo";
            this.chkEmpV.UseVisualStyleBackColor = true;
            this.chkEmpV.CheckedChanged += new System.EventHandler(this.ChkEmpV_CheckStateChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(164, 157);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSalario.Size = new System.Drawing.Size(188, 26);
            this.txtSalario.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(11, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "Velocidad:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(162, 96);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(189, 26);
            this.txtApellido2.TabIndex = 12;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(163, 126);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(188, 26);
            this.txtCedula.TabIndex = 10;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(162, 67);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(189, 26);
            this.txtApellido1.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(162, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(162, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(188, 26);
            this.txtID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // chkEmpD
            // 
            this.chkEmpD.AutoSize = true;
            this.chkEmpD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpD.Location = new System.Drawing.Point(132, 380);
            this.chkEmpD.Name = "chkEmpD";
            this.chkEmpD.Size = new System.Drawing.Size(177, 29);
            this.chkEmpD.TabIndex = 59;
            this.chkEmpD.Text = "Vehículo Aereo";
            this.chkEmpD.UseVisualStyleBackColor = true;
            this.chkEmpD.CheckedChanged += new System.EventHandler(this.chkEmpD_CheckedChanged);
            this.chkEmpD.CheckStateChanged += new System.EventHandler(this.ChkEmpD_CheckStateChanged);
            // 
            // chkEmpN
            // 
            this.chkEmpN.AutoSize = true;
            this.chkEmpN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmpN.Location = new System.Drawing.Point(5, 420);
            this.chkEmpN.Name = "chkEmpN";
            this.chkEmpN.Size = new System.Drawing.Size(207, 29);
            this.chkEmpN.TabIndex = 60;
            this.chkEmpN.Text = "Vehículo Terrestre";
            this.chkEmpN.UseVisualStyleBackColor = true;
            this.chkEmpN.CheckedChanged += new System.EventHandler(this.ChkEmpN_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdE:";
            // 
            // gridEmpleadosD
            // 
            this.gridEmpleadosD.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.gridEmpleadosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosD.Location = new System.Drawing.Point(408, 41);
            this.gridEmpleadosD.Name = "gridEmpleadosD";
            this.gridEmpleadosD.Size = new System.Drawing.Size(655, 91);
            this.gridEmpleadosD.TabIndex = 81;
            this.gridEmpleadosD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleadosD_CellContentClick);
            this.gridEmpleadosD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosD_RowHeaderMouseClick);
            // 
            // btnEliminarEmpN
            // 
            this.btnEliminarEmpN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpN.Location = new System.Drawing.Point(214, 566);
            this.btnEliminarEmpN.Name = "btnEliminarEmpN";
            this.btnEliminarEmpN.Size = new System.Drawing.Size(188, 23);
            this.btnEliminarEmpN.TabIndex = 86;
            this.btnEliminarEmpN.Text = "Eliminar Empleado Nocturno";
            this.btnEliminarEmpN.UseVisualStyleBackColor = true;
            this.btnEliminarEmpN.Click += new System.EventHandler(this.btnEliminarEmpN_Click_1);
            // 
            // btnEliminarEmpD
            // 
            this.btnEliminarEmpD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpD.Location = new System.Drawing.Point(214, 537);
            this.btnEliminarEmpD.Name = "btnEliminarEmpD";
            this.btnEliminarEmpD.Size = new System.Drawing.Size(188, 23);
            this.btnEliminarEmpD.TabIndex = 85;
            this.btnEliminarEmpD.Text = "Eliminar Empleado Diurno";
            this.btnEliminarEmpD.UseVisualStyleBackColor = true;
            this.btnEliminarEmpD.Click += new System.EventHandler(this.btnEliminarEmpD_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(12, 665);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(196, 23);
            this.btnBorrar.TabIndex = 84;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnAgregarEmp
            // 
            this.btnAgregarEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmp.Location = new System.Drawing.Point(12, 535);
            this.btnAgregarEmp.Name = "btnAgregarEmp";
            this.btnAgregarEmp.Size = new System.Drawing.Size(196, 23);
            this.btnAgregarEmp.TabIndex = 83;
            this.btnAgregarEmp.Text = "Agregar Empleado";
            this.btnAgregarEmp.UseVisualStyleBackColor = true;
            this.btnAgregarEmp.Click += new System.EventHandler(this.btnAgregarEmp_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Bisque;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(107, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 31);
            this.label20.TabIndex = 82;
            this.label20.Text = "Transporte";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // gridEmpleadosN
            // 
            this.gridEmpleadosN.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.gridEmpleadosN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosN.Location = new System.Drawing.Point(408, 167);
            this.gridEmpleadosN.Name = "gridEmpleadosN";
            this.gridEmpleadosN.Size = new System.Drawing.Size(655, 96);
            this.gridEmpleadosN.TabIndex = 79;
            this.gridEmpleadosN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEmpleadosN_CellContentClick);
            this.gridEmpleadosN.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosN_RowHeaderMouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Bisque;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(410, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(355, 31);
            this.label9.TabIndex = 78;
            this.label9.Text = "Lista Vehículos Terrestres";
            // 
            // txtTurno
            // 
            this.txtTurno.Enabled = false;
            this.txtTurno.Location = new System.Drawing.Point(408, 232);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(100, 20);
            this.txtTurno.TabIndex = 87;
            this.txtTurno.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Bisque;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(410, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(312, 31);
            this.label8.TabIndex = 77;
            this.label8.Text = "Lista Vehículos Aereos";
            // 
            // lbVespertino
            // 
            this.lbVespertino.AutoSize = true;
            this.lbVespertino.BackColor = System.Drawing.Color.Bisque;
            this.lbVespertino.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbVespertino.Location = new System.Drawing.Point(408, 282);
            this.lbVespertino.Name = "lbVespertino";
            this.lbVespertino.Size = new System.Drawing.Size(346, 31);
            this.lbVespertino.TabIndex = 95;
            this.lbVespertino.Text = "Lista Vehículos Maritimos";
            // 
            // gridEmpleadosV
            // 
            this.gridEmpleadosV.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.gridEmpleadosV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosV.Location = new System.Drawing.Point(408, 329);
            this.gridEmpleadosV.Name = "gridEmpleadosV";
            this.gridEmpleadosV.Size = new System.Drawing.Size(655, 96);
            this.gridEmpleadosV.TabIndex = 96;
            this.gridEmpleadosV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosV_RowHeaderMouseClick);
            // 
            // btnEliminarEmpV
            // 
            this.btnEliminarEmpV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEmpV.Location = new System.Drawing.Point(214, 602);
            this.btnEliminarEmpV.Name = "btnEliminarEmpV";
            this.btnEliminarEmpV.Size = new System.Drawing.Size(188, 23);
            this.btnEliminarEmpV.TabIndex = 97;
            this.btnEliminarEmpV.Text = "Eliminar Empleado Vespertino";
            this.btnEliminarEmpV.UseVisualStyleBackColor = true;
            this.btnEliminarEmpV.Click += new System.EventHandler(this.btnEliminarEmpV_Click);
            // 
            // btnSalarioMV
            // 
            this.btnSalarioMV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarioMV.Location = new System.Drawing.Point(214, 694);
            this.btnSalarioMV.Name = "btnSalarioMV";
            this.btnSalarioMV.Size = new System.Drawing.Size(177, 23);
            this.btnSalarioMV.TabIndex = 98;
            this.btnSalarioMV.Text = "Salario Mayor V";
            this.btnSalarioMV.UseVisualStyleBackColor = true;
            this.btnSalarioMV.Click += new System.EventHandler(this.btnSalarioMV_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Bisque;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(408, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 31);
            this.label6.TabIndex = 102;
            this.label6.Text = "Lista Vehículos Mixtos";
            // 
            // btnSalarioMT
            // 
            this.btnSalarioMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalarioMT.Location = new System.Drawing.Point(408, 644);
            this.btnSalarioMT.Name = "btnSalarioMT";
            this.btnSalarioMT.Size = new System.Drawing.Size(177, 23);
            this.btnSalarioMT.TabIndex = 104;
            this.btnSalarioMT.Text = "Salario Mayor T";
            this.btnSalarioMT.UseVisualStyleBackColor = true;
            this.btnSalarioMT.Click += new System.EventHandler(this.btnSalarioMT_Click);
            // 
            // gridEmpleadosT
            // 
            this.gridEmpleadosT.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.gridEmpleadosT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEmpleadosT.Location = new System.Drawing.Point(417, 469);
            this.gridEmpleadosT.Name = "gridEmpleadosT";
            this.gridEmpleadosT.Size = new System.Drawing.Size(645, 98);
            this.gridEmpleadosT.TabIndex = 105;
            this.gridEmpleadosT.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridEmpleadosT_RowHeaderMouseClick);
            // 
            // txtmotor
            // 
            this.txtmotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmotor.Location = new System.Drawing.Point(164, 309);
            this.txtmotor.Name = "txtmotor";
            this.txtmotor.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtmotor.Size = new System.Drawing.Size(188, 26);
            this.txtmotor.TabIndex = 73;
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplaca.Location = new System.Drawing.Point(162, 277);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtplaca.Size = new System.Drawing.Size(188, 26);
            this.txtplaca.TabIndex = 72;
            // 
            // lbmotor
            // 
            this.lbmotor.AutoSize = true;
            this.lbmotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbmotor.Location = new System.Drawing.Point(12, 300);
            this.lbmotor.Name = "lbmotor";
            this.lbmotor.Size = new System.Drawing.Size(87, 29);
            this.lbmotor.TabIndex = 71;
            this.lbmotor.Text = "Motor:";
            // 
            // lbplaca
            // 
            this.lbplaca.AutoSize = true;
            this.lbplaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lbplaca.Location = new System.Drawing.Point(10, 271);
            this.lbplaca.Name = "lbplaca";
            this.lbplaca.Size = new System.Drawing.Size(85, 29);
            this.lbplaca.TabIndex = 70;
            this.lbplaca.Text = "Placa:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 727);
            this.Controls.Add(this.gridEmpleadosT);
            this.Controls.Add(this.btnSalarioMT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalarioMV);
            this.Controls.Add(this.btnEliminarEmpV);
            this.Controls.Add(this.gridEmpleadosV);
            this.Controls.Add(this.lbVespertino);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnGastos);
            this.Controls.Add(this.btnSalarioMN);
            this.Controls.Add(this.btnSalarioMD);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.btnTotalE);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridEmpleadosD);
            this.Controls.Add(this.btnEliminarEmpN);
            this.Controls.Add(this.btnEliminarEmpD);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregarEmp);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.gridEmpleadosN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.label8);
            this.Name = "Menu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleadosT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnSalarioMN;
        private System.Windows.Forms.Button btnSalarioMD;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.Button btnTotalE;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkEmpD;
        private System.Windows.Forms.CheckBox chkEmpN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridEmpleadosD;
        private System.Windows.Forms.Button btnEliminarEmpN;
        private System.Windows.Forms.Button btnEliminarEmpD;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregarEmp;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView gridEmpleadosN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.CheckBox chkEmpV;
        private Label lbVespertino;
        private DataGridView gridEmpleadosV;
        private Button btnEliminarEmpV;
        private Button btnSalarioMV;
        private CheckBox chkT;
        private Label label5;
        private TextBox txtSeguro;
        private Label lbSeguro;
        private Label label6;
        private Button btnSalarioMT;
        private DataGridView gridEmpleadosT;
        private TextBox txtmotor;
        private TextBox txtplaca;
        private Label lbmotor;
        private Label lbplaca;
    }
}

