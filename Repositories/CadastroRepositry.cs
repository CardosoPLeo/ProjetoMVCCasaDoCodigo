using System;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface ICadastroRepository
    {

    }
    public class CadastroRepositry : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepositry(ApplicationContext contexto) : base(contexto)
        {

        }
    }
}
