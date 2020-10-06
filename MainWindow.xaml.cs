using Domain.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Questao1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produto> _produtos;

        public ObservableCollection<Produto> Produtos
        {
            get { return _produtos; }
            set { _produtos = value; }
        }
        private Produto _sproduto;

        public Produto SProduto
        {
            get { return _sproduto; }
            set { _sproduto = value; }
        }
        public MainWindow()
        {
            Produtos = new ObservableCollection<Produto>{
            {new Produto{ Codigo = 121,Descricao = "Café",Preco = 7.00} },
            {new Produto{ Codigo = 122,Descricao = "Capuccino",Preco = 12.00} },
            {new Produto{ Codigo = 123,Descricao = "Nescafé",Preco = 9.00} },
            {new Produto{ Codigo = 124,Descricao = "Latte",Preco = 10.50} }
            };
            InitializeComponent();
            this.DataContext = this;
        }

       
        
        private void _SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var produto = sender as ComboBox;
            var mensagem = produto.SelectedItem.ToString();
            if(mensagem!=null)
                texto.Text = mensagem;
            else
                texto.Text = "Nada";

        }

    }
}
