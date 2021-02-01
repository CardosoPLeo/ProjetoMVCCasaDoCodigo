using System;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface IItemPedidoRepository
    {

    }
    public class ItemPedidoRepositiry : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepositiry(ApplicationContext contexto) : base(contexto)
        {

        }
    }
}
