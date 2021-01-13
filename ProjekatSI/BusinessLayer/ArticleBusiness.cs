using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ArticleBusiness : IArticleBusiness
    {
        private readonly IArticleRepository articleRepository;
        public ArticleBusiness(IArticleRepository _articleRepository)
        {
            this.articleRepository = _articleRepository;
        }
        public List<Article> GetAllArticles()
        {
            return this.articleRepository.GetAllArticles();
        }
        public bool InsertProduct(Article a)
        {
            if (this.articleRepository.InsertArticle(a) > 0)
            {
                return true;
            }
            return false;
        }
        public bool UpdateArticle(Article a)
        {
            if (this.articleRepository.UpdateArticle(a) > 0)
            {
                return true;
            }
            return false;
        }
        public bool DeleteArticle(int Id)
        {
            if (this.articleRepository.DeleteArticle(Id) > 0)
            {
                return true;
            }
            return false;
        }
        public Article GetArticleById(int Id)
        {
            return this.articleRepository.GetAllArticles().FirstOrDefault(a => a.ArticleId == Id);
        }
    }
}
