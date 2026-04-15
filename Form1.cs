namespace BingoMaster
{
    public partial class Form1 : Form
    {
        //Lista que armazena os número que ainda não foram sorteados
        private List<int>globoDeNumero= new List<int>();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
