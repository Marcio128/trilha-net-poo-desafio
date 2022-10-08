namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            IMEI = imei;
        }

        private string modelo;
        private string numero;
        private string imei;
        private int memoria;
        public string Modelo 
        {
             get => modelo; 
             private set
             {
                if(Modelo==null)
                {
                    modelo = value;
                }
                else
                {
                    throw new Exception("O Telefone já possui um modelo e não pode ser alterado");
                }
             }
        }
        public string IMEI 
        {
             get => imei; 
             private set
             {
                if(IMEI==null)
                {
                    imei = value;
                }
                else
                {
                    throw new Exception("O Telefone já possui um IMEI e não pode ser alterado");
                }
             }
        }
        
        public int Memoria
        {
             get => memoria; 
             private set
             {
                if(Memoria==0)
                {
                    memoria = value;
                }
                else
                {
                    throw new Exception("O Telefone já possui Memoria e não pode ser alterado");
                }
             }
        }
        public string Numero 
        { 
            get => numero; 

            set => numero = value;
        }


        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}