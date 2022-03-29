//aulas 28 a 30

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFBcursos
{
    class Program
    {
        public class Jogador{
            public int energia;
            public bool vivo = true;
            public string nome;
            //metodo construtor mesmo nome da classe
            public Jogador(){
                nome = "Jogador";
                energia = 100;
                vivo = true;
            }
            public Jogador(string n){
                nome = n;
                energia = 100;
                vivo = true;
            }
            public Jogador(string n, int e){
                nome = n;
                energia = e;
                vivo = true;
            }
            public Jogador(string n, int e, bool v){
                nome = n;
                energia = e;
                vivo = v;
            }        
            //metodo destrutor
            ~Jogador(){
                Console.WriteLine("Jogador {0} foi destruido", nome);
            }
            public void info(){
                Console.WriteLine("Nome do jogador {0}", nome);
                Console.WriteLine("Energia do jogador {0}", energia);
                Console.WriteLine("Status do jogador {0}\n", vivo);
            }
        }
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Joao");
            Jogador j3 = new Jogador("Carlos", 70);
            Jogador j4 = new Jogador("Demetrio", 30, true);

            j1.info();
            j2.info();
            j3.info();
            j4.info();

            Console.ReadLine();
        }
    }
}