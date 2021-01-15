using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Interfaces.Repository
{
    public interface IArticleRepository
    {
        public List<Article> GetAllArticles();
        public int UpdateArticle(Article a);
        public int InsertArticle(Article a);
        public int DeleteArticle(int Id);

    }
}
