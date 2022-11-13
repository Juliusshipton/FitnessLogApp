using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessLog.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string RedditLink => "https://old.reddit.com/r/mma";
        public string NextUfcLink => "https://mmafightcards.org/";
        public string JuliusLinkedIn => "https://www.linkedin.com/in/julius-shipton-2ba497144/";
        public string Message => "Test Binding: This app is written in XAML and C# with .NET MAUI.  We are practicing app customization so here are a few buttons to fun links.";
    }
}
