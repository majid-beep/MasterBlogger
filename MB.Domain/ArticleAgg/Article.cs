using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.ArticleAgg
{
   public class Article
    {
        public long Id { get; private set; }
        public string Title { get; private set; }
        public string Image { get; private set; }
        public string ShortDescription { get; private set; }
        public long CategoryId { get; private set; }
        public ArticleCategory ArticleCategory { get; private set; }
    }
}
