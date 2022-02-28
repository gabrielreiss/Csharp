using System; 

class URI {

    static void Main(string[] args) { 

        //comentário
        /*
        outros comentarios
        */

        int data = 1942;
        string cor_favorita = "azul";
        float velocidadeF1 = 294.48f;
        bool verdadeiro = true;
        
        // constante só se define uma vez e o valor não pode ser alterado
        const float pi = 3.14f;

        Console.WriteLine(data);
        Console.WriteLine(cor_favorita);
        Console.WriteLine(velocidadeF1);
        Console.WriteLine(verdadeiro);
        Console.ReadLine();

        /*
        var cor_favorita = "Vermelho";
        var modeloDoProduto = 2323;

        //Menos desempenho
        dynamic cor_favorita = "Vermelho";
        cor_favorita = 123;
        Console.WriteLine(cor_favorita);
        */

    }

}