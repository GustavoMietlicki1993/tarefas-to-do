using System;
using System.Collections.Generic;
using System.Linq;

    public class CriarTarefa
    {
          
        public List<Tarefas> AddTarefa(List<Tarefas> tarefa)
        {
            Console.Clear();
            Console.WriteLine("***********************************");

            Console.WriteLine("Digite o ID da tarefa: ");

            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da tarefa: ");

            string nome = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Operação realizada com sucesso.");
            Console.WriteLine("");
            Console.WriteLine("****************************************");

            tarefa.Add
            ( 
                new Tarefas()
            { 
                valorId = valor, 
                tema = nome
            }
            );
            
            return tarefa;

        }
        


        
    }



