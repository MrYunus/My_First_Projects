using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using iText.Kernel.Font;

namespace l
{
    public partial class Sıralamafrm : Form
    {
        public Sıralamafrm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet daset = new DataSet();
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

        private void pklBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus111 = new arayuz();
            donus111.ShowDialog();
        }

        private void Sıralamafrm_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from OgrenciKayit order by okukitapsayisi desc", connection);
            adtr.Fill(daset, "OgrenciKayit");
            dataGridView1.DataSource = daset.Tables["OgrenciKayit"];
            connection.Close();
            label2.Text = "";
            label4.Text = "";
            label2.Text = daset.Tables["OgrenciKayit"].Rows[0]["fkoAdi"].ToString() + "=";
            label2.Text += daset.Tables["OgrenciKayit"].Rows[0]["okukitapsayisi"].ToString();
            label4.Text = daset.Tables["OgrenciKayit"].Rows[dataGridView1.Rows.Count - 2]["fkoAdi"].ToString() + "=";
            label4.Text += daset.Tables["OgrenciKayit"].Rows[dataGridView1.Rows.Count - 2]["okukitapsayisi"].ToString();
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "PDF Kaydet";
            saveFileDialog.FileName = "EmanetKitaplar.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                {
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    var boldFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);
                    document.Add(new Paragraph("SıralamaListesi").SetFont(boldFont).SetFontSize(18));

                    Table table = new Table(dataGridView1.Columns.Count);
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
                    }

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                        }
                    }

                    document.Add(table);
                    document.Close();

                    MessageBox.Show("PDF başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
