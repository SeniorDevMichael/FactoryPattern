using Example1.PagesContent.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.DocumentsContent.Documents
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Resume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
