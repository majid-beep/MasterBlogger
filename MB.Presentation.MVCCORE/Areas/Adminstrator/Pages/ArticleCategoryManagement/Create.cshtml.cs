using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MB.Application;
using MB.Application.Contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCORE.Areas.Adminstrator.Pages.ArticleCategoryManagement
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }
        public RedirectToPageResult OnPost(CreateArticleCategory command)
        {
            _articleCategoryApplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}
