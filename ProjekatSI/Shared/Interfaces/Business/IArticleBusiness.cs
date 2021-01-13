using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Business
{
    public interface IArticleBusiness
    {
        public List<Article> GetAllArticles();
        public bool InsertProduct(Article a);
        public bool UpdateArticle(Article a);
        public bool DeleteArticle(int Id);
        public Article GetArticleById(int Id);
    }
}
