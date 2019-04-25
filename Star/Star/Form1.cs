using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;
        Pen pen;
        Point firstpoint = new Point(100, 150);
        Point secondpoint = new Point(120, 130);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Gold);
            pictureBox1.Image = bitmap;
            graphics.DrawPolygon(pen,Star(firstpoint, secondpoint));
        }

        private Point[] Star(Point p1, Point p2)
        {
            Point[] star =
            {
                new Point((p1.X+p2.X)/4,(p1.Y+p2.Y)/3),
                new Point((p1.X+p2.X)/3,(p1.Y+p2.Y)/4),
                new Point(2*(p1.X+p2.X)/3,(p1.Y+p2.Y)/4),
                new Point(2*(p1.X+p2.X)/4,(p1.Y+p2.Y)/3),
                new Point(p2.X,(p1.Y+p2.Y)/3),
                new Point(p2.X,2*(p1.Y+p2.Y)/3),
                new Point(p1.X,(p1.Y+p2.Y)/2),
                new Point(p1.X,(p1.Y+p2.Y)/3)
            };
            return star;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
