using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
    public partial class peemanetlisteleme : Form
    {
        public peemanetlisteleme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-3JFMBIJ;Initial Catalog=kutuphaneOdev;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        DataSet daset = new DataSet();

        private void peemanetlisteleme_Load(object sender, EventArgs e)
        {
            EmanetListele();
            comboBox1.SelectedIndex = 0;
        }
        private void EmanetListele()
        {
            connection.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar", connection);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            connection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                EmanetListele();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                connection.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'>IadeTarihi", connection);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                connection.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                connection.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from EmanetKitaplar where '" + DateTime.Now.ToShortDateString() + "'<=IadeTarihi", connection);
                adtr.Fill(daset, "EmanetKitaplar");
                dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
                connection.Close();
            }
        }

        private void pklBtnGeriKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            arayuz donus888 = new arayuz();
            donus888.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPdfExport_Click(object sender, EventArgs e)
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
                    document.Add(new Paragraph("Emanet Kitap Listesi").SetFont(boldFont).SetFontSize(18));
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
    

