using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;
using System.Collections;

namespace PDFPrint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FillForm( string s)
        {
            //원본 PDF 경로
            string pdfTemplate = @"C:\Users\naraeyoon\source\repos\PDFPrint\PDFPrint\PDF\Form1.pdf";
            // 원본에 수정되어 저장될 경로
            string newFile = @"C:\\Users\naraeyoon\source\repos\PDFPrint\PDFPrint\PDF\Form4.pdf";

            //원본 PDF 읽기
            PdfReader pdfReader = new PdfReader(pdfTemplate);
            //원본 PDF와 저장될 위치
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            StringBuilder sb = new StringBuilder();
            foreach (DictionaryEntry de in pdfReader.AcroFields.Fields)
            {
                pdfStamper.AcroFields.SetFieldProperty(de.Key.ToString(), "setfflags", PdfFormField.FF_READ_ONLY, null);
            }

            //PDFStamper
            AcroFields pdfFormFields = pdfStamper.AcroFields;

            // form pdfFormFields 세팅
            pdfFormFields.SetField("prjTitle", "SteelFiber");
            pdfFormFields.SetField("location", "US East(N. Virginia)");
   
            // report by reading values from completed PDF

            string sTmp = "저장";

            MessageBox.Show(sTmp, "Finished");
            // flatten the form to remove editting options, set it to false
            // to leave the form open to subsequent manual edits2
            //pdfStamper.AcroFields.SetFieldProperty("prjTitle", "setfflags", PdfFormField.FF_READ_ONLY, null);
            pdfStamper.FormFlattening = false;

            // close the pdf
            pdfStamper.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER);
            PdfWriter Wr = PdfWriter.GetInstance(doc, new FileStream("simple.pdf", FileMode.Create));

            // Documenet에 내용쓰기
            doc.Open();
            doc.AddTitle("Simple PDF 생성");
            doc.AddAuthor("Narae");
            doc.AddCreationDate();
            doc.Add(new Paragraph("English : How are you?"));

            string batangttf = System.IO.Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), @"Fonts\malgun.TTF");
            BaseFont batangBase = BaseFont.CreateFont(batangttf, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            var batang = new iTextSharp.text.Font(batangBase, 12F);
            doc.Add(new Paragraph("한글: 안녕하세요?", batang));

            doc.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FillForm(textBox1.Text);
        }

        private void ListFieldNames()

        {
            string pdfTemplate = @"C:\Users\JayChoi\source\repos\pdfTest\pdfTest\aa.pdf";

            // title the form
            this.Text += " - " + pdfTemplate;

            // PDF 양식
            PdfReader pdfReader = new PdfReader(pdfTemplate);

            // create and populate a string builder with each of the 
            // field names available in the subject PDF
            StringBuilder sb = new StringBuilder();
            // 필드이름들
            foreach (DictionaryEntry de in pdfReader.AcroFields.Fields)
            {
                sb.Append(de.Key.ToString() + Environment.NewLine);
            }

            // 텍스트박스에 보여주기
            textBox1.Text = sb.ToString();
            textBox1.SelectionStart = 0;
        }

    }
}
