
namespace SistemaGestãoHotelParaiso.View.Hospede
{
    partial class CheckINCheckOut
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
            this.components = new System.ComponentModel.Container();
            this.bD_SGHPDataSet = new SistemaGestãoHotelParaiso.BD_SGHPDataSet();
            this.reserva_hospedagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserva_hospedagemTableAdapter = new SistemaGestãoHotelParaiso.BD_SGHPDataSetTableAdapters.reserva_hospedagemTableAdapter();
            this.tableAdapterManager = new SistemaGestãoHotelParaiso.BD_SGHPDataSetTableAdapters.TableAdapterManager();
            this.reserva_hospedagemDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnCheckOUT = new System.Windows.Forms.Button();
            this.BtnCheckIN = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.TxtValorTotal = new System.Windows.Forms.NumericUpDown();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.DTPCheckOUT = new System.Windows.Forms.DateTimePicker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.DTPCheckIN = new System.Windows.Forms.DateTimePicker();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DTPSaida = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtIDHospede = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtIDReserva = new System.Windows.Forms.TextBox();
            this.apartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SGHPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValorTotal)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_SGHPDataSet
            // 
            this.bD_SGHPDataSet.DataSetName = "BD_SGHPDataSet";
            this.bD_SGHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reserva_hospedagemBindingSource
            // 
            this.reserva_hospedagemBindingSource.DataMember = "reserva_hospedagem";
            this.reserva_hospedagemBindingSource.DataSource = this.bD_SGHPDataSet;
            // 
            // reserva_hospedagemTableAdapter
            // 
            this.reserva_hospedagemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.apartamentoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.funcionarioTableAdapter = null;
            this.tableAdapterManager.hospedesTableAdapter = null;
            this.tableAdapterManager.pessoaTableAdapter = null;
            this.tableAdapterManager.reserva_hospedagemTableAdapter = this.reserva_hospedagemTableAdapter;
            this.tableAdapterManager.tipo_apartamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaGestãoHotelParaiso.BD_SGHPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // reserva_hospedagemDataGridView
            // 
            this.reserva_hospedagemDataGridView.AutoGenerateColumns = false;
            this.reserva_hospedagemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserva_hospedagemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.reserva_hospedagemDataGridView.DataSource = this.reserva_hospedagemBindingSource;
            this.reserva_hospedagemDataGridView.Location = new System.Drawing.Point(24, 109);
            this.reserva_hospedagemDataGridView.Name = "reserva_hospedagemDataGridView";
            this.reserva_hospedagemDataGridView.Size = new System.Drawing.Size(852, 220);
            this.reserva_hospedagemDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_res_hospedagem";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Reserva";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_pessoa";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id Hospede";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "dat_entrada";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data de Reserva";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dat_saida";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data de Saida";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dat_checkin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data Check-IN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dat_checkout";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data Check-Out";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "val_total";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor ";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "var_acrescimo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Valor Total";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "sta_apartamento";
            this.dataGridViewTextBoxColumn9.HeaderText = "Status Apartamento";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_apartamento_num";
            this.dataGridViewTextBoxColumn10.HeaderText = "Numero Apartamento";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConsulta);
            this.groupBox1.Controls.Add(this.TxtConsulta);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(249, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar ID da Reserva";
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.Location = new System.Drawing.Point(242, 22);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(88, 32);
            this.BtnConsulta.TabIndex = 3;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(6, 25);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(202, 26);
            this.TxtConsulta.TabIndex = 3;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(646, 54);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCheckOUT);
            this.groupBox2.Controls.Add(this.BtnCheckIN);
            this.groupBox2.Controls.Add(this.groupBox11);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(68, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 261);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Reseva";
            // 
            // BtnCheckOUT
            // 
            this.BtnCheckOUT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckOUT.Location = new System.Drawing.Point(566, 198);
            this.BtnCheckOUT.Name = "BtnCheckOUT";
            this.BtnCheckOUT.Size = new System.Drawing.Size(107, 42);
            this.BtnCheckOUT.TabIndex = 30;
            this.BtnCheckOUT.Text = "Confirmar Check-OUT";
            this.BtnCheckOUT.UseVisualStyleBackColor = true;
            this.BtnCheckOUT.Click += new System.EventHandler(this.BtnCheckOUT_Click);
            // 
            // BtnCheckIN
            // 
            this.BtnCheckIN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckIN.Location = new System.Drawing.Point(400, 199);
            this.BtnCheckIN.Name = "BtnCheckIN";
            this.BtnCheckIN.Size = new System.Drawing.Size(107, 42);
            this.BtnCheckIN.TabIndex = 29;
            this.BtnCheckIN.Text = "Confirmar Check-IN";
            this.BtnCheckIN.UseVisualStyleBackColor = true;
            this.BtnCheckIN.Click += new System.EventHandler(this.BtnCheckIN_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.TxtValorTotal);
            this.groupBox11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(378, 35);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(113, 48);
            this.groupBox11.TabIndex = 28;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Valor Total";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reserva_hospedagemBindingSource, "var_acrescimo", true));
            this.TxtValorTotal.Location = new System.Drawing.Point(6, 20);
            this.TxtValorTotal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(76, 22);
            this.TxtValorTotal.TabIndex = 19;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.DTPCheckOUT);
            this.groupBox9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(12, 143);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(281, 48);
            this.groupBox9.TabIndex = 25;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Check-OUT";
            // 
            // DTPCheckOUT
            // 
            this.DTPCheckOUT.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reserva_hospedagemBindingSource, "dat_checkout", true));
            this.DTPCheckOUT.Location = new System.Drawing.Point(6, 20);
            this.DTPCheckOUT.Name = "DTPCheckOUT";
            this.DTPCheckOUT.Size = new System.Drawing.Size(269, 22);
            this.DTPCheckOUT.TabIndex = 15;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.DTPCheckIN);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(12, 89);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(281, 48);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Check-IN";
            // 
            // DTPCheckIN
            // 
            this.DTPCheckIN.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reserva_hospedagemBindingSource, "dat_checkin", true));
            this.DTPCheckIN.Location = new System.Drawing.Point(6, 21);
            this.DTPCheckIN.Name = "DTPCheckIN";
            this.DTPCheckIN.Size = new System.Drawing.Size(269, 22);
            this.DTPCheckIN.TabIndex = 13;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DTPSaida);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(12, 198);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(281, 48);
            this.groupBox7.TabIndex = 25;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data de Saida";
            // 
            // DTPSaida
            // 
            this.DTPSaida.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reserva_hospedagemBindingSource, "dat_saida", true));
            this.DTPSaida.Location = new System.Drawing.Point(6, 21);
            this.DTPSaida.Name = "DTPSaida";
            this.DTPSaida.Size = new System.Drawing.Size(269, 22);
            this.DTPSaida.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CBStatus);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(378, 98);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(141, 48);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status Apartamento";
            // 
            // CBStatus
            // 
            this.CBStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reserva_hospedagemBindingSource, "sta_apartamento", true));
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "L",
            "I",
            "O",
            "R"});
            this.CBStatus.Location = new System.Drawing.Point(6, 18);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(76, 24);
            this.CBStatus.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtIDHospede);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(138, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 48);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ID Hospede";
            // 
            // TxtIDHospede
            // 
            this.TxtIDHospede.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reserva_hospedagemBindingSource, "id_pessoa", true));
            this.TxtIDHospede.Enabled = false;
            this.TxtIDHospede.Location = new System.Drawing.Point(6, 20);
            this.TxtIDHospede.Name = "TxtIDHospede";
            this.TxtIDHospede.Size = new System.Drawing.Size(76, 22);
            this.TxtIDHospede.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtIDReserva);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(101, 48);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ID Reserva";
            // 
            // TxtIDReserva
            // 
            this.TxtIDReserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reserva_hospedagemBindingSource, "id_res_hospedagem", true));
            this.TxtIDReserva.Location = new System.Drawing.Point(6, 21);
            this.TxtIDReserva.Name = "TxtIDReserva";
            this.TxtIDReserva.Size = new System.Drawing.Size(76, 22);
            this.TxtIDReserva.TabIndex = 5;
            // 
            // apartamentoBindingSource
            // 
            this.apartamentoBindingSource.DataMember = "apartamento";
            this.apartamentoBindingSource.DataSource = this.bD_SGHPDataSet;
            // 
            // CheckINCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reserva_hospedagemDataGridView);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CheckINCheckOut";
            this.ShowIcon = false;
            this.Text = "Tela de CheckIN e CheckOut";
            this.Load += new System.EventHandler(this.CheckINCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_SGHPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtValorTotal)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BD_SGHPDataSet bD_SGHPDataSet;
        private System.Windows.Forms.BindingSource reserva_hospedagemBindingSource;
        private BD_SGHPDataSetTableAdapters.reserva_hospedagemTableAdapter reserva_hospedagemTableAdapter;
        private BD_SGHPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView reserva_hospedagemDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtIDReserva;
        private System.Windows.Forms.TextBox TxtIDHospede;
        private System.Windows.Forms.DateTimePicker DTPSaida;
        private System.Windows.Forms.DateTimePicker DTPCheckIN;
        private System.Windows.Forms.DateTimePicker DTPCheckOUT;
        private System.Windows.Forms.NumericUpDown TxtValorTotal;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button BtnCheckOUT;
        private System.Windows.Forms.Button BtnCheckIN;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource apartamentoBindingSource;
    }
}