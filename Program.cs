using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CriptografiaCesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabeto = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '@', '&', '$' }; //coloquei mais 3 caracteres para servir como caracter criptografico de x, y, z.
            //chave de criptografia +3.
            Console.WriteLine("Escreva uma mensagem para criptografar:");
            string mensagem = Console.ReadLine().ToLower();
            char[] descrip = mensagem.ToCharArray();
            char[] crip = new char[descrip.Length];
            for (int i = 0; i < descrip.Length; i++)
            {
                for (int j = 0; j <= 25; j++)
                {
                    if (descrip[i] == ' ') crip[i] = '0';
                    else if (descrip[i] == '.') crip[i] = '.';
                    else if (descrip[i] == ',') crip[i] = ',';
                    else if (descrip[i] == '!') crip[i] = '!';
                    else if (descrip[i] == '?') crip[i] = '?';
                    else if (descrip[i] == '-') crip[i] = '-';
                    else if (descrip[i] == alfabeto[j])
                    {
                        crip[i] = alfabeto[j+3];
                    }
                }
            }
            string mensagemCrip = new string(crip);
            Console.WriteLine("Mensagem criptografada: " + mensagemCrip);
            Console.WriteLine("Escreva a mensagem que quer descriptografar:");
            mensagem = Console.ReadLine().ToLower();
            char[] mensagDescrip = mensagem.ToCharArray();
            for (int i = 0; i < mensagDescrip.Length; i++)
            {
                for (int j = 0; j <= 28; j++)
                {
                    if (crip[i] == '0') mensagDescrip[i] = ' ';
                    else if (crip[i] == '.') mensagDescrip[i] = '.';
                    else if (crip[i] == ',') mensagDescrip[i] = ',';
                    else if (crip[i] == '!') mensagDescrip[i] = '!';
                    else if (crip[i] == '?') mensagDescrip[i] = '?';
                    else if (crip[i] == '-') mensagDescrip[i] = '-';
                    else if (crip[i] == alfabeto[j])
                    {
                        mensagDescrip[i] = alfabeto[j - 3];
                    }
                }
            }
            string mensagemDescriptografada = new string(mensagDescrip);
            Console.WriteLine("Mensagem descriptografada: " + mensagemDescriptografada);


            Console.ReadKey();
        }
    }
}
