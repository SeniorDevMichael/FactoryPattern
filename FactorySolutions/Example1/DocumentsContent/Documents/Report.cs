using Example1.PagesContent.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.DocumentsContent.Documents
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class Report : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}