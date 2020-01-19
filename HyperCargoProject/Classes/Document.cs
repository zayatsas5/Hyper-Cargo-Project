using System;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using HyperCargoProject.UsersControl;

namespace HyperCargoProject.Classes
{
    class Document
    {


        public Document()
        {
            saveFileDialog.Filter = "Docx files(*.docx)|*.docx|All files(*.*)|*.*";
        }

        static SaveFileDialog saveFileDialog = new SaveFileDialog();

        public static void CreateDocument()
        {
            string templateDocx = Environment.CurrentDirectory.ToString() + @"\otchet.docx";
            string name = ucPersonalAccount.SecondName;
            string surname = ucPersonalAccount.FirstName;
            string lastname = ucPersonalAccount.LastName;
            var datetime = Convert.ToDateTime(DateTime.Now);
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            var wordDocument = wordApp.Documents.Open(templateDocx);
            ReplaceWordStub("{surname}", surname, wordDocument);
            ReplaceWordStub("{name}", name, wordDocument);
            ReplaceWordStub("{lastname}", lastname, wordDocument);
            ReplaceWordStub("{date}", datetime, wordDocument);

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                wordDocument.SaveAs(filename);
            }
        }

        private static void ReplaceWordStub(string stubToReplace, DateTime datetime, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: datetime);
        }

        private static void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
