using System;

namespace Orientacao.Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            PagamentoBoleto pag = new PagamentoBoleto();

            pag.Valor = 120.12;
            pag.Vencimento = new DateTime(2023, 05, 15);
            pag.Descricao = "Pagamento da SAAE";
            pag.BancoAgencia = "1342";
            pag.BancoPagador = "ITAU";

            
            Console.WriteLine(pag.BancoAgencia);
            Console.WriteLine(pag.BancoPagador);
            Console.WriteLine(pag.Descricao);
            Console.WriteLine(pag.Vencimento);
            Console.WriteLine(pag.Valor);


            Console.WriteLine("");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");

            PagamentoCartao pagamentoCartao = new PagamentoCartao();

            pagamentoCartao.Descricao = "Pagamento Elektro";
            pagamentoCartao.Vencimento = new DateTime(2023, 05, 15);
            pagamentoCartao.Valor = 245.34;
            pagamentoCartao.Numero = 02984921849812384;
            pagamentoCartao.Operadora = "VISA";
            pagamentoCartao.Validade = "12/28";

            Console.WriteLine(pagamentoCartao.Descricao);
            Console.WriteLine(pagamentoCartao.Vencimento.ToString());
            Console.WriteLine(pagamentoCartao.Valor);
            Console.WriteLine(pagamentoCartao.Numero);
            Console.WriteLine(pagamentoCartao.Operadora);
            Console.WriteLine(pagamentoCartao.Validade);
        }

        public class Pagamento
        {
            public double? Valor;
            public string? Descricao;
            public DateTime? Vencimento;
        }

        public class PagamentoCartao : Pagamento
        {
            public double Numero;
            public string Operadora;
            public string Validade;
        }

        public class PagamentoBoleto : Pagamento
        {
            public string BancoPagador;
            public string BancoAgencia;
        }

        public class PagamentoPix : Pagamento
        {
            public string ChavePix;
        }
    }
}
