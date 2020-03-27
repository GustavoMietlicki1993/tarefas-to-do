using System;
using System.Collections.Generic;
using System.Linq;


public class Tarefas
{
    
    public CriarTarefa criarTarefa;
    public ConcluirTarefa concluirTarefa;
    public TarefasArmazenadas tarefasArmazenadas;

    

    public static void ImprimirOpcoes()
    {
        Console.WriteLine("Digite a opção desejada: ");
        Console.WriteLine("Opção 1 : Criar tarefa");
        Console.WriteLine("Opção 2 : Concluir tarefa");
        Console.WriteLine("Opção 3 : Entrar em uma tarefa");
    }
    public static void LerResposta()
    {
        Console.WriteLine("Digite a opção desejada: ");
        int opcao = Convert.ToInt32(Console.ReadLine());
    

        switch(opcao)
        {
            case 1:
                Console.WriteLine("Voce digitou a opção 1. ");
                CriarTarefa.CriaUmaTarefa();
                break;
            case 2:
                Console.WriteLine("Voce digitou a opção 2. ");
                ConcluirTarefa.ConcluiUmaTarefa();
                break;
            case 3:
                Console.WriteLine("Voce digitou a opção 3. ");

                break;
            default: 
                Console.WriteLine("Resposta incorreta. ");
                break;
        }
    
    }


}