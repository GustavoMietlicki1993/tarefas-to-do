using System;
using System.Collections.Generic;
using System.Linq;



public class MenuInicial
{
    public static List<Tarefas> listaDetarefas = new List<Tarefas>( );

    public void ComecarMenuInicial()
    {
        
        Console.WriteLine("**************************************************************");
        Console.WriteLine("Para criar uma tarefa digite 1");
        Console.WriteLine("Para concluir uma tarefa digite 2");
        Console.WriteLine("Para vizualizar todas as tarefas digite 3");
        Console.WriteLine("");
        Console.WriteLine("**************************************************************");

        int resultadoMenu = int.Parse(Console.ReadLine());

        CriarTarefa criarTarefa = new CriarTarefa();
         switch (resultadoMenu)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Opção selecionada : CRIAR UMA TAREFA");
                    listaDetarefas = criarTarefa.AddTarefa(listaDetarefas);
                    ComecarMenuInicial();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Opção selecionada : CONCLUIR UMA TAREFA");
                    ConcluirTarefa b = new ConcluirTarefa();
                    b.ConcluirUmaTarefa(listaDetarefas);                    
                    ComecarMenuInicial();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Opção selecionada : VIZUALIZAR TODAS AS TAREFAS");
                    ComecarMenuInicial();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Valor invalido");
                    ComecarMenuInicial();
                    break;
                    
            }

    }

}

    



