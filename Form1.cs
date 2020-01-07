using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace LabLappolainen2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        Image imgOriginal;   
        bool drawing;
        int historyCounter;
        public Color historyColor;
        public GraphicsPath currentPath;
        Point oldLocation;
        public static Pen currentPen;
        List<Image> History;

        int figuri = 0;
        int locallX = 0;
        int locallY = 0;
        int locallXO = 0;
        int locallYO = 0;
        public Form1()
        {
            InitializeComponent();
            drawing = false;  //переменная, отвественная за рисование
            currentPen = new Pen(Color.Black); // Инициализация пера с чёрным цветом
            currentPen.Width = trackBar1.Value;
            History = new List<Image>();
            

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                picDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История Пуста");
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                picDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История Пуста");
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            if(picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;

                }
            }
            Bitmap pic = new Bitmap(735, 380);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; // По умолчанию будет выбрано последнее расширение *.png
            SaveDlg.ShowDialog();

            

            if (SaveDlg.FileName != "")//Если введено не пустое имя
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)SaveDlg.OpenFile();

                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
            Graphics g = Graphics.FromImage(picDrawingSurface.Image);

            g.Clear(Color.White);
            g.DrawImage(picDrawingSurface.Image, 0, 0, 735, 380);

        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; // По умолчанию ьулет выбрано первое расширение *jpg

            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);

            picDrawingSurface.AutoSize = true;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Owner = this;
            f.ShowDialog();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar1.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            if (picDrawingSurface.Image != null)
                if (picDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка?", "Предупреждение", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveToolStripMenuItem_Click(sender, e); break;
                    case DialogResult.Cancel: return;

                }
            }
            Bitmap pic = new Bitmap(735, 380);
            picDrawingSurface.Image = pic;
            History.Add(new Bitmap(picDrawingSurface.Image));

        }

        private void PicDrawingSurface_Click(object sender, EventArgs e)
        {

        }

        private void PicDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if(picDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
                /*currentPen = System.Drawing.Color.historyColor;*/
                
            }
            if (e.Button == MouseButtons.Right)
            {
                
                currentPen.Color = System.Drawing.Color.White;
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }

        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; // По умолчанию будет выбрано последнее расширение *.png
            SaveDlg.ShowDialog();
            
            

            if (SaveDlg.FileName != "")//Если введено не пустое имя
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)SaveDlg.OpenFile();

                switch(SaveDlg.FilterIndex)
                {
                    case 1:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.picDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
            Graphics g = Graphics.FromImage(picDrawingSurface.Image);

            g.Clear(Color.White);
            g.DrawImage(picDrawingSurface.Image, 0, 0, 735, 380);

        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; // По умолчанию ьулет выбрано первое расширение *jpg

            if (OP.ShowDialog() != DialogResult.Cancel)
                picDrawingSurface.Load(OP.FileName);

            picDrawingSurface.AutoSize = true;
            imgOriginal= picDrawingSurface.Image;
        }

        private void ToolStripButton5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            if(figuri == 1)
            {
            Graphics g = Graphics.FromImage(picDrawingSurface.Image);
            currentPath.AddRectangle(new Rectangle(locallX,locallY,locallXO,locallYO));
            g.DrawPath(currentPen, currentPath);
            oldLocation = e.Location;
            g.Dispose();
            picDrawingSurface.Invalidate();

            }
            if (figuri == 3)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                Point[] pnt = new Point[3];

                pnt[0].X = locallX;
                pnt[0].Y = locallY;

                pnt[1].X = locallX + locallXO;
                pnt[1].Y = locallY + locallYO;

                pnt[2].X = locallX + locallXO;
                pnt[2].Y = locallY + -locallYO;
                
                g.DrawPolygon(currentPen, pnt);
                g.Dispose();
                picDrawingSurface.Invalidate();
            }
            
            
            if (figuri == 2)
            {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddEllipse(locallX, locallY, locallXO, locallYO);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();


            }
            
            




            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            History.Add(new Bitmap(picDrawingSurface.Image));
            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);
            drawing = false;    
            try
            {
                currentPath.Dispose();
            }
            catch { };
            imgOriginal = picDrawingSurface.Image;

        }

        private void PicDrawingSurface_MouseMove(object sender, MouseEventArgs e)
        {
            
            label1.Text = "X= "  + e.X.ToString() + ", Y= " + e.Y.ToString();
            if (drawing)
            {
                if (figuri == 0)
                {
                Graphics g = Graphics.FromImage(picDrawingSurface.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                picDrawingSurface.Invalidate();
                }
                else
                {
                    locallX = oldLocation.X;
                    locallY = oldLocation.Y;
                    locallXO = e.Location.X - oldLocation.X;
                    locallYO = e.Location.Y - oldLocation.Y;

                }
                
                

            }
        }

        private void SolidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;
            
        }

        private void DotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;
        }

        private void DashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Owner = this;
            f.ShowDialog();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ArrowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            picDrawingSurface.Image = Zoom(imgOriginal,trackBar2.Value);
        }
        Image Zoom(Image img, int size)
        {
            Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size / 10), img.Height + (img.Height * size / 10));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void EllipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void RectangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            this.solidToolStripMenuItem.Checked = false;
            this.dotToolStripMenuItem.Checked = false;
            this.dashDotDotToolStripMenuItem.Checked = false;
            this.boxToolStripMenuItem1.Checked = false;
            this.lineToolStripMenuItem.Checked = false;
            this.RectangleToolStripMenuItem1.Checked = true;


            figuri = 3;
        }

        private void RectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EllipseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            this.solidToolStripMenuItem.Checked = false;
            this.dotToolStripMenuItem.Checked = false;
            this.dashDotDotToolStripMenuItem.Checked = false;
            this.boxToolStripMenuItem1.Checked = false;
            this.ellipseToolStripMenuItem1.Checked = true;
            this.lineToolStripMenuItem.Checked = false;
            this.RectangleToolStripMenuItem1.Checked = false;

            figuri = 2;
        }

        private void BoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            this.solidToolStripMenuItem.Checked = false;
            this.dotToolStripMenuItem.Checked = false;
            this.dashDotDotToolStripMenuItem.Checked = false;
            this.boxToolStripMenuItem1.Checked = true;
            this.ellipseToolStripMenuItem1.Checked = false;
            this.lineToolStripMenuItem.Checked = false;
            this.RectangleToolStripMenuItem1.Checked = false;


            figuri = 1;
        }

        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            this.solidToolStripMenuItem.Checked = false;
            this.dotToolStripMenuItem.Checked = false;
            this.dashDotDotToolStripMenuItem.Checked = false;
            this.boxToolStripMenuItem1.Checked = false;
            this.lineToolStripMenuItem.Checked = true;
            this.RectangleToolStripMenuItem1.Checked = false;

            figuri = 0;
        }

        private void FillToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
