using DataLayer.Model;
using DataLayer.ViewModels;
using Microsoft.Office.Interop.Word;
using Microsoft.Win32.SafeHandles;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnitOfWork;

namespace Lens_Management.Classes
{
    public static class Report
    {


        public static void GetReport(Expression<Func<Lens, bool>> where = null, bool FullReport = false, bool ShowWord = false)
        {

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "word document |*.docx;";
            if (save.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    List<LensViewModel> Lenses = new List<LensViewModel>();
                    using (UnitOfWorkDB db = new UnitOfWorkDB())
                    {

                        foreach (Lens lens in db.LensRepository.Get(where).ToList())
                        {
                            LensViewModel model = new LensViewModel()
                            {
                                SPH = lens.SPH,
                                CYL = lens.CYL,
                                AXE = lens.AXE,
                                SectionTitle = lens.Section.Title,
                                Count = lens.Count
                            };

                            if (FullReport)
                            {
                                model.Price = lens.Price;
                                model.Description = lens.Description;
                            }

                            Lenses.Add(model);
                        }
                    }

                    Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                    winword.ShowAnimation = false;

              
                    winword.Visible = ShowWord;

                    
                    object missing = System.Reflection.Missing.Value;

                 
                    Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                  
                    foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                    {
                    
                        Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                        headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                        headerRange.Font.Size = 10;
                        headerRange.Text = "لیست عدسی ها ";
                    }

                  
                    foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                    {
                   
                        Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                        footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                        footerRange.Font.Size = 10;
                        footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                        footerRange.Text = "گزارش از نرم افزار Lens Managemet ";
                    }

                  
                    document.Content.SetRange(0, 0);

                    Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                    object styleHeading1 = "Heading 1";
                    para1.Range.set_Style(ref styleHeading1);
                    para1.Range.Text = Environment.NewLine;
                    para1.Range.InsertParagraphAfter();
                 

                    Table firstTable = document.Tables.Add(para1.Range, Lenses.Count + 1, FullReport ? 7 : 5, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    string[] columnHeaders = { "عنوان", "SPH", "CYL", "AXE", "تعداد", "قیمت", "توضیحات" };

                    
                    Row headerRow = firstTable.Rows[1];
                    int columnIndex = 1;
                    foreach (string columnHeader in columnHeaders)
                    {
                        Cell headerCell = headerRow.Cells[columnIndex];
                        headerCell.Range.Text = columnHeader;
                        columnIndex++;
                    }


                    foreach (Row row in firstTable.Rows)
                    {

                        foreach (Cell cell in row.Cells)
                        {

                            if (row.Index != 1)
                            {
                                switch (cell.ColumnIndex)
                                {
                                    case 1:
                                        cell.Range.Text = Lenses[row.Index - 2].SectionTitle;
                                        break;
                                    case 2:
                                        cell.Range.Text = Lenses[row.Index - 2].SPH;
                                        break;
                                    case 3:
                                        cell.Range.Text = Lenses[row.Index - 2].CYL;
                                        break;
                                    case 4:
                                        cell.Range.Text = Lenses[row.Index - 2].AXE;
                                        break;
                                    case 5:
                                        cell.Range.Text = Lenses[row.Index - 2].Count.ToString();
                                        break;
                                    case 6:
                                        cell.Range.Text = Lenses[row.Index - 2].Price.ToString();
                                        break;
                                    case 7:
                                        cell.Range.Text = Lenses[row.Index - 2].Description;
                                        break;
                                }
                            }


                        }

                    }

                  
                    object filename = save.FileName;
                    document.SaveAs2(ref filename);
                    document.Close(ref missing, ref missing, ref missing);
                    document = null;
                    winword.Quit(ref missing, ref missing, ref missing);
                    winword = null;

                    CrownMessageBox.ShowInformation("گزارش در مسیر انتخاب شده ذخیره شد", "موفق");
                }
                catch
                {
                    CrownMessageBox.ShowError("مشکلی پیش آمده توجه داشته باشید باید حتما ورد بسته باشد ", "ناموفق");
                }


            }


        }


    }
}
