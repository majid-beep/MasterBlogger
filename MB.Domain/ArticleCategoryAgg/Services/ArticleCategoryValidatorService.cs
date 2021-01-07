﻿using System;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public class ArticleCategoryValidatorService : IArticleCategoryValidatorService
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryValidatorService(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void CheckThisRecordAlradyExists(string title)
        {
            if(_articleCategoryRepository.Exists(title))
            {
                throw new Exception("this title already exists");
            }
        }
    }
}
