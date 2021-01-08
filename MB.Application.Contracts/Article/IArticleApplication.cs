﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Application.Contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> GetList();
        void Create(CreateArticle command);
    }

}
