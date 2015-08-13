using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.Configuration;

namespace NumberSequence.Tests
{
    public static class BrowserHost
    {
        public static readonly SelenoHost Instance  = new SelenoHost();
        public static readonly string RootURL;
        static BrowserHost()
        {
            Instance.Run("NumberSequence",4223);
            RootURL= Instance.Application.Browser.Url;
        }

    }
}

