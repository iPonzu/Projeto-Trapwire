using Models;
using MyData;

namespace Controllers{
    public class EstoqueController{
        public static void Create(string nome, string endereco){
            if(nome == null || nome.Length == 0 || endereco == null || endereco.Length == 0){
                throw new Exception("Estoque não encontrado");
            }
            new EstoqueModels(nome, endereco);
        }
        public static void Update(string nome, string endereco){
            // int id = 0;
            // try{
            //     id = int.Parse(idRef);
            // } catch (Exception e){
            //     throw new Exception("ID inválido.");
            // }
            // EstoqueModels estoque = EstoqueModels.ReadById(id);
            // if(estoque == null){
            //     throw new Exception("Estoque inválido.");
            // }
            // if(nome != null && nome.Length > 0 || endereco != null && endereco.Length > 0){
            //     estoque.Nome = nome;
            //     estoque.Endereco = endereco;
            // }
            // EstoqueModels.Update(estoque);
            using (var context = new Context()){
                var estoque = context.Estoques.FirstOrDefault(e => e.Nome == nome);
                if(estoque != null){
                    estoque.Nome = nome;
                    estoque.Endereco = endereco;
                    context.Estoques.Update(estoque);
                    context.SaveChanges();
                }
            }
        }
        public static void Delete(string idRef, string nome){
            using (var context = new Context()){
                var estoque = context.Estoques.FirstOrDefault(e => e.Nome == nome);
                if(estoque != null){
                    context.Estoques.Remove(estoque);
                    context.SaveChanges();
                }
            }
        }
        
        public static List<EstoqueModels> Read(){
            return EstoqueModels.Read();
        }
        public static EstoqueModels ReadById(int id){
            return EstoqueModels.ReadById(id);
        }

    }

}