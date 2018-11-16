using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsImage.Infrastructures
{
   public class RequestSender
    {
        private readonly string _key;
        public RequestSender(string key)
        {
            _key = key;
        }

        private  HtmlDocument SendRequest()
        {
            return new HtmlWeb().Load(ConfigurationManager.AppSettings["Url"] + _key);
        }

        private IEnumerable<string> SelectSpecificElements()
        {
          return   SendRequest().DocumentNode
                       .SelectNodes(ConfigurationManager.AppSettings["SelectNode"])
                          .Select(m=>m.InnerText);          
        }

        public IEnumerable<string> SelectCustomWords(Func<string,bool> predicate)
        {
            foreach (string item in SelectSpecificElements())
            {
                foreach (string splitedWords in item.Split(' '))
                {
                    if (predicate(splitedWords))
                        yield return splitedWords;
                }
            }
        }

    }
}
