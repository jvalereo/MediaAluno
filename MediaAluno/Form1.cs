using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MediaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            //Treinamento - Calcule a nota media do aluno, tipo double
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis tipo double

            double portugues, matematica, ciencia, media;


            //Declarando entrada de dado no textbox

            portugues = double.Parse(textBoxPortugues.Text, CultureInfo.InvariantCulture);
            matematica = double.Parse(textBoxMatematica.Text, CultureInfo.InvariantCulture);
            ciencia = double.Parse(textBoxCiencia.Text, CultureInfo.InvariantCulture);


            //Declarando a variavel media dos alunos

            media = (portugues + matematica + ciencia) / 3;


            //imprimir saida de dados no MessagemBox, concatenação

            MessageBox.Show("A Media do aluno = " + media.ToString("F2", CultureInfo.InvariantCulture),
                "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


            //Declarando estrutura condicional composta if e else

            if (media > 7)
            {

                MessageBox.Show("Parabéns, Aluno Aprovado.", "Messagem");
                MessageBox.Show("Teste de novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                MessageBox.Show("Infelizmente, Aluno Reprovado.", "Messagem");
                MessageBox.Show("Teste de novo!!!", "Messagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando a codigo Limpar textbox , focus

            textBoxPortugues.Text = " ";
            textBoxMatematica.Text = " ";
            textBoxCiencia.Text = " ";
            textBoxPortugues.Focus();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Declarando o codigo sair da aplicação

            Close();
        }

        //Fim do programa

    }
}
