using System;

class Veiculo {// classe base
    public int velMax;
    public bool ligado;
    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {
        ligado = false;
    }
}

class Carro: Veiculo {// classe derivada
    public string nome;
    public string cor;
    public int rodas;
    public Carro(string nome, string cor){
        desligar();
        rodas = 4;
        portas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }

    public string getLigado(){
        if(ligado){
            return "ligado";
        } else{
            return "desligado";
        }
    }

    public int portas;
    public void abrirPorta()
    {
        if (ligado)
        {
            Console.WriteLine("Abrindo porta");
        }
        else
        {
            Console.WriteLine("O carro está desligado");
        }
    }
}
class Aula34 {

    static void Main(string[] args) {
        Carro c1= new Carro("Mustang", "Vermelho");

        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Rodas: {0}", c1.rodas);
        Console.WriteLine("Portas: {0}", c1.portas);
        Console.WriteLine("Velocidade máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado());
    }
}