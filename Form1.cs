using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BingoMaster
{
    public partial class Form1 : Form
    {
        //Lista que armazena os número que ainda não foram sorteados
        private List<int> globoDeNumero = new List<int>();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ConfigurarNovoJogo();
        }

        private void ConfigurarNovoJogo()
        {
            globoDeNumero.Clear();
            for (int i = 1; i <= 75; i++)
            {
                globoDeNumero.Add(i);
            }

            lsthistorico.Items.Clear();
            lblNumeroGrande.Text = "--";
            btnSortear.Enabled = true;
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {
            if (globoDeNumero.Count > 0)
            {
                //1.Escolhe um índice aleatório dentro do que sobrou na lista
                int indiceSorteado = random.Next(globoDeNumero.Count);

                //2.Pega o número que está naquele ídice
                int numeroSorteado = globoDeNumero[indiceSorteado];

                //3 Atualiza a tela 
                lblNumeroGrande.Text = numeroSorteado.ToString("D2");
                lsthistorico.Items.Insert(0, $"Nº{numeroSorteado}"); //insere no topo da lista

                //4 REMOVE o número da lisata para ele não ser sorteado de novo

                globoDeNumero.RemoveAt(indiceSorteado);
            }
            else
            {
                btnSortear.Enabled = false;
                MessageBox.Show("Fim do Bingo todos os 75 números foram sorteados.");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ConfigurarNovoJogo();
        }

    }
}
