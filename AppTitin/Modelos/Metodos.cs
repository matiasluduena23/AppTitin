using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppTitin.Modelos
{
    class Metodos
    {
        //metodos para el formulario de calculo -  calculo2 - impresion de pdf
        public IEnumerable<dynamic> lista(string path, string element, string elements)
        {
            IEnumerable<dynamic> l = null;
                if (File.Exists(path))
                {
                    l = from lista in XDocument.Load(path)
                                           .Element(element).Elements(elements)
                        select new { tipo = lista.Element("tipo").Value, precio = lista.Element("precio").Value };
                    return l.ToList().OrderBy(a => a.tipo);
                }
                else
                    MessageBox.Show("Error al cargar el archivo XML", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return l;
        }

        public void cargarCombo(ComboBox combo, string element, string elements)
        {
            string pathV = @"C:\ZimmerGlass\Datos\" + element+".xml";
            try
            {
                combo.DataSource = lista(pathV, element, elements).ToList();
                combo.DisplayMember = "tipo";
                combo.ValueMember = "precio";
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cargar combobox " + e.Message);
            }
        }
        

        public double metrosLineales(string alto, string ancho, string cant)
        {
            double r = Math.Round((((Convert.ToDouble(alto) * 2) + (Convert.ToDouble(ancho) * 2)) * Convert.ToDouble(cant))/1000, 2);
            return r;
        }

        public double metrosCuadradosXtipo(string alto, string ancho, string cant)
        {

            double r = Math.Round((((Convert.ToDouble(alto) * Convert.ToDouble(ancho)) * Convert.ToDouble(cant))/1000)/1000,2);
            return r;
        }

        public double precioTipo(string precio, double metodo)
        {
            double r = Math.Round(metodo * Convert.ToDouble(precio), 2);
            return r;
        }

        public double precioCamara(string precio, double metodo)
        {
            double r = Math.Round(metodo * Convert.ToDouble(precio), 2);
            return r;
        }

        public double total(string t1, string t2, string c)
        {
            double r = Math.Round(Convert.ToDouble(t1) + Convert.ToDouble(t2) + Convert.ToDouble(c), 2);
            return r;
        }

        public void abrirPDF(string path)
        {
            try
            {
                Process p = new Process();
                p.StartInfo.FileName = @"C:\ZimmerGlass\\Pdf\" + path;
                p.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        public double precioTotal(DataGridView data)
        {
            double t = 0;
            foreach (DataGridViewRow item in data.Rows)
            {
                t += Convert.ToDouble(item.Cells["Column5"].Value);
            }
            return Math.Round(t, 2);
        }

        public void generarPdf(DataGridView data, string cliente, string observaciones)
        {   //generar pdf
            string ruta = @"C:\ZimmerGlass\Pdf\";
            string nombre = generarNombreArchivo();
            //creamos documento
            Document doc = new Document(iTextSharp.text.PageSize.A4);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(ruta + nombre, FileMode.Create));
            doc.Open();
            try
            {


                // Creamos la imagen y le ajustamos el tamaño
                iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(@"C:\ZimmerGlass\Recursos\LogoGFinal.jpg");
                imagen.BorderWidth = 0;
                imagen.Alignment = Element.ALIGN_CENTER;
                float percentage = 0.0f;
                percentage = 450 / imagen.Width;
                imagen.ScalePercent(percentage * 100);
                // Insertamos la imagen en el documento
                doc.Add(imagen);

                DateTime fecha = DateTime.Today;
                Paragraph presupuesto = new Paragraph("PRESUPUESTO N°: " + nombre.Remove(7, 4), FontFactory.GetFont("Arial", 15, Font.BOLD));
                presupuesto.Alignment = 1;
                doc.Add(presupuesto);
                Paragraph pp = new Paragraph(fecha.ToShortDateString(), FontFactory.GetFont("Calibri", 9));
                pp.Alignment = Element.ALIGN_RIGHT;
                doc.Add(pp);
                Paragraph p = new Paragraph("ZIMMER-GLASS", FontFactory.GetFont("Calibri", 10, Font.BOLD));
                p.Alignment = Element.ALIGN_LEFT;
                doc.Add(p);
                Paragraph q = new Paragraph("MENDIOLAZA 762 - CÓRDOBA CAPITAL", FontFactory.GetFont("Calibri", 9));
                q.Alignment = Element.ALIGN_LEFT;
                q.Add("\nTEL. 0351-4707878");
                q.Add("\nCEL. 0351-155228424");
                q.Add("\nMAIL: zimmer-glass@outlook.com");
                doc.Add(q);
                doc.Add(new Paragraph("\nSr. " + cliente, FontFactory.GetFont("Calibri", 12, Font.BOLD)));
                doc.Add(new Paragraph("\n"));

                PdfPTable tabla = new PdfPTable(data.Columns.Count);
                tabla.WidthPercentage = 100;
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    tabla.AddCell(new Phrase(data.Columns[i].HeaderText, FontFactory.GetFont("Calibri", 7, Font.BOLD)));
                }
                tabla.HeaderRows = 1;
                for (int j = 0; j < data.Rows.Count; j++)
                {
                    for (int k = 0; k < data.Columns.Count; k++)
                    {
                        if (data[k, j].Value != null)
                        {
                            tabla.AddCell(new Phrase(data[k, j].Value.ToString(), FontFactory.GetFont("Calibri", 7, Element.ALIGN_CENTER)));
                        }
                    }
                }
                doc.Add(tabla);


                Paragraph tot = new Paragraph("\nSubTotal: $" + precioTotal(data).ToString(), FontFactory.GetFont("Calibri", 10, Font.BOLD));
                tot.Alignment = 1;
                doc.Add(tot);
                doc.Add(new Paragraph("\n"));
                Paragraph obs = new Paragraph("Observaciones: " + observaciones, FontFactory.GetFont("Calibri", 10));
                obs.Alignment = Element.ALIGN_JUSTIFIED;
                PdfPTable ta = new PdfPTable(1);
                ta.WidthPercentage = 90;
                ta.AddCell(obs);
                doc.Add(ta);

                doc.Add(new Paragraph("\n"));
                
                string tex = "El presente presupuesto es válido por 10 días y refleja la interpretación realizada por nuestros técnicos sobre su solicitud original."
                    + " Es su responsabilidad revisar que los materiales, cantidades y medidas cotizadas correspondan a sus necesidades. ZIMMER-GLASS no se hará responsable por las diferencias que puedan producirse por este motivo."
                    + " Su aceptación de este presupuesto da por valido el mismo en todo sus términos. Las condiciones para comenzar el trabajo son, una entrega del 50% y el resto cuando entreguemos todo el trabajo terminado.";
                //PdfPTable tt = new PdfPTable(1);
                //tt.AddCell(t);
                //doc.Add(tt);

                PdfContentByte cb = wri.DirectContent;
                ColumnText ct = new ColumnText(cb);
                ct.SetSimpleColumn(new Phrase(new Chunk(tex, FontFactory.GetFont(FontFactory.HELVETICA, 7, Font.BOLD))),
                                   50, 80, 530, 30, 9, Element.ALIGN_JUSTIFIED);
                ct.Go();
            }catch(Exception ex)
            {
                MessageBox.Show("Error generando pdf " + ex);
            }
            
            //cerramos documento
            doc.Close();
            //abrimos el documento en pantalla
            abrirPDF(nombre);
        }

        private string generarNombreArchivo()
        {
            int ultimoNumero = Directory.GetFiles( @"C:\ZimmerGlass\Pdf\", "A*.pdf", SearchOption.TopDirectoryOnly)
                        .Select(x => Convert.ToInt32(Path.GetFileName(x).Substring(1,6)))
                        .DefaultIfEmpty().Max();

            return string.Format("A{0}.pdf", (ultimoNumero + 1).ToString("000000"));
        }


    }
}
