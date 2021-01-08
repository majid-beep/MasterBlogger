using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        void Add(ArticleCategory entity);
        ArticleCategory Get(long id);
        List<ArticleCategory> GetAll();
        void Save();
        bool Exists(string title);

    }
}
