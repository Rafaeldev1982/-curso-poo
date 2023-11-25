namespace CursoPOO
{
    public class CarrinhoItem
    {
        private string _nome;
        private int _quantidade;
        private decimal _preco;

        public string Nome
        { 
            get { return _nome; }   
            set { _nome = value; }
        }

        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }  
}
