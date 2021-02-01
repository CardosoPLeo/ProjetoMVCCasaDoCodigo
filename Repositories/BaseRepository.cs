using System;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public class BaseRepository <T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly Microsoft.EntityFrameworkCore.DbSet<T> dbSets;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSets = contexto.Set<T>();
        }

    }
}
