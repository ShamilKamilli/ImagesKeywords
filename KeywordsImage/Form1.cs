using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeywordsImage.Infrastructures;
using System.IO;
using DSOFile;

namespace KeywordsImage
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async void Operate(object sender,EventArgs e)
        {
            bool answer = await EnumerateFilesAndWriteKeywords(UsingFile.SearchAndFindFilesName(textBox1.Text));
            if(answer)
            MessageBox.Show("successfully changed");
            else
                MessageBox.Show("something went wrong please try again");
        }

        private async Task<bool> EnumerateFilesAndWriteKeywords(IEnumerable<string> files)
        {
            try
            {
                foreach (var file in files)
                {
                    RequestSender rSender = new RequestSender(Path.GetFileNameWithoutExtension(file));
                    var data = await Task.Factory.StartNew(() =>
                    {
                        return rSender.SelectCustomWords((x) =>
                        {
                            if (x != "" && x!="Top" && !x.Contains(":") && !x.Contains("\n") && !x.Any(y => char.IsDigit(y)))
                                return true;
                            else return false;
                        });
                    });
                    UsingFile.FillKeywords(file, data);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var dsa = UsingFile.SearchAndFindFilesName(textBox1.Text);
            foreach (var item in dsa)
            {
                OleDocumentProperties dso = new DSOFile.OleDocumentProperties();
                dso.Open(item);
                MessageBox.Show(dso.SummaryProperties.Keywords);
                dso.Save();
                dso.Close(true);
            }
        }
    }
}
