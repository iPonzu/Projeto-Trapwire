using Models;
using MyData;

namespace Controllers{
    public class MarcaController{
        public static void Create(string nome) {
            if (nome == null || nome.Length == 0){
                throw new Exception("Marca inválida");
            }
            new MarcaModels(nome);
        }

        public static void Update(string idRef, string nome){
            int id = 0;
            try{
                id = int.Parse(idRef);
            } catch (Exception e){
                throw new Exception("ID inválido");
            }
            MarcaModels marca = MarcaModels.ReadById(id);
            if (marca == null){
                throw new Exception("Marca inválida");
            }
            if(nome != null && nome.Length > 0){
                marca.Nome = nome;
            }

            MarcaModels.Update(marca);
        }
        public static void Delete(string idRef, string nome){  
            using (var context = new Context()){
                var marca = context.Marcas.FirstOrDefault(m => m.Nome == nome);
                if(marca != null){
                    context.Marcas.Remove(marca);
                    context.SaveChanges();
                }
            }

        }

        public static List<MarcaModels> Read(){
            return MarcaModels.Read();
        }
        public static MarcaModels ReadById(int id){
            return MarcaModels.ReadById(id);
        }
    }
}