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

        private void btnPdfPrt_Click(object sender, EventArgs e)
        {
            if (FileName.Text == "")
                MessageBox.Show("파일명을 입력해주세요.");
            else
                FillForm();
        }

        private void btnFdName_Click(object sender, EventArgs e)
        {
            ListFieldNames();
        }
        // PDF Form 채우기 
        private void FillForm()
        {
            // 원본 PDF 경로
            string pdfTemplate = @"C:\Users\naraeyoon\source\repos\PDFPrint\PDFPrint\PDF\Form1.pdf";

            // * 생성된 PDF가 저장될 경로
            string newFile = @"C:\Users\naraeyoon\source\repos\PDFPrint\PDFPrint\PDF\" + FileName.Text + ".pdf";
            

            // * 원본 PDF 읽기
            PdfReader pdfReader = new PdfReader(pdfTemplate);

            // * 원본 PDF 문서에 컨텐츠를 추가하는 프로세스 시작 (원본PDF, 저장될 위치)
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
        
            //PDFStamper
            AcroFields pdfFormFields = pdfStamper.AcroFields;

            // form pdfFormFields 세팅
            pdfFormFields.SetField("prjTitle", "SteelFiber");
            pdfFormFields.SetField("location", "US East(N. Virginia)");
            
            // 필드를 ReadOnly로 설정
            foreach (DictionaryEntry de in pdfReader.AcroFields.Fields)
            {
                pdfStamper.AcroFields.SetFieldProperty(de.Key.ToString(), "setfflags", PdfFormField.FF_READ_ONLY, null);
            }

            string sTmp = "저장이 완료되었습니다.";
            MessageBox.Show(sTmp, "Finished");
            
            pdfStamper.FormFlattening = false;

            // close the pdf
            pdfStamper.Close();

        }


        private void ListFieldNames()

        {
            string pdfTemplate = @"C:\Users\naraeyoon\source\repos\PDFPrint\PDFPrint\PDF\Form1.pdf";

            // title the form
            this.Text += " - " + pdfTemplate;

            // PDF 양식
            PdfReader pdfReader = new PdfReader(pdfTemplate);
            
            StringBuilder sb = new StringBuilder();
            // 필드이름들
            foreach (DictionaryEntry de in pdfReader.AcroFields.Fields)
            {
                sb.Append(de.Key.ToString() + Environment.NewLine);
            }

            // 텍스트박스에 보여주기
            FieldName.Text = sb.ToString();
            FieldName.SelectionStart = 0;
        }


    }
}
