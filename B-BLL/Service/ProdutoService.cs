using System.Collections.Generic;
using CoverAll_API.C_DAL.Interface;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.B_Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository repository;

        public ProdutoService(IProdutoRepository repository)
        {
            this.repository = repository;

        }
        public void Add(Produto entity)
        {
            repository.Add(entity);
        }

        public void Delete(Produto entity)
        {
            repository.Delete(entity);
        }

        public ICollection<Produto> GetList()
        {
            return repository.GetList();
        }

        public bool SaveChanges()
        {
            return this.repository.SaveChanges();
        }

        public void Update(Produto entity)
        {
            repository.Update(entity);
        }
    }
}