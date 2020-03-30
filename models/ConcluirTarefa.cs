using System;
using System.Collections.Generic;
using System.Linq;
    public class ConcluirTarefa
    {
    

        public void ConcluirUmaTarefa(List<Tarefas> lista)
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

            bool v = lista.Remove
            ( 
                new Tarefas()
            { 
                valorId = valor, 
                tema = nome
            });

        
    
            
            
        }

    }

    
               
            

        


