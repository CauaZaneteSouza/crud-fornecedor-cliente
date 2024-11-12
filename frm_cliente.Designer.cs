namespace crud_cliente_e_fornecedor
{
    partial class frm_cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdb_h = new System.Windows.Forms.RadioButton();
            this.rdb_m = new System.Windows.Forms.RadioButton();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.btn_cadastra = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.btn_exclui = new System.Windows.Forms.Button();
            this.btn_procura = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(95, 13);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(16, 79);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(712, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo";
            // 
            // rdb_h
            // 
            this.rdb_h.AutoSize = true;
            this.rdb_h.Location = new System.Drawing.Point(19, 163);
            this.rdb_h.Name = "rdb_h";
            this.rdb_h.Size = new System.Drawing.Size(73, 17);
            this.rdb_h.TabIndex = 5;
            this.rdb_h.TabStop = true;
            this.rdb_h.Text = "Masculino";
            this.rdb_h.UseVisualStyleBackColor = true;
            // 
            // rdb_m
            // 
            this.rdb_m.AutoSize = true;
            this.rdb_m.Location = new System.Drawing.Point(156, 163);
            this.rdb_m.Name = "rdb_m";
            this.rdb_m.Size = new System.Drawing.Size(67, 17);
            this.rdb_m.TabIndex = 6;
            this.rdb_m.TabStop = true;
            this.rdb_m.Text = "Feminino";
            this.rdb_m.UseVisualStyleBackColor = true;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(519, 163);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 20);
            this.txt_tel.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            // 
            // dtgCliente
            // 
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Location = new System.Drawing.Point(135, 210);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.Size = new System.Drawing.Size(532, 150);
            this.dtgCliente.TabIndex = 9;
            this.dtgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCliente_CellClick_1);
            // 
            // btn_cadastra
            // 
            this.btn_cadastra.Location = new System.Drawing.Point(113, 390);
            this.btn_cadastra.Name = "btn_cadastra";
            this.btn_cadastra.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastra.TabIndex = 10;
            this.btn_cadastra.Text = "Cadastrar";
            this.btn_cadastra.UseVisualStyleBackColor = true;
            this.btn_cadastra.Click += new System.EventHandler(this.btn_cadastra_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.Location = new System.Drawing.Point(256, 390);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(75, 23);
            this.btn_altera.TabIndex = 11;
            this.btn_altera.Text = "Alterar";
            this.btn_altera.UseVisualStyleBackColor = true;
            this.btn_altera.Click += new System.EventHandler(this.btn_altera_Click);
            // 
            // btn_exclui
            // 
            this.btn_exclui.Location = new System.Drawing.Point(383, 390);
            this.btn_exclui.Name = "btn_exclui";
            this.btn_exclui.Size = new System.Drawing.Size(75, 23);
            this.btn_exclui.TabIndex = 12;
            this.btn_exclui.Text = "Excluir";
            this.btn_exclui.UseVisualStyleBackColor = true;
            this.btn_exclui.Click += new System.EventHandler(this.btn_exclui_Click);
            // 
            // btn_procura
            // 
            this.btn_procura.Location = new System.Drawing.Point(519, 390);
            this.btn_procura.Name = "btn_procura";
            this.btn_procura.Size = new System.Drawing.Size(75, 23);
            this.btn_procura.TabIndex = 13;
            this.btn_procura.Text = "Procura";
            this.btn_procura.UseVisualStyleBackColor = true;
            this.btn_procura.Click += new System.EventHandler(this.btn_procura_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(631, 390);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_procura);
            this.Controls.Add(this.btn_exclui);
            this.Controls.Add(this.btn_altera);
            this.Controls.Add(this.btn_cadastra);
            this.Controls.Add(this.dtgCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.rdb_m);
            this.Controls.Add(this.rdb_h);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.label1);
            this.Name = "frm_cliente";
            this.Text = "frm_cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdb_h;
        private System.Windows.Forms.RadioButton rdb_m;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Button btn_cadastra;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.Button btn_exclui;
        private System.Windows.Forms.Button btn_procura;
        private System.Windows.Forms.Button btn_sair;
    }
}