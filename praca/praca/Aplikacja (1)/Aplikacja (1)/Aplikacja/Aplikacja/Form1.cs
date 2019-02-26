
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Aplikacja
{
    public partial class function : Form
    {
        float contrast = 0;
        Image File;
        Image<Rgba, byte> imgInput;
        List<Bitmap> images = new List<Bitmap>();
        Rectangle rect;
        Point StartLocation;
        Point EndLocation;
        List<Bitmap> images_processed = new List<Bitmap>();
        bool locked = false;
        bool isMouseDown = false;
        bool lockedbar = false;
        bool imageloc = false;
        int zmienna1;
    OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public function()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            medfilter.Enabled = false;
            gaufilter.Enabled = false;
            dft_button.Enabled = false;
            trackBar2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            histogram.Enabled = false;
            bar2.Enabled = false;
            button2.Enabled = false;
            button7.Enabled = false;
            label16.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label1.Visible = false;
            label18.Visible = false;
            label17.Visible = false;
            button8.Enabled = false;
            radioButton3x3.Enabled = false;
            radioButton5x5.Enabled = false;
            radioButton7x7.Enabled = false;

        }
        private void open_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Image Files(*.tiff)|*.tiff";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string Path = System.IO.Path.GetDirectoryName(openFileDialog1.FileName);
                //pobranie wszystkich nazw plików do tablicy stringów
                string[] FileNames = System.IO.Directory.GetFiles(Path);

                for (int i = 0; i < FileNames.Length; i++)
                {
                    images.Add(new Bitmap(FileNames[i]));
                    imgInput = new Image<Rgba, byte>(FileNames[i]);
                }
                photos.Text = "Photos: 1 from " + (FileNames.Length);
                // images.Add(new Bitmap(fileName));

                // image1.Image = imgInput.Bitmap;
                File = Image.FromFile(openFileDialog1.FileName);
                image1.Image = File;
                image1.SizeMode = PictureBoxSizeMode.StretchImage;
                image2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if(images.Count !=0)
            MessageBox.Show(String.Format("Images loaded and save"), "", MessageBoxButtons.OK);
            else
            MessageBox.Show(String.Format("Try again load images"), "", MessageBoxButtons.OK);
        }

        private void bar1_Scroll(object sender, ScrollEventArgs e)
        {
            int zmienna = images.Count ;
            photos.Text = "Photos:" + bar1.Value.ToString() + " from " + zmienna;
            image1.Image = images[bar1.Value - 1];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            locked = true;
            lockedbar = true;
            dft_button.Enabled = false;
            if (imageloc == false)
            {
                image2.Image = null;
                image2.Show();
                imageloc = true;
            }
           
        }
        private void image1_MouseDown(object sender, MouseEventArgs e)
        {
            if(locked == true)
            {
                isMouseDown = true;
                StartLocation = e.Location;
            }
        }
        private void image1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown== true && locked == true)
            {
                EndLocation = e.Location;
                image1.Invalidate();
            }
        }

        private void image1_Paint(object sender, PaintEventArgs e)
        {
            
            if (rect != null && locked == true)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRectangle());
            }
        }
            private Rectangle GetRectangle()
            {
            rect = new Rectangle();
            rect.X = Math.Min(StartLocation.X, EndLocation.X);
            rect.Y = Math.Min(StartLocation.Y, EndLocation.Y);
            rect.Width = Math.Abs(StartLocation.X - EndLocation.X);
            rect.Height = Math.Abs(StartLocation.Y - EndLocation.Y);
            return rect;
            }

        private void image1_MouseUp(object sender, MouseEventArgs e)
        {

            if (isMouseDown == true && locked == true)
            {
                EndLocation = e.Location;
                isMouseDown = false;
                if (rect != null)
                {
                        rect.X = rect.X * images[bar1.Value - 1].Width / image1.Width;
                        rect.Y = rect.Y * images[bar1.Value - 1].Height / image1.Height;
                        rect.Width = rect.Width * images[bar1.Value - 1].Width / image1.Width;
                        rect.Height = rect.Height * images[bar1.Value - 1].Height / image1.Height; 
                        for (int q = 0; q <= images.Count-1; q++)
                    {
                         
                        Bitmap bmp = new Bitmap(rect.Width,  rect.Height);
                        this.image2.SizeMode = PictureBoxSizeMode.StretchImage;
                        Graphics g = Graphics.FromImage(bmp);
                      g.DrawImage(images[q], new Rectangle(0, 0, rect.Width, rect.Height),rect, GraphicsUnit.Pixel);
                        images_processed.Add(bmp);
                    }
                    image2.Image = images_processed[bar1.Value - 1];
                    bar2.Value = bar1.Value;
                    bar2_label.Text = "Processed images:" + bar2.Value.ToString() + " from " + (images_processed.Count);
                    
                    medfilter.Enabled = true;
                    gaufilter.Enabled = true;
                    dft_button.Enabled = true;
                    trackBar2.Enabled = true;
                    button3.Enabled = true;
                    button6.Enabled = true;
                    button5.Enabled = true;
                    histogram.Enabled = true;
                    bar2.Enabled = true;
                    button2.Enabled = true;
                    bar1.Enabled = true;
                    button8.Enabled = true;
                    button7.Enabled = true;
                    radioButton3x3.Enabled = true;
                    radioButton5x5.Enabled = true;
                    radioButton7x7.Enabled = true;
                    button1.Enabled = false;
                    // image1.Image = temp.Bitmap;
                    if (Math.Abs(StartLocation.X - EndLocation.X) < 10 && Math.Abs(StartLocation.X - EndLocation.X) < 10)
                    {
                        MessageBox.Show(String.Format("Please select a bigger region"), "", MessageBoxButtons.OK);

                    }
                }
            }
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            medfilter.Enabled = false;
            gaufilter.Enabled = false;
            dft_button.Enabled = false;
            trackBar2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            histogram.Enabled = false;
            bar2.Enabled = false;
            button2.Enabled = false;
            bar1.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            images3.Visible = false;
            radioButton3x3.Enabled = false;
            radioButton5x5.Enabled = false;
            button1.Enabled = true;
            radioButton7x7.Enabled = false; if (imageloc == true)
            {
                image2.Hide();
                imageloc = false;
            }
            images_processed.Clear();
            bar2.Value = bar1.Value;
            bar2_label.Text = "Processed images:" ;
        }
        private double[] image2matrix(Bitmap I)
        {
            double[] ImageToDouble1DTab = new double[I.Width*I.Height];
            int k = 0;
            for (int i = 0;i < I.Width; i++)
            {
                for (int j = 0; j < I.Height; j++)
                {
                    ImageToDouble1DTab[k] = Convert.ToDouble(I.GetPixel(i, j).R);
                    k++;
                }
            }
            return ImageToDouble1DTab;
        }

        private Bitmap matrix2image(double[] M, int W, int H)
        {

            Bitmap I = new Bitmap(W, H);
            int k = 0;
            
            Color K;
            for (int i = 0; i < I.Width; i++)
            {
                for (int j = 0; j < I.Height; j++)
                {
                    int R = (int)M[k];
                    K = Color.FromArgb(R, R, R);
                    I.SetPixel(i, j, K);
                    k++;
                }

            }
            return I;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton3x3.Checked == true || radioButton5x5.Checked == true || radioButton7x7.Checked ==true)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.loading;
                Application.DoEvents();
                double[] Seq2M = sequence2matrix(images_processed);
                if (radioButton3x3.Checked == true)
                    NativeMethods.Median(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                if (radioButton5x5.Checked == true)
                    NativeMethods.Median1(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                if (radioButton7x7.Checked == true)
                    NativeMethods.Median2(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                images_processed = matrix2sequence(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                image2.Image = images_processed[bar1.Value - 1];
                bar2.Value = bar1.Value;
                bar2_label.Text = "Processed images:" + bar1.Value.ToString() + " from " + (images_processed.Count);
                pictureBox1.Visible = false;
                bar2.Value = bar1.Value;
                int n = bar1.Value;//10 
            }
            else
            {
                MessageBox.Show(String.Format("Please select appriopriate mask"), "", MessageBoxButtons.OK);
            }
             
        }
        public static class NativeMethods
        {
            [DllImport("Project1.dll", SetLastError = true)]
            public static extern void Median(double[] M, int W, int H, int Frames);
            [DllImport("Project2.dll", SetLastError = true)]
            public static extern void Median1(double[] M, int W, int H, int Frames);
            [DllImport("Project3.dll", SetLastError = true)]
            public static extern void Median2(double[] M, int W, int H, int Frames);
            [DllImport("Gauss3x3.dll", SetLastError = true)]
            public static extern void Gauss(double[] M, int W, int H, int Frames);
            [DllImport("Gauss5x5.dll", SetLastError = true)]
            public static extern void Gauss1(double[] M, int W, int H, int Frames);
            [DllImport("Gauss7x7.dll", SetLastError = true)]
            public static extern void Gauss2(double[] M, int W, int H, int Frames);
            [DllImport("DFT_PHR.dll", SetLastError = true)]
            public static extern void DFT_PHR(double[] M, int W, int H,int Frames);
            [DllImport("DFT_AMP.dll", SetLastError = true)]
            public static extern void DFT_AMP(double[] M, int W, int H,int Frames);
            [DllImport("Entrophy.dll", SetLastError = true)]
            public static extern void Entrophy(double[] M, int W, int H, int Frames);
            [DllImport("Stretch.dll", SetLastError = true)]
            public static extern void Stretch(double[] M, int W, int H,int Frames);
            [DllImport("EdgeDetection.dll", SetLastError = true)]
            public static extern void EdgeDetection(double[] M, int W, int H, int Frames);
            [DllImport("EdgeDetection1.dll", SetLastError = true)]
            public static extern void EdgeDetection1(double[] M, int W, int H, int Frames);
            [DllImport("EdgeDetection2.dll", SetLastError = true)]
            public static extern void EdgeDetection2(double[] M, int W, int H, int Frames);
            [DllImport("Derivative.dll", SetLastError = true)]
            public static extern void Derivative(double[] M, int W, int H, int Frames);
            [DllImport("Derivative2.dll", SetLastError = true)]
            public static extern void Derivative2(double[] M, int W, int H, int Frames);

        }

        private void radioButton3x3_Click(object sender, EventArgs e)
        {
            medfilter.Enabled = true;
            gaufilter.Enabled = true;
        }

        private void radioButton5x5_Click(object sender, EventArgs e)
        {
            medfilter.Enabled = true;
            gaufilter.Enabled = true;
        }

        private void radioButton7x7_Click(object sender, EventArgs e)
        {
            medfilter.Enabled = true;
            gaufilter.Enabled = true;
        }
        private void radioButtonDFTA_Click(object sender, EventArgs e)
        {
            dft_button.Enabled = true;
    
        }
        private void radioButtonDFTP_Click(object sender, EventArgs e)
        {
            dft_button.Enabled = true;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (radioButton3x3.Checked == true || radioButton5x5.Checked == true || radioButton7x7.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.loading;
                Application.DoEvents();
                double[] Seq2M = sequence2matrix(images_processed);
                if (radioButton3x3.Checked == true)
                    NativeMethods.Gauss(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                if (radioButton5x5.Checked == true)
                    NativeMethods.Gauss1(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                if (radioButton7x7.Checked == true)
                    NativeMethods.Gauss2(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                images_processed = matrix2sequence(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                image2.Image = images_processed[bar1.Value - 1];
                bar2.Value = bar1.Value;
                bar2_label.Text = "Processed images:" + bar1.Value.ToString() + " from " + (images_processed.Count);
                pictureBox1.Visible = false;

            }
            else
            {
                MessageBox.Show(String.Format("Please select appriopriate mask"), "", MessageBoxButtons.OK);
            }

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int n = bar2.Value;//10
           
                    label3.Text = trackBar2.Value.ToString();
                    contrast = 0.04f * trackBar2.Value;
                    Bitmap bm = new Bitmap(images_processed[0].Width, images_processed[0].Height);
                    Graphics g = Graphics.FromImage(bm);
                    ImageAttributes ia = new ImageAttributes();
                    ColorMatrix cm = new ColorMatrix(new float[][]{
                        new float[]{contrast,0f,0f,0f,0f},
                        new float[]{0f,contrast,0f,0f,0f},
                        new float[]{0f,0f,contrast,0f,0f},
                        new float[]{0f,0f,0f,1f,0f},
                        new float[]{0.001f,0.001f,0.001f,0f,1f}});
                    ia.SetColorMatrix(cm);
                    g.DrawImage(images_processed[0], new Rectangle(0, 0, images_processed[0].Width, images_processed[0].Height), 0, 0, images_processed[0].Width, images_processed[0].Height, GraphicsUnit.Pixel, ia);
                    g.Dispose();
                    ia.Dispose();
                   
                    image2.Image = bm;

           
           
        }

        private void dfta_click(object sender, EventArgs e)
        {
            dft_button.Enabled = true;
        }

        private void dftp_click(object sender, EventArgs e)
        {
            dft_button.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trackBar2.Enabled = true;
        }

        private void histogram_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Properties.Resources.loading;
            Application.DoEvents();
            double[] Im2M = sequence2matrix(images_processed);
            if (radioButton3x3.Checked == true)
            NativeMethods.Stretch(Im2M, images_processed[0].Width, images_processed[0].Height,images_processed.Count);
            images_processed = matrix2sequence(Im2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
            image2.Image = images_processed[bar1.Value - 1];
            bar2.Value = bar1.Value;
            bar2_label.Text = "Processed images:" + bar1.Value.ToString() + " from " + (images_processed.Count);
            pictureBox1.Visible = false;
        }
        private List<Bitmap> matrix2sequence1(double[] M, int W, int H,int Frames)
        {
            List<Bitmap> S = new List<Bitmap>();
            int R, G, B;
            Bitmap I = new Bitmap(W, H);
            int k = 0;
            
            Color K;
            for(int w = 0;w<Frames;w++)
            {

                for (int i = 0; i < I.Width; i++)
                {
                    for (int j = 0; j < I.Height; j++)
                    {

                        if (M[k] <= 20)
                        {
                            R = 255;
                            G = 0;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 84 && M[k] > 43)
                        {
                            R = 255;
                            G = 60;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 126 && M[k] > 85)
                        {
                            R = 255;
                            G = 110;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 168 && M[k] > 127)
                        {
                            R = 255;
                            G = 160;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 210 && M[k] > 169)
                        {
                            R = 255;
                            G = 210;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 256 && M[k] > 211)
                        {
                            R = 255;
                            G = 255;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else
                        {
                            R = 255;
                            G = 110;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }


                        k++;
                    }
                }
                S.Add(I);
                I = new Bitmap(W, H);
            }
            return S;
        }
        private List<Bitmap> matrix2sequence2(double[] M, int W, int H,int Frames)
        {
            List<Bitmap> S = new List<Bitmap>();
            int R, G, B;
            Bitmap I = new Bitmap(W, H);
            int k = 0;
            
            Color K;
            for (int w = 0; w < Frames; w++)
            {
                for (int i = 0; i < I.Width; i++)
                {
                    for (int j = 0; j < I.Height; j++)
                    {

                        if (M[k] <= 42)
                        {
                            R = 0;
                            G = 0;
                            B = 40;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 84 && M[k] > 43)
                        {
                            R = 0;
                            G = 40;
                            B = 82;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 126 && M[k] > 85)
                        {
                            R = 0;
                            G = 90;
                            B = 134;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 168 && M[k] > 127)
                        {
                            R = 0;
                            G = 135;
                            B = 178;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 189 && M[k] > 169)
                        {
                            R = 0;
                            G = 140;
                            B = 190;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 210 && M[k] > 190)
                        {
                            R = 0;
                            G = 182;
                            B = 210;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 230 && M[k] > 211)
                        {
                            R = 0;
                            G = 215;
                            B = 255;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 256 && M[k] > 231)
                        {
                            R = 0;
                            G = 255;
                            B = 255;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else
                        {
                            R = 0;
                            G = 135;
                            B = 178;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }


                        k++;
                    }
                }
                S.Add(I);
                I = new Bitmap(W, H);
            }
            return S;
        }
        private List<Bitmap> matrix2sequence3(double[] M, int W, int H,int Frames)
        {
            List<Bitmap> S = new List<Bitmap>();
            int R, G, B;
            Bitmap I = new Bitmap(W, H);
            int k = 0;
            
            Color K;
            for (int w = 0; w < Frames; w++)
            {
                for (int i = 0; i < I.Width; i++)
                {
                    for (int j = 0; j < I.Height; j++)
                    {

                        if (M[k] <= 42)
                        {
                            R = 0;
                            G = 0;
                            B = 96;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 84 && M[k] > 43)
                        {
                            R = 0;
                            G = 71;
                            B = 160;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 126 && M[k] > 85)
                        {
                            R = 101;
                            G = 71;
                            B = 160;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 168 && M[k] > 127)
                        {
                            R = 197;
                            G = 71;
                            B = 160;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 210 && M[k] > 169)
                        {
                            R = 237;
                            G = 156;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 256 && M[k] > 211)
                        {
                            R = 237;
                            G = 220;
                            B = 0;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else
                        {
                            R = 137;
                            G = 71;
                            B = 160;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }


                        k++;
                    }
                }
                S.Add(I);
                I = new Bitmap(W, H);
            }
            return S;
        }
        private List<Bitmap> matrix2sequence4(double[] M, int W, int H,int Frames)
        {
            List<Bitmap> S = new List<Bitmap>();
            int R, G, B;
            Bitmap I = new Bitmap(W, H);
            int k = 0;
            
            Color K;
            for (int w = 0; w < Frames; w++)
            {
                for (int i = 0; i < I.Width; i++)
                {
                    for (int j = 0; j < I.Height; j++)
                    {

                        if (M[k] <= 42)
                        {
                            R = 252;
                            G = 227;
                            B = 249;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 84 && M[k] > 43)
                        {
                            R = 252;
                            G = 37;
                            B = 249;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 126 && M[k] > 85)
                        {
                            R = 251;
                            G = 224;
                            B = 217;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 168 && M[k] > 127)
                        {
                            R = 251;
                            G = 224;
                            B = 4;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 210 && M[k] > 169)
                        {
                            R = 142;
                            G = 248;
                            B = 4;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 256 && M[k] > 211)
                        {
                            R = 0;
                            G = 248;
                            B = 4;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else
                        {
                            R = 251;
                            G = 224;
                            B = 141;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }


                        k++;
                    }
                }
                S.Add(I);
                I = new Bitmap(W, H);
            }
            return S;
        }
        private List<Bitmap> matrix2sequence5(double[] M, int W, int H,int Frames)
        {
            List<Bitmap> S = new List<Bitmap>();
            int R, G, B;
            Bitmap I = new Bitmap(W, H);
            int k = 0;
            
            Color K;
            for (int w = 0; w < Frames; w++)
            {
                for (int i = 0; i < I.Width; i++)
                {
                    for (int j = 0; j < I.Height; j++)
                    {

                        if (M[k] <= 42)
                        {
                            R = 0;
                            G = 0;
                            B = 255;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 84 && M[k] > 43)
                        {
                            R = 0;
                            G = 0;
                            B = 100;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 126 && M[k] > 85)
                        {
                            R = 0;
                            G = 120;
                            B = 100;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 168 && M[k] > 127)
                        {
                            R = 0;
                            G = 191;
                            B = 100;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 210 && M[k] > 169)
                        {
                            R = 177;
                            G = 189;
                            B = 100;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else if (M[k] <= 256 && M[k] > 211)
                        {
                            R = 255;
                            G = 155;
                            B = 100;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }
                        else
                        {
                            R = 0;
                            G = 120;
                            B = 100;
                            K = Color.FromArgb(R, G, B);
                            I.SetPixel(i, j, K);

                        }


                        k++;
                    }
                }
                S.Add(I);
                I = new Bitmap(W, H);
            }
            return S;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int n = bar2.Value;//10
            for (int i = 1; i <= (images_processed.Count-1); i++)
            {

                if (images_processed[n] == images_processed[i])//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                {
                    List<string> data = new List<string>();
                    data.Add("Autumn:  red orange yellow");
                    data.Add("Bone: gray scale with blue");
                    data.Add("Infrared: purple orange yellow blue");
                    data.Add("Summer: green yellow shades");
                    data.Add("Winter: blue green shades");
                    
                        if (comboBox1.Text== "Autumn:  red orange yellow")
                        {
                            double[] Im2M1 = sequence2matrix(images_processed);
                          //  Bitmap bm = new Bitmap(images_processed[i].Width, images_processed[i].Height);
                            images_processed = matrix2sequence1(Im2M1, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                            image2.Image = images_processed[bar1.Value - 1];
                        }
                        if (comboBox1.Text == "Bone: gray scale with blue")
                        {
                        double[] Im2M1 = sequence2matrix(images_processed);
                        //  Bitmap bm = new Bitmap(images_processed[i].Width, images_processed[i].Height);
                        images_processed = matrix2sequence2(Im2M1, images_processed[0].Width, images_processed[0].Height, images_processed.Count );
                        image2.Image = images_processed[bar1.Value - 1];
                    }
                        if (comboBox1.Text == "Infrared: purple orange yellow blue")
                        {
                        double[] Im2M1 = sequence2matrix(images_processed);
                        //  Bitmap bm = new Bitmap(images_processed[i].Width, images_processed[i].Height);
                        images_processed = matrix2sequence3(Im2M1, images_processed[0].Width, images_processed[0].Height, images_processed.Count );
                        image2.Image = images_processed[bar1.Value - 1];
                    }
                        if (comboBox1.Text == "Summer: green yellow shades")
                        {
                        double[] Im2M1 = sequence2matrix(images_processed);
                        //  Bitmap bm = new Bitmap(images_processed[i].Width, images_processed[i].Height);
                        images_processed = matrix2sequence4(Im2M1, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                        image2.Image = images_processed[bar1.Value - 1];
                    }
                        if (comboBox1.Text == "Winter: blue green shades")
                        {
                        double[] Im2M1 = sequence2matrix(images_processed);
                        //  Bitmap bm = new Bitmap(images_processed[i].Width, images_processed[i].Height);
                        images_processed = matrix2sequence5(Im2M1, images_processed[0].Width, images_processed[0].Height, images_processed.Count );
                        image2.Image = images_processed[bar1.Value - 1];
                    }
                    }
                }

            }

        private void button3_Click_2(object sender, EventArgs eH)
        {
            int n = bar2.Value;
            double[] Seq2M = sequence2matrix(images_processed);
            if (edgeX.Checked == true)
            NativeMethods.EdgeDetection1(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
            if (edgeY.Checked == true)
                NativeMethods.EdgeDetection(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
            if (edgeX_edgeY.Checked == true)
                NativeMethods.EdgeDetection2(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
            Scale2Image(ref Seq2M);
            images_processed = matrix2sequence(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
            image2.Image = images_processed[bar1.Value - 1];
            bar2.Value = bar1.Value;
            bar2_label.Text = "Processed images:" + bar1.Value.ToString() + " from " + (images_processed.Count);

        }
        private double[] sequence2matrix(List<Bitmap> S)
        {
            double[] SequenceToDouble1DTab = new double[S[0].Width * S[0].Height * S.Count];
            int l = 0;
            for (int k = 0; k < S.Count; k++)
            {
                for (int i = 0; i < S[0].Width; i++)
                {
                    for (int j = 0; j < S[0].Height; j++)
                    {
                        //Tak naprawdę mamy tylko obrazy w gray scale, więc obrazy 8-bitowe, jednowymiarowe. Wystarczy wziąć jeden kanał, żeby odczytać wszystkie dane
                        SequenceToDouble1DTab[l] = Convert.ToDouble(S[k].GetPixel(i, j).R);
                        l++;
                    }
                }
            }
            return SequenceToDouble1DTab;
        }
        private void Scale2Image(ref double[] Tab)
        {
            double min = Tab.Min();
            double max = Tab.Max();
            for (int i = 0; i < Tab.Length; i++)
            {
                Tab[i] = (Tab[i] - min) / (max - min) * 255;
            }
        }
        private List<Bitmap> matrix2sequence(double[] M, int W, int H, int Frames)
        {

            List<Bitmap> S = new List<Bitmap>();
            int l = 0;

            Color K;
            Bitmap I = new Bitmap(W, H);
            for (int k = 0; k < Frames; k++)
            {
                for (int i = 0; i < W; i++)
                {
                    for (int j = 0; j < H; j++)
                    {

                        int R = (int)M[l];
                        //Tym razem wszystkie kanały muszą być wypełnione (żeby nie następowała sztuczna zmiana koloru), ale mogą być tym samym
                        K = Color.FromArgb(R, R, R);
                        if (M[l] < 0)
                            M[l] = 0;
                        I.SetPixel(i, j, K);
                        l++;
                    }
                }
                S.Add(I);
                I = new Bitmap(W, H);
            }
            return S;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.loading;
                Application.DoEvents();
                double[] Seq2M = sequence2matrix(images_processed);
                if (radioButton1.Checked == true)
                    NativeMethods.Derivative(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                if (radioButton2.Checked == true)
                    NativeMethods.Derivative2(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                Scale2Image(ref Seq2M);
                images_processed = matrix2sequence(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                image2.Image = images_processed[bar1.Value - 1];
                bar2.Value = bar1.Value;
                bar2_label.Text = "Processed images:" + bar1.Value.ToString() + " from " + (images_processed.Count);
                pictureBox1.Visible = false;
            }
            else
            {
                MessageBox.Show(String.Format("Please select appriopriate function"), "", MessageBoxButtons.OK);
            }
          
        }

        private void bar2_Scroll(object sender, ScrollEventArgs e)
        {
            int zmienna = images_processed.Count;
                    bar2_label.Text = "Processed images: " + bar2.Value.ToString() + " from " + zmienna;
                    image2.Image = images_processed[bar2.Value-1];
        }

        private void dft_button_Click(object sender, EventArgs e)
        {
            if (radioButtonDFTA.Checked == true || radioButtonDFTP.Checked == true)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Properties.Resources.loading;
                Application.DoEvents();
                double[] Seq2M = sequence2matrix(images_processed);
                if (radioButtonDFTA.Checked == true)
                    NativeMethods.DFT_AMP(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                if (radioButtonDFTP.Checked == true)
                    NativeMethods.DFT_PHR(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                Scale2Image(ref Seq2M);
                images_processed = matrix2sequence(Seq2M, images_processed[0].Width, images_processed[0].Height, images_processed.Count);
                image2.Image = images_processed[bar1.Value - 1];
                bar2.Value = bar1.Value;
                bar2_label.Text = "Processed images:" + bar1.Value.ToString() + " from " + (images_processed.Count );
                pictureBox1.Visible = false;
            }
            else
            {
                MessageBox.Show(String.Format("Please select appriopriate function"), "", MessageBoxButtons.OK);
            }
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(checkBox4.Checked==true && checkBox5.Checked==true)
                MessageBox.Show(String.Format("Please select only one way of saving"), "", MessageBoxButtons.OK);

            if (checkBox4.Checked==true)
            {
                for (int i = 0; i <= images_processed.Count; i++)
                    images_processed[i].Save($@"C:\Users\Marcin\Desktop\janusz52\image{i}.tiff", ImageFormat.Tiff);
                MessageBox.Show("Images_processed Saved...");
            }
            if (checkBox5.Checked == true)
            {
                 image2.Image.Save(@"C:\Temp\pic.tiff", System.Drawing.Imaging.ImageFormat.Tiff);
                MessageBox.Show("Image_Saved...");
            }
            if (checkBox4.Checked == false && checkBox5.Checked == false)
                MessageBox.Show(String.Format("Please select way of saving"), "", MessageBoxButtons.OK);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if(checkBox3.Checked ==false && checkBox2.Checked == false)
                MessageBox.Show(String.Format("Please select appropriate checkBox"), "", MessageBoxButtons.OK);
            if (checkBox3.Checked == true)
            { 
                int n = bar2.Value;
                for (int b = 1; b <= (images_processed.Count-1); b++)
                {
                    if (images_processed[n] == images_processed[b])//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    {
                        Bitmap histogram = new Bitmap(images3.Width,images3.Height);
                        Bitmap bmpPrzed = new Bitmap(images_processed[b]);

                        int[] tablica = new int[256];

                        int max = 0;
                        for (int x = 0; x < bmpPrzed.Width; x++)
                        {
                            for (int y = 0; y < bmpPrzed.Height; y++)
                            {
                                // liczymy ilosc kolorow
                                Color cPixel = bmpPrzed.GetPixel(x, y);
                                int zmienna = cPixel.B;

                                tablica[zmienna]++;
                            }
                        }

                        for (int i = 0; i < 256; i++)
                        {
                            if (tablica[i] > max)
                            {
                                max = tablica[i];
                            }
                        }

                        Graphics g;
                        g = Graphics.FromImage(histogram);
                        g.FillRectangle(Brushes.White, 0, 0, histogram.Width,
            histogram.Height);

                        double Procent = max / histogram.Height;
                        for (int i = 0; i < 256; i++)
                        {
                            float Height2 = images3.Height - (float)(tablica[i] / Procent);
                            Pen mypen = new Pen(Brushes.Black, 4);
                            g.DrawLine(mypen, 0, 1, 0, 255);
                            g.DrawLine(mypen, 0, 239, 239, 239);
                            g.DrawLine(Pens.Blue, i, images3.Height, i, Height2);

                            images3.Image = histogram;
                            images3.Invalidate();

                            images3.Refresh();
                        }
                    }
                }

            }
            if(checkBox2.Checked == true )
            {
                if (images_processed.Count>0 )
                {
                    int n = bar2.Value;
                    for (int b = 1; b <= (images_processed.Count-1); b++)
                    {
                        if (images_processed[n] == images_processed[b])//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        {
                            Bitmap histogram = new Bitmap(images3.Width,
        images3.Height);
                            Bitmap bmpPrzed = new Bitmap(images_processed[b]);

                            int[] tablica = new int[256];
                            int min = 0;
                            int max1 = 0;
                            int max = 0;
                            int[,] wart = new int[bmpPrzed.Width, bmpPrzed.Height];
                            for (int x = 0; x < bmpPrzed.Width; x++)
                            {
                                for (int y = 0; y < bmpPrzed.Height; y++)
                                {
                                    // liczymy ilosc kolorow
                                    Color cPixel = bmpPrzed.GetPixel(x, y);
                                    int zmienna = cPixel.B;
                                    if (min > zmienna )//wynik minimalny
                                    {
                                        min = zmienna;
                                    }
                                    if (max1 < zmienna)//wynik maksymalny
                                    {
                                        max1 = zmienna;
                                    }
                                    
                                    tablica[zmienna]++;
                                }
                            }

                            for (int i = 0; i < 256; i++)
                            {
                                if (tablica[i] > max)
                                {
                                    max = tablica[i];
                                }
                            }

                            Graphics g;
                            g = Graphics.FromImage(histogram);
                            g.FillRectangle(Brushes.White, 0, 0, histogram.Width,
                histogram.Height);

                            double Procent = max / histogram.Height;
                            for (int i = 0; i < 256; i++)
                            {
                                float Height2 = images3.Height - (float)(((255 * (tablica[i] - min)) / max1 - min) / Procent);
                                Pen mypen = new Pen(Brushes.Black, 4);
                                g.DrawLine(mypen, 0, 1, 0, 255);
                                g.DrawLine(mypen, 0, 239, 239, 239);
                                g.DrawLine(Pens.Blue, i, images3.Height, i, Height2);

                               
                            }
                            images3.Image = histogram;
                            images3.Invalidate();

                            images3.Refresh();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("Try again this function"), "", MessageBoxButtons.OK);
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if((checkBox1.Checked == false))
            {
                label16.Visible = false;
                label15.Visible = false;
                label14.Visible = false;
                label13.Visible = false;
                label12.Visible = false;
                label11.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label1.Visible = false;
                label18.Visible = false;
                label17.Visible = false;
            }
            else
            {
                label16.Visible = true;
                label15.Visible = true;
                label14.Visible = true;
                label13.Visible = true;
                label12.Visible = true;
                label11.Visible = true;
                label10.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                label1.Visible = true;
                label18.Visible = true;
                label17.Visible = true;
            }
        }

    }

       
    }

