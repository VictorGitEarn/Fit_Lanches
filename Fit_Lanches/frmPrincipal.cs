using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Fit_Lanches
{
    public partial class frmPrincipal : Form
    {
        //Variáveis Globais
        public int durProcess1; //Guardar tempo do 1 preparo
        public int durProcess2; //Guardar tempo do 2 preparo
        public int prp_Count = 0; //Preparos

        //Variáveis para carregar o TXT para o cardápio
        List<string> nomes = new List<string>();
        List<int> precos = new List<int>();
        List<int> tempos = new List<int>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblAtual.Text = "Dia e Hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //Botão para mandar o pedido para cozinha
        private void btnPrep_Click(object sender, EventArgs e)
        {
            //Verifica se tem nome.
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Favor entrar com um nome");
                btnPrep.Enabled = false;
            }
            else
            {
                //Verificar se a cozinha está cheia, caso estiver 02, adicionar pedido para lista de espera
                if (prp_Count == 2)
                {
                    ListViewItem itmEspera = new ListViewItem(txtNome.Text);
                    itmEspera.SubItems.Add(listItem.SelectedItems[0].Text);
                    itmEspera.SubItems.Add(listItem.SelectedItems[0].SubItems[2].Text);
                    listEspera.Items.Add(itmEspera);
                }
                else
                {
                    //Verifica se a lista de espera está vazia antes de lançar um pedido para a cozinha
                    if (listEspera.Items.Count == 0)
                    {
                        prepComum();
                        prp_Count++;
                    }
                }
                //Reseta ambiente de pedido
                txtNome.Text = "";
                txtNome.Focus();
                btnPrep.Enabled = false;
            }
        }

        /*Proceso dos contadores (preparação), assim que pedido for finalizado,
         * será feito a verificação se tem item na espera e envia 
         * o item pronto para a lista de entrega.*/
        private void tmrProcess_Tick(object sender, EventArgs e)
        {
            durProcess1--;
            lblCount1.Text = "Tempo (Seg): " + durProcess1;
            picPrep11.Visible = true;
            picPrep12.Visible = false;
            //Quando o pedido ficar pronto na cozinha, preparo 1...
            if (durProcess1 == 0)
            {
                picPrep11.Visible = false;
                picPrep12.Visible = true;
                prp_Count--;
                tmrProcess.Stop();
                //Preenche a retirada
                ListViewItem itemlista = new ListViewItem(lblPrepNome1.Text);
                itemlista.SubItems.Add(lblPrepITem1.Text);
                listEntrega.Items.Add(itemlista);
                //Limpa o preparo
                finaliza(lblPrepNome1, lblPrepITem1);
                //Metodo para puxar se tiver um item em espera
                if (listEspera.Items.Count > 0)
                {
                    puxEspera();
                    listEspera.Items.Remove(listEspera.Items[0]);
                    prp_Count++;
                }
            }
        }

        private void tmrProcess2_Tick(object sender, EventArgs e)
        {
            durProcess2--;
            lblCount2.Text = "Tempo (Seg): " + durProcess2;
            picPrep21.Visible = true;
            picPrep22.Visible = false;
            //Quando o pedido ficar pronto na cozinha, preparo 2...
            if (durProcess2 == 0)
            {
                picPrep21.Visible = false;
                picPrep22.Visible = true;
                prp_Count--;
                tmrProcess2.Stop();
                //Preenche a retirada
                ListViewItem itemlista = new ListViewItem(lblPrepNome2.Text);
                itemlista.SubItems.Add(lblPrepITem2.Text);
                listEntrega.Items.Add(itemlista);

                //Limpa o preparo
                finaliza(lblPrepNome2, lblPrepITem2);
                //Metodo para puxar se tiver um item em espera
                if (listEspera.Items.Count > 0)
                {
                    puxEspera();
                    listEspera.Items.Remove(listEspera.Items[0]);
                    prp_Count++;
                }
            }
        }

        //Habilita o botão para preparar, somente se tiver um item selecionado.
        private void listItem_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnPrep.Enabled = true;
        }

        //Métodos

        //Lança um pedido para a Cozinha puxando informações direto do cardápio.
        public void prepComum()
        {
            /*Verificar o contador se a cozinha está vazia ou com algum item sendo preparado, 
             * se já tiver um item sendo preparado mas no preparo 02, 
             * foi colocado o ou para o preparo 01 não ficar esperando o contador ficar menor que 01.*/
            if (prp_Count < 1 || prp_Count == 1 && tmrProcess2.Enabled == true)
            {
                durProcess1 = Convert.ToInt32(listItem.SelectedItems[0].SubItems[2].Text);
                lblPrepNome1.Text = txtNome.Text;
                lblPrepITem1.Text = listItem.SelectedItems[0].Text;
                tmrProcess.Enabled = true;
                lblPrepITem1.Visible = true;
                lblPrepNome1.Visible = true;
                tmrProcess.Start();
            }
            //Passará para o preparo 02, se o preparo 01 estiver ocupado.
            else
            {
                durProcess2 = Convert.ToInt32(listItem.SelectedItems[0].SubItems[2].Text);
                lblPrepNome2.Text = txtNome.Text;
                lblPrepITem2.Text = listItem.SelectedItems[0].Text;
                tmrProcess2.Enabled = true;
                lblPrepITem2.Visible = true;
                lblPrepNome2.Visible = true;
                tmrProcess2.Start();
            }
        }

        //Esvaziar a lista de espera e lançar o pedido na cozinha, mesma lógica somente alterando a listview
        public void puxEspera()
        {
            if (prp_Count < 1 || prp_Count == 1 && tmrProcess2.Enabled == true)
            {
                durProcess1 = Convert.ToInt32(listEspera.Items[0].SubItems[2].Text);
                lblPrepNome1.Text = listEspera.Items[0].Text;
                lblPrepITem1.Text = listEspera.Items[0].SubItems[1].Text;
                tmrProcess.Enabled = true;
                lblPrepITem1.Visible = true;
                lblPrepNome1.Visible = true;
                tmrProcess.Start();
            }
            else
            {
                durProcess2 = Convert.ToInt32(listEspera.Items[0].SubItems[2].Text);
                lblPrepNome2.Text = listEspera.Items[0].Text;
                lblPrepITem2.Text = listEspera.Items[0].SubItems[1].Text;
                tmrProcess2.Enabled = true;
                lblPrepITem2.Visible = true;
                lblPrepNome2.Visible = true;
                tmrProcess2.Start();
            }
        }
        
        // Método para limpar os preparos
        void finaliza(Label nome, Label item)
        {
            nome.Visible = false;
            item.Visible = false;

        }
        
        //Carregar txt com o cardápio
        private void btnLoadCard_Click(object sender, EventArgs e)
        {
            carregTxt();
        }

        //Botão de entrega
        private void btnEntreg_Click(object sender, EventArgs e)
        {
            //Verificar item selecionado e alterar o item para entregue, alterando a Font e cor de background
            ListViewItem item = listEntrega.SelectedItems[0];
            if (item.Font.Bold)
            {
                listEntrega.SelectedItems[0].Font = new Font(listEntrega.Font, FontStyle.Regular);
                listEntrega.SelectedItems[0].BackColor = Color.Green;
            }
        }

        //carregar Txt
        public void carregTxt()
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Carregar Cardapio | *.txt";
            abrir.ShowDialog();
            if (string.IsNullOrEmpty(abrir.FileName) == false)
            {
                using (StreamReader reader = new StreamReader(abrir.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string linha = reader.ReadLine();
                        //Separa os dados das colunas com o |
                        string[] valores = linha.Split('|');

                        nomes.Add(valores[0]);
                        precos.Add(int.Parse(valores[1]));
                        tempos.Add(int.Parse(valores[2]));
                    }
                }
                //Preencher o listview com os dados do txt
                for (int i = 0; i < nomes.Count; i++)
                {
                    ListViewItem itemLista = new ListViewItem(nomes[i]);
                    itemLista.SubItems.Add(precos[i].ToString());
                    itemLista.SubItems.Add(tempos[i].ToString());
                    listItem.Items.Add(itemLista);
                }
            }
        }
    }
}
