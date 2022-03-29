using System;

class Veiculo {// classe base
    public int velMax;
    public bool ligado;
    private int rodas;

    public Veiculo(int rodas) {
        this.rodas = rodas;
    }
    public void ligar()
    {
        ligado = true;
    }
    public void desligar()
    {
        ligado = false;
    }
    public int getRodas(){
        return rodas;
    }
    public void setRodas(int rodas){
        if(rodas < 0){
            this.rodas = 0;
        }if(rodas>40){
            this.rodas = 40;
        }else{
            this.rodas = rodas;
        }
        
    }
}

class Carro: Veiculo {// classe derivada
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){
        desligar();
        portas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }

    public string getLigado(){
        return(ligado?"ligado":"desligado");
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

class CarroCombate: Carro {
    public int municao;
    public CarroCombate(string nome, string cor):base(nome, cor){
        portas = 2;
        velMax = 200;
        municao = 100;
        setRodas(6);
    }
}

class Aula34 {

    static void Main(string[] args) {
        Carro c1= new Carro("Mustang", "Vermelho");
        CarroCombate c2 = new CarroCombate("Fusca", "Preto");


        c1.ligar();

        Console.WriteLine("Nome: {0}", c1.nome);
        Console.WriteLine("Cor: {0}", c1.cor);
        Console.WriteLine("Rodas: {0}", c1.getRodas());
        Console.WriteLine("Portas: {0}", c1.portas);
        Console.WriteLine("Velocidade máxima: {0}", c1.velMax);
        Console.WriteLine("Ligado: {0}", c1.getLigado());

        Console.WriteLine("-----------------------");

        Console.WriteLine("Nome: {0}", c2.nome);
        Console.WriteLine("Cor: {0}", c2.cor);
        Console.WriteLine("Rodas: {0}", c2.getRodas());
        Console.WriteLine("Portas: {0}", c2.portas);
        Console.WriteLine("Velocidade máxima: {0}", c2.velMax);
        Console.WriteLine("Ligado: {0}", c2.getLigado());
        Console.WriteLine("Municao: {0}", c2.municao);
    }
}