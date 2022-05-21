namespace BancoCSharp.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Titular titular) : base(titular)
        {
        }

        public ContaCorrente(Titular titular, double saldoAbertura) : base(titular, saldoAbertura)
        {
        }

        public override void imprimirExtrato()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("***************** Extrato Conta Corrente *****************");
            Console.WriteLine("**********************************************************");
            Console.WriteLine();

            Console.WriteLine("Gerado em: " + DateTime.Now);
            Console.WriteLine();
            foreach (var movimentacao in Movimentacoes)
            {
                Console.WriteLine(movimentacao.ToString());
            }
            Console.WriteLine("Saldo atual: R$" + Saldo);
            Console.WriteLine();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("********************* Fim do extrato *********************");
            Console.WriteLine("**********************************************************");
            Console.WriteLine();
        }
    }
}