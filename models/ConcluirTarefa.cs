using System;
using System.Collections.Generic;
using System.Linq;


    public class ConcluirTarefa
    {
    

    public void ConcluirUmaTarefa(List<Tarefas> lista)
        {
            foreach (var i in lista)
            {
                Console.WriteLine("");
                Console.WriteLine($"ID da tarefa: {i.valorId}");
                Console.WriteLine($"Nome da tarefa: {i.tema}");
                Console.WriteLine(" ***************************************** ");
            }
            
        }

    }

    
               
            

        


