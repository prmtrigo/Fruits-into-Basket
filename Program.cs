namespace Fruits_into_Basket;
class Program
{
    public int TotaldeFrutas(int[] frutas){

        //retornando a exceção
        int tamanho = frutas.Length;

        if(tamanho == 0){

            Console.WriteLine("Não há frutas para serem carregadas!");
            return 0;
        }

        //definindo valores
        int[] contando = new int[tamanho];
        int maximo = 0;
        int maximoAtual = 0;
        int contagemDeTipos = 0;
        int inicio = 0;

        for(int i=0; i< tamanho; i++){
            if(contando[frutas[i]] == 0){
                contagemDeTipos ++;
            }

            contando[frutas[i]]++;
            maximoAtual++;

            while(contagemDeTipos > 2 && inicio < i){
                contando[frutas[inicio]] --;

                if(contando[frutas[inicio]] == 0){
                    contagemDeTipos --;
                }
                inicio ++;
                maximoAtual --;
            }

            maximo = Math.Max(maximo, maximoAtual);
        }

        Console.WriteLine(maximo);
        return 0;
    }
    static void Main(string[] args)
    {
        Program p = new Program();

        int[] frutas = {0,1,2,2};

        p.TotaldeFrutas(frutas);
    }
}
