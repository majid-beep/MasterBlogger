using MB.Application.Contracts;
using MB.Application.Contracts.ArticleCategory;
using MB.Domain.ArticleCategoryAgg;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MB.Application
{
    public class articleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public articleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
            _articleCategoryRepository = articleCategoryRepository;
        }

        public void Activate(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Activate();
            _articleCategoryRepository.Save();
        }

        public void Create(CreateArticleCategory command)
        {
            var aricleCategory = new ArticleCategory(command.Title);
            _articleCategoryRepository.Add(aricleCategory);
        }

        public RenameArticleCategory Get(long id)
        {
            var articlecategory = _articleCategoryRepository.Get(id);
            return new RenameArticleCategory
            {
                Id = articlecategory.Id,
                Title = articlecategory.Title
            };
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _articleCategoryRepository.GetAll();
            var result = new List<ArticleCategoryViewModel>();
            foreach( var articleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = articleCategory.Id,
                    Title = articleCategory.Title,
                    IsDeleted = articleCategory.IsDeleted,
                    CreationDate = articleCategory.CreationDate.ToString(CultureInfo.InvariantCulture),

                });
            }
            return result;
        }

        public void Remove(long id)
        {
            var articleCategory = _articleCategoryRepository.Get(id);
            articleCategory.Remove();
            _articleCategoryRepository.Save();
        }

        public void Rename(RenameArticleCategory command)
        {
            var articlecategory = _articleCategoryRepository.Get(command.Id);
            articlecategory.Rename(command.Title);
            _articleCategoryRepository.Save();
        }
    }
}
