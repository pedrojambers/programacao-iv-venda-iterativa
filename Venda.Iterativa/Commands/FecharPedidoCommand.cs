using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Classes;
using Venda.Iterativa.ViewModel;
using Venda.Iterativa.UserControls;
using System.Windows;

namespace Venda.Iterativa.Commands
{
    internal sealed class FecharPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            var vm = parameter as ReceberViewModel;

            if (vm.Pedido.NumCard.ToString().Length != 16 || vm.Pedido.CVV == 0 || vm.Pedido.Date < DateTime.Today)
            {
                MessageBox.Show("Informações inválidas!");
                return;
            }
            MessageBox.Show("Pedido realizado!");
        }
    }
}
