using Controllers;
using Models;
using System;

namespace Views{

    public class ProdutoUpdate : Form{

        public Label lblidproduto;
        public TextBox txtidproduto;
        public Label lblmarca;
        public TextBox txtmarca;
        public Label lblcategoria;
        public TextBox txtcategoria;
        public Button btCadtProduto;

        public ProdutoModels produto;

        private void btCadt_Click(object sender, EventArgs e){
            ProdutoModels produtoToEdit = this.produto;
        }
    }
}
