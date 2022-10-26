﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Content.Domain.Enums;


namespace Content.Domain.Entities
{
    public class Article:  Content
    {

        //[Obsolete("Only for reflection", true)]
        public Article()
        {
        }
        
        protected internal Article(string title, string text, User creator):base(ContentType.Article, title, creator)
        {
            Text = text;
        }

    public virtual string Text { get; protected set; }
    }
}
