using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleCategoryAgg.Services
{
    public interface IArticleCategoryValidatorService
    {
        void CheckThisRecordAlradyExists(string title);
    }
}
