using System;
using System.Collections.Generic;
using System.Linq;

public class TarefasArmazenadas
{
    MenuInicial d = new MenuInicial();
    public void imprimirTdTarefas(List<Tarefas> lista)
        {
            Console.WriteLine("Relação de todas as tarefas: \n");
            foreach(var i in lista)
            {
                Console.WriteLine("****************************************** \n");
                Console.WriteLine($"ID da tarefa: {i.valorId}");
                Console.WriteLine($"Nome da tarefa: {i.tema}");
                Console.WriteLine(" ***************************************** ");
            
            }
            Console.WriteLine("Digite 1 para voltar ao menu inicial. ");
            int resposta = int.Parse(Console.ReadLine());

            if(resposta == 1)
            {
                d.ComecarMenuInicial();
            }
            else 
            {
                Console.WriteLine("Resposta invalida. ");
            }
            
        }
}






