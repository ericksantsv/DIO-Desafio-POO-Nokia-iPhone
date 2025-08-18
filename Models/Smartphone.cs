namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public int Memoria { get; set; }
        public int Espaco { get; set; }

        public Smartphone(string numero, string modelo, int memoria, int espaco)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            Espaco = espaco;
            // TODO: Passar os parâmetros do construtor para as propriedades
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