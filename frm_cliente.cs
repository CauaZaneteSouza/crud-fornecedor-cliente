using MySqlX.XDevAPI;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_cliente_e_fornecedor
{
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }

      
            // Instância da classe de conexão com o banco de dados
            Conexao bd = new Conexao();
            // Constante para o nome da tabela do banco de dados, evitando modificação acidental
private const string TABELA = "Cliente";
        private void frmCliente_Load(object sender, EventArgs e)
        {
            // Carrega os dados da tabela ao iniciar o formulário
            ExibirDados();
        }
     
        private void ExibirDados()
        {
            // Comando SQL para selecionar todos os registros da tabela
            string dados = $"SELECT * FROM {TABELA}";
            // Obtém os dados do banco e exibe na grade de dados
            DataTable dt = bd.ExecutarConsulta(dados);
            dtgCliente.DataSource = dt.AsDataView();
        }
        private void LimpaCampos()
        {
            // Limpa os campos do formulário após uma operação de CRUD
            lbl_id.Text = "";
            txt_nome.Clear();
            txt_tel.Clear();
            rdb_m.Checked = false;
            rdb_h.Checked = false;
            txt_nome.Focus(); // Move o foco para o campo Nome
        }
 
        private void btn_cadastra_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            // Verifica se os campos obrigatórios estão preenchidos
            if (txt_nome.Text != "" && txt_tel.Text != "")
            {
                // Define os valores do cliente a partir dos campos do formulário
                cliente.SetNome(txt_nome.Text);
                cliente.SetTelefone(txt_tel.Text);
                cliente.SetSexo(rdb_h.Checked ? "M" : "F");
                // String de inserção SQL usando os dados do cliente
                string inserir = ($"INSERT INTO {TABELA} (nome, tel, sexo) VALUES('{cliente.GetNome()}', '{cliente.GetTelefone()}', '{cliente.GetSexo()}')");
                // Executa o comando de inserção no banco de dados
                bd.ExecutarComandos(inserir);
                // Atualiza a exibição dos dados e limpa os campos do formulário
                ExibirDados();
                LimpaCampos();
            }
            else
            {

                // Exibe mensagem caso algum campo esteja vazio
                MessageBox.Show("Informação Inválida!", "Confirmação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_altera_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            // Verifica se os campos obrigatórios estão preenchidos e se há um ID válido
            if (txt_nome.Text != "" && txt_tel.Text != "" && int.TryParse(lbl_id.Text, out int
            id))
            {
                // Define os valores do cliente a partir dos campos do formulário
                cliente.SetId(id);
                cliente.SetNome(txt_nome.Text);
                cliente.SetTelefone(txt_tel.Text);
                cliente.SetSexo(rdb_m.Checked ? "M" : "F");
                // String de atualização SQL
                string alterar = ($"UPDATE {TABELA} SET nome = '{cliente.GetNome()}', telefone = '{cliente.GetTelefone()}', sexo = '{cliente.GetSexo()}' WHERE id = {cliente.GetId()}");
                // Executa o comando de atualização
                int resultado = bd.ExecutarComandos(alterar);
                // Verifica o resultado e atualiza os dados
                if (resultado == 1)
                {
                    MessageBox.Show("Registro atualizado com sucesso!");
                    ExibirDados();
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!");
                }
            }
            else
            {
                MessageBox.Show("Informação Inválida!");
            }
        }

        private void btn_exclui_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            // Verifica se há um ID válido para exclusão
            if (int.TryParse(lbl_id.Text, out int id))
            {
                cliente.SetId(id);
                // String de exclusão SQL
                string excluir = $"DELETE FROM {TABELA} WHERE id = {cliente.GetId()}";
                // Executa o comando de exclusão
                int resultado = bd.ExecutarComandos(excluir);
                // Verifica o resultado e atualiza os dados
                if (resultado == 1)
                {
                    MessageBox.Show("Registro deletado com sucesso!");
                    ExibirDados();
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir!");
                }
            }
            else
            {
                MessageBox.Show("Informação Inválida!");
            }
        }

        private void btn_procura_Click(object sender, EventArgs e)
        {
            // Atualiza a exibição dos dados ao clicar em "Pesquisar"
            ExibirDados();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            // Fecha o formulário
            Close();
        }

        private void dtgCliente_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Cria uma instância de Cliente e preenche com os dados da linha selecionada na grade
            Cliente cliente = new Cliente();
            cliente.SetId(Convert.ToInt32(dtgCliente.Rows[e.RowIndex].Cells[0].Value));
            cliente.SetNome(dtgCliente.Rows[e.RowIndex].Cells[1].Value.ToString());
            cliente.SetTelefone(dtgCliente.Rows[e.RowIndex].Cells[2].Value.ToString());

            cliente.SetSexo(dtgCliente.Rows[e.RowIndex].Cells[3].Value.ToString());
            // Atualiza os campos do formulário com os dados do cliente
            lbl_id.Text = cliente.GetId().ToString();
            txt_nome.Text = cliente.GetNome();
            txt_tel.Text = cliente.GetTelefone();
            rdb_h.Checked = cliente.GetSexo() == "M";
            rdb_m.Checked = cliente.GetSexo() == "F";
        }
    }
}
