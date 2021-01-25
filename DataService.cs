﻿using System.Collections.Generic;
using System.IO;
using CasaDoCodigo.Models;
using Newtonsoft.Json;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;

        public DataService(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public void InicializaDb()
        {
            contexto.Database.EnsureCreated();

            var json = File.ReadAllText("livros.json");
            var livros  = JsonConvert.DeserializeObject<List<Livro>>(json);

            foreach (var livro in livros)
            {
                contexto.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }

            contexto.SaveChanges();
        }
    }

    class Livro
    {
        public string  Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}