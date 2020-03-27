using System;
using System.Collections.Generic;
using System.Linq;



    public class CriarTarefa
    {

        public static int idDaTarefa = 0;
        public string nomeDaTarefa = "";
         
        public List<CriarTarefa> addTarefa(List<CriarTarefa> ListaTarefas){
            
            Console.Clear();
            Console.WriteLine("Digite o ID da tarefa: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome da tarefa: ");
            string nome = Console.ReadLine();

            ListaTarefas.Add(new Tarefas{
                idDaTarefa = id,
                nomeDaTarefa = nome,
            
            });

            return ListaTarefas;
        }
    }


//  public void getTarefas(List<Tarefas> Lista){
            
//             // var resultado = Lista.Where(x => x.idTarefa != 0).ToList();

//             foreach (var item in Lista)
//             {   
//                 Console.Write($"ID da tarefa: {item.idTarefa}\t|\t");
//                 Console.Write($"Nome da tarefa: {item.nomeTarefa}\t|\t");
//                 if(item.statusTarefa){
//                     Console.WriteLine($"Status da tarefa: Concluida\t|\t");
//                 }else{
//                     Console.WriteLine($"Status da tarefa: Não concluida\t\t");
//                 }
//                 Console.WriteLine($"------------------------------------------------------------------------------");
//             }

//         }