using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        char[,] tabuleiro = new char[3, 3];
        char jogadorAtual = 'X';
        bool jogoEmAndamento = true;



        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[0, 0] == ' ' && jogoEmAndamento)
            {
                tabuleiro[0, 0] = jogadorAtual;
                button1.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
                MarcarJogada(sender as Button);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[0, 1] == ' ' && jogoEmAndamento)
            {
                tabuleiro[0, 1] = jogadorAtual;
                button2.Text = jogadorAtual.ToString();
                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[0, 2] == ' ' && jogoEmAndamento)
            {
                tabuleiro[0, 2] = jogadorAtual;
                button3.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[1, 0] == ' ' && jogoEmAndamento)
            {
                tabuleiro[1, 0] = jogadorAtual;
                button4.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[1, 1] == ' ' && jogoEmAndamento)
            {
                tabuleiro[1, 1] = jogadorAtual;
                button5.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[1, 2] == ' ' && jogoEmAndamento)
            {
                tabuleiro[1, 2] = jogadorAtual;
                button6.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[2, 0] == ' ' && jogoEmAndamento)
            {
                tabuleiro[2, 0] = jogadorAtual;
                button7.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[2, 1] == ' ' && jogoEmAndamento)
            {
                tabuleiro[2, 1] = jogadorAtual;
                button8.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (tabuleiro[2, 2] == ' ' && jogoEmAndamento)
            {
                tabuleiro[2, 2] = jogadorAtual;
                button9.Text = jogadorAtual.ToString();

                char vencedor = VerificarVitoria();
                if (vencedor != ' ')
                {
                    label1.Text = $"Jogador {vencedor} venceu!";
                    jogoEmAndamento = false;
                }
                else if (VerificarEmpate())
                {
                    label1.Text = "Empate!";
                    jogoEmAndamento = false;
                }
                else
                {
                    jogadorAtual = jogadorAtual == 'X' ? 'O' : 'X';
                }
                AtualizarInterface();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ReiniciarJogo();
            label2.Text = " Pode fazer a primeira jogada";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        char VerificarVitoria()
        {
            // Verificar linhas, colunas e diagonais
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2] && tabuleiro[i, 0] != ' ')
                    return tabuleiro[i, 0];
                if (tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i] && tabuleiro[0, i] != ' ')
                    return tabuleiro[0, i];
            }
            if (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2] && tabuleiro[0, 0] != ' ')
                return tabuleiro[0, 0];
            if (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0] && tabuleiro[0, 2] != ' ')
                return tabuleiro[0, 2];
            return ' ';
        }
        private void ReiniciarJogo()
        {
            // Limpar tabuleiro, label e resetar variáveis
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = ' ';
                }
            }

            // Limpar os textos dos botões
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            label1.Text
 = "";
            jogadorAtual = 'X';
            jogoEmAndamento = true;
        }

        private bool VerificarEmpate()
        {
            // Verifica se todas as posições do tabuleiro estão ocupadas
            return tabuleiro.Cast<char>().All(c => c != ' ');
        }
        private void MarcarJogada(Button botao)
        {
            if (botao.Text != "" || !jogoEmAndamento)
            {
                return; // Botão já está marcado ou jogo encerrado
            }

            int linha = int.Parse(botao.Name.Substring(6, 1)) - 1; // Obtém a linha do botão
            int coluna = int.Parse(botao.Name.Substring(7, 1)) - 1; // Obtém a coluna do botão

            tabuleiro[linha, coluna] = jogadorAtual;
            botao.Text = jogadorAtual.ToString();

            // ... (restante do código)
        }
        private bool VerificarLinha(int linha)
        {
            // Verifica se uma linha está completa
            return tabuleiro[linha, 0] == tabuleiro[linha, 1] && tabuleiro[linha, 1] == tabuleiro[linha, 2] && tabuleiro[linha, 0] != ' ';
        }

        // Funções similares para verificar coluna e diagonais



        private void AtualizarInterface()
        {
            // Atualiza os textos dos botões de acordo com o tabuleiro
            button1.Text = tabuleiro[0, 0].ToString();
            // ... (atualizar os outros botões)
        }
               private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ReiniciarJogo();
            label1.Text = "";
       

        }
    }
}
