using System.Windows.Forms;

namespace GeradorDeInserts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregaCSV_Click(object sender, EventArgs e)
        {
            // abrir dialogo para selecionar o arquivo
            OpenFileDialog dialogCSV = new OpenFileDialog();
            dialogCSV.Filter = "Arquivos CSV (*.csv)|*.csv"; 
            dialogCSV.Title = "Selecione um CSV com os CODITES";
            dialogCSV.ShowDialog();
           

            //receber path do arquivo
            string pathCsv = dialogCSV.FileName;
            var comandosSql = new StringWriter();


            try
            {
                using (StreamReader reader = new StreamReader(pathCsv))
                {

                    string codemp = txtCodEmp.Text;
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        string[] valores = linha.Split(';');
                        string codite = valores[0];
                        string descricao = valores[1];
                        string dataAtual= DateTime.Now.ToString("yyyy-MM-dd");
                        string horaAtual= DateTime.Now.ToString("HH:mm:ss");
                        string insert = $"INSERT INTO HUBCIT_ANUNCI_CARGA (HUBCIT_CODITE, HUBCIT_CODSKU, HUBCIT_TIPPRE, HUBCIT_ESTFIX, HUBCIT_ENVEAN, HUBCIT_CODEMP, HUBCIT_ATUCOL, HUBCIT_FIXEST, HUBCIT_DTAENV, HUBCIT_HORENV) " +
                            $"VALUES ('{codite}', '{codite}', '', '0.00', '0', {codemp}, 'S', 'N', '{dataAtual}', '{horaAtual}');";
                        comandosSql.WriteLine(insert);
                    }
                    }
                }

            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler o arquivo: " + ex.Message);
            }

            finally
            {


                string pastaDestino = Path.GetDirectoryName(pathCsv);
                string nomeArquivo = Path.Combine(pastaDestino, "inserts.sql");
                File.WriteAllText(nomeArquivo, comandosSql.ToString());

                MessageBox.Show("Arquivo lido com sucesso!");
            }





        }
    }
}
