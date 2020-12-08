using System;

namespace POO_heranca
{
    class Program 
    {
        static void Main(string[] args)
        {
            //Instaciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();

            PessoaJuridica pj = new PessoaJuridica();
            
            Console.WriteLine("Este cadastro é pessoal ou empresarial? - p ou e");
            pf.pouf = Console.ReadLine();

            if(pf.pouf == "p"){
            
            //Atribímos um valor para a propiedade disponivel na superclasse
            Console.WriteLine("Digite seu nome");
            pf.nome = Console.ReadLine();
            
            Console.WriteLine("Digite seu CPF");
            pf.cpf = Console.ReadLine();

            //Mostramos no console o método de saudação da superclasse
            Console.WriteLine(pf.DarBoasVindas(pf.nome) );
            
            Console.WriteLine(pf.ValidarCPF(pf.cpf) );
            }
            else if(pf.pouf == "e"){
                Console.WriteLine("Digite o nome da empresa");
            pf.nome = Console.ReadLine();
            
            Console.WriteLine("Digite o CNPJ");
            pj.cnpj = Console.ReadLine();

            Console.WriteLine("Digite a inscrição estadual");
            pj.inscricaoEstadual = Console.ReadLine();

            Console.WriteLine(pf.DarBoasVindas(pf.nome) );
            
            Console.WriteLine(pf.ValidarCPF(pf.cpf) );

            }
            


            
            
        

        }
    }
}
                                                                                               