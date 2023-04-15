using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Classes;

namespace Venda.Iterativa.Model
{
    internal sealed class PedidoModel : AbstractModel
    {
        private ObservableCollection<ProdutoModel> _produtos
            = new ObservableCollection<ProdutoModel>();
        private decimal _total = 0.00m;
        private string _numCard;
        private int _cvv;
        private DateTime _date = DateTime.Now;        

        public ObservableCollection<ProdutoModel> Produtos 
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public decimal Total
        {
            get => _total;
            set=> SetField(ref _total, value);
        }

        public string NumCard
        {
            get => _numCard;
            set => SetField(ref _numCard, value);
        }

        public int CVV
        {
            get => _cvv;
            set => SetField(ref _cvv, value);
        }

        public DateTime Date
        {
            get => _date;
            set => SetField(ref _date, value);
        }
    }
}