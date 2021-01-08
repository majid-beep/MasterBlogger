﻿using MB.Application.Contracts.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleAgg
{
   public interface IArticleRepository
    {
        List<ArticleViewModel> GetList();
        void CreateAndSave(Article entity);
        Article Get(long id);
        void Save();
    }
}
