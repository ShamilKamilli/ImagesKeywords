using DSOFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsImage.Infrastructures
{
   public static class UsingFile
    {
        public static IEnumerable<string> SearchAndFindFilesName(string path)
        {
            IEnumerable<string> files = Directory.EnumerateFiles(path, "*", SearchOption.AllDirectories);
            if (files != null)
            {
                foreach (string item in files)
                {
                    yield return item;
                }
            }
            else
                throw new Exception("There is not any file selected directory");
        }

        public static void FillKeywords(string item,IEnumerable<string> words)
        {
            OleDocumentProperties dso = new DSOFile.OleDocumentProperties();
            dso.Open(item);
            dso.SummaryProperties.Keywords = ConcatStrings(words);
            dso.Save();
            dso.Close(true);
        }

        private static string ConcatStrings(IEnumerable<string> words)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var item in words)
            {
                builder.Append(item + " ");
            }
            return builder.ToString();
        }
    }
}
