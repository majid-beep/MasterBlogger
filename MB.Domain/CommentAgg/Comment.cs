using MB.Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace MB.Domain.CommentAgg
{
    public class Comment
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Message { get; private set; }
        public string Email { get; private set; }
        public int Status { get; private set; }
        public DateTime CreationDate { get; private set; }
        public long ArticleId { get; private set; }
        public Article Article { get; private set; }
        protected Comment()
        {
        }



        public Comment(string name, string message, string email, long articleId)
        {
            Name = name;
            Message = message;
            Email = email;
            ArticleId = articleId;
            CreationDate = DateTime.Now;
            Status = Statuses.New;
        }
    }
}
