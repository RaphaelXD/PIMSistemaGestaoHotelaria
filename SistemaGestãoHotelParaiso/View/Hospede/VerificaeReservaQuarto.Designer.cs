
namespace SistemaGestãoHotelParaiso.View.Hospede
{
    partial class VerificaeReservaQuarto
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
            this.reserva_hospedagemDataGridView = new System.Windows.Forms.DataGridView();
            this.id_res_hospedagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserva_hospedagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_SGHPDataSet = new SistemaGestãoHotelParaiso.BD_SGHPDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NumBoxValorApart = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.CBNumApartamento = new System.Windows.Forms.ComboBox();
            this.apartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DTPDataSaida = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DTPDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TxtIDPessoa = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtIDReserva = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.tipo_apartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.reserva_hospedagemTableAdapter = new SistemaGestãoHotelParaiso.BD_SGHPDataSetTableAdapters.reserva_hospedagemTableAdapter();
            this.tableAdapterManager = new SistemaGestãoHotelParaiso.BD_SGHPDataSetTableAdapters.TableAdapterManager();
            this.apartamentoTableAdapter = new SistemaGestãoHotelParaiso.BD_SGHPDataSetTableAdapters.apartamentoTableAdapter();
            this.apartamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKreservahidap49C3F6B7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_SGHPDataSet1 = new SistemaGestãoHotelParaiso.BD_SGHPDataSet();
            this.reservahospedagemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_apartamentoTableAdapter = new SistemaGestãoHotelParaiso.BD_SGHPDataSetTableAdapters.tipo_apartamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SGHPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumBoxValorApart)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoBindingSource)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_apartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKreservahidap49C3F6B7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SGHPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservahospedagemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reserva_hospedagemDataGridView
            // 
            this.reserva_hospedagemDataGridView.AutoGenerateColumns = false;
            this.reserva_hospedagemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reserva_hospedagemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_res_hospedagem,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7,
            this.dat_entrada,
            this.dat_saida,
            this.dataGridViewTextBoxColumn9});
            this.reserva_hospedagemDataGridView.DataSource = this.reserva_hospedagemBindingSource;
            this.reserva_hospedagemDataGridView.Location = new System.Drawing.Point(7, 143);
            this.reserva_hospedagemDataGridView.Name = "reserva_hospedagemDataGridView";
            this.reserva_hospedagemDataGridView.Size = new System.Drawing.Size(662, 220);
            this.reserva_hospedagemDataGridView.TabIndex = 1;
            // 
            // id_res_hospedagem
            // 
            this.id_res_hospedagem.DataPropertyName = "id_res_hospedagem";
            this.id_res_hospedagem.HeaderText = "ID da Reserva";
            this.id_res_hospedagem.Name = "id_res_hospedagem";
            this.id_res_hospedagem.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_apartamento_num";
            this.dataGridViewTextBoxColumn10.HeaderText = "Apartamento";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "val_total";
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor diaria";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dat_entrada
            // 
            this.dat_entrada.DataPropertyName = "dat_entrada";
            this.dat_entrada.HeaderText = "Data inicio da reserva";
            this.dat_entrada.Name = "dat_entrada";
            // 
            // dat_saida
            // 
            this.dat_saida.DataPropertyName = "dat_saida";
            this.dat_saida.HeaderText = "Data final da reserva";
            this.dat_saida.Name = "dat_saida";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "sta_apartamento";
            this.dataGridViewTextBoxColumn9.HeaderText = "Status";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // reserva_hospedagemBindingSource
            // 
            this.reserva_hospedagemBindingSource.DataMember = "reserva_hospedagem";
            this.reserva_hospedagemBindingSource.DataSource = this.bD_SGHPDataSet;
            // 
            // bD_SGHPDataSet
            // 
            this.bD_SGHPDataSet.DataSetName = "BD_SGHPDataSet";
            this.bD_SGHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DTPFim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DTPInicio);
            this.groupBox1.Controls.Add(this.BtnConsultar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(494, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data de reservas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Até:";
            // 
            // DTPFim
            // 
            this.DTPFim.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPFim.Location = new System.Drawing.Point(49, 64);
            this.DTPFim.Name = "DTPFim";
            this.DTPFim.Size = new System.Drawing.Size(319, 22);
            this.DTPFim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "De:";
            // 
            // DTPInicio
            // 
            this.DTPInicio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPInicio.Location = new System.Drawing.Point(49, 26);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(319, 22);
            this.DTPInicio.TabIndex = 4;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.Location = new System.Drawing.Point(397, 44);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(83, 31);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.reserva_hospedagemDataGridView);
            this.groupBox2.Controls.Add(this.BtnVoltar);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 372);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar disponibilidade do Quarto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox10);
            this.groupBox3.Controls.Add(this.groupBox9);
            this.groupBox3.Controls.Add(this.groupBox8);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.BtnConfirm);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 255);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fazer reserva";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.CBStatus);
            this.groupBox10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(24, 185);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(127, 56);
            this.groupBox10.TabIndex = 35;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Status do Quarto";
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
            this.CBStatus.Location = new System.Drawing.Point(6, 25);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(63, 24);
            this.CBStatus.TabIndex = 27;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.NumBoxValorApart);
            this.groupBox9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(504, 108);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(137, 56);
            this.groupBox9.TabIndex = 34;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Valor da reserva";
            // 
            // NumBoxValorApart
            // 
            this.NumBoxValorApart.Location = new System.Drawing.Point(6, 24);
            this.NumBoxValorApart.Name = "NumBoxValorApart";
            this.NumBoxValorApart.Size = new System.Drawing.Size(120, 22);
            this.NumBoxValorApart.TabIndex = 32;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.CBNumApartamento);
            this.groupBox8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(24, 108);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(127, 56);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Numero do quarto";
            // 
            // CBNumApartamento
            // 
            this.CBNumApartamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reserva_hospedagemBindingSource, "id_apartamento_num", true));
            this.CBNumApartamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reserva_hospedagemBindingSource, "id_apartamento_num", true));
            this.CBNumApartamento.DataSource = this.apartamentoBindingSource;
            this.CBNumApartamento.DisplayMember = "id_apartamento_num";
            this.CBNumApartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNumApartamento.FormattingEnabled = true;
            this.CBNumApartamento.Location = new System.Drawing.Point(6, 25);
            this.CBNumApartamento.Name = "CBNumApartamento";
            this.CBNumApartamento.Size = new System.Drawing.Size(93, 24);
            this.CBNumApartamento.TabIndex = 28;
            this.CBNumApartamento.ValueMember = "id_tipo_apartamento";
            // 
            // apartamentoBindingSource
            // 
            this.apartamentoBindingSource.DataMember = "apartamento";
            this.apartamentoBindingSource.DataSource = this.bD_SGHPDataSet;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DTPDataSaida);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(185, 187);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(293, 56);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Data de saida";
            // 
            // DTPDataSaida
            // 
            this.DTPDataSaida.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reserva_hospedagemBindingSource, "dat_saida", true));
            this.DTPDataSaida.Location = new System.Drawing.Point(8, 25);
            this.DTPDataSaida.Name = "DTPDataSaida";
            this.DTPDataSaida.Size = new System.Drawing.Size(275, 22);
            this.DTPDataSaida.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DTPDataEntrada);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(185, 108);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(293, 56);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Data de Entrada";
            // 
            // DTPDataEntrada
            // 
            this.DTPDataEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reserva_hospedagemBindingSource, "dat_entrada", true));
            this.DTPDataEntrada.Location = new System.Drawing.Point(6, 25);
            this.DTPDataEntrada.Name = "DTPDataEntrada";
            this.DTPDataEntrada.Size = new System.Drawing.Size(277, 22);
            this.DTPDataEntrada.TabIndex = 12;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TxtIDPessoa);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(179, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 56);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ID do hospede";
            // 
            // TxtIDPessoa
            // 
            this.TxtIDPessoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reserva_hospedagemBindingSource, "id_pessoa", true));
            this.TxtIDPessoa.Location = new System.Drawing.Point(6, 24);
            this.TxtIDPessoa.Name = "TxtIDPessoa";
            this.TxtIDPessoa.Size = new System.Drawing.Size(85, 22);
            this.TxtIDPessoa.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtIDReserva);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 56);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ID da Reserva";
            // 
            // TxtIDReserva
            // 
            this.TxtIDReserva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reserva_hospedagemBindingSource, "id_res_hospedagem", true));
            this.TxtIDReserva.Enabled = false;
            this.TxtIDReserva.Location = new System.Drawing.Point(6, 25);
            this.TxtIDReserva.Name = "TxtIDReserva";
            this.TxtIDReserva.Size = new System.Drawing.Size(81, 22);
            this.TxtIDReserva.TabIndex = 8;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.Location = new System.Drawing.Point(644, 197);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(87, 37);
            this.BtnConfirm.TabIndex = 29;
            this.BtnConfirm.Text = "Confirma";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // tipo_apartamentoBindingSource
            // 
            this.tipo_apartamentoBindingSource.DataMember = "tipo_apartamento";
            this.tipo_apartamentoBindingSource.DataSource = this.bD_SGHPDataSet;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(549, 83);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(92, 30);
            this.BtnVoltar.TabIndex = 30;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnCancel_Click);
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
            // apartamentoTableAdapter
            // 
            this.apartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // apartamentoBindingSource1
            // 
            this.apartamentoBindingSource1.DataMember = "apartamento";
            this.apartamentoBindingSource1.DataSource = this.bD_SGHPDataSet;
            // 
            // fKreservahidap49C3F6B7BindingSource
            // 
            this.fKreservahidap49C3F6B7BindingSource.DataMember = "FK__reserva_h__id_ap__49C3F6B7";
            this.fKreservahidap49C3F6B7BindingSource.DataSource = this.apartamentoBindingSource;
            // 
            // bD_SGHPDataSet1
            // 
            this.bD_SGHPDataSet1.DataSetName = "BD_SGHPDataSet";
            this.bD_SGHPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservahospedagemBindingSource
            // 
            this.reservahospedagemBindingSource.DataMember = "reserva_hospedagem";
            this.reservahospedagemBindingSource.DataSource = this.bD_SGHPDataSet1;
            // 
            // tipo_apartamentoTableAdapter
            // 
            this.tipo_apartamentoTableAdapter.ClearBeforeFill = true;
            // 
            // VerificaeReservaQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 678);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "VerificaeReservaQuarto";
            this.ShowIcon = false;
            this.Text = "Lista de Reservas";
            this.Load += new System.EventHandler(this.escolha_quarto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserva_hospedagemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SGHPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumBoxValorApart)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoBindingSource)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_apartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKreservahidap49C3F6B7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_SGHPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservahospedagemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BD_SGHPDataSet bD_SGHPDataSet;
        private System.Windows.Forms.BindingSource reserva_hospedagemBindingSource;
        private BD_SGHPDataSetTableAdapters.reserva_hospedagemTableAdapter reserva_hospedagemTableAdapter;
        private BD_SGHPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView reserva_hospedagemDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTPFim;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtIDReserva;
        private System.Windows.Forms.TextBox TxtIDPessoa;
        private System.Windows.Forms.DateTimePicker DTPDataEntrada;
        private System.Windows.Forms.DateTimePicker DTPDataSaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_res_hospedagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.BindingSource apartamentoBindingSource;
        private BD_SGHPDataSetTableAdapters.apartamentoTableAdapter apartamentoTableAdapter;
        private System.Windows.Forms.ComboBox CBNumApartamento;
        private System.Windows.Forms.BindingSource fKreservahidap49C3F6B7BindingSource;
        private System.Windows.Forms.BindingSource apartamentoBindingSource1;
        private BD_SGHPDataSet bD_SGHPDataSet1;
        private System.Windows.Forms.BindingSource reservahospedagemBindingSource;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.BindingSource tipo_apartamentoBindingSource;
        private BD_SGHPDataSetTableAdapters.tipo_apartamentoTableAdapter tipo_apartamentoTableAdapter;
        private System.Windows.Forms.NumericUpDown NumBoxValorApart;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}