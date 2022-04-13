using Example1.PagesContent;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.DocumentsContent
{
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages 
        {
            get
            {
                return _pages;
            }
        }

        // Factory Method
        public abstract void CreatePages();
    }
}