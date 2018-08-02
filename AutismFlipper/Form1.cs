using IronOcr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace AutismFlipper
{
    public partial class Form1 : Form
    {
        public Bitmap a;
        public DateTime start;
        public DateTime compare;
        public DateTime lastTimeStamp;
        public String lastLine;
        public Form1()
        {
            InitializeComponent();
            setTimeStamp();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            string currency_value;
            using (FileStream stream = File.Open(@"C:\Program Files (x86)\Grinding Gear Games\Path of Exile\logs\Client.txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    if(lastLine != null)
                    {
                        while ((line = reader.ReadLine()) != null)
                            if (line == lastLine)
                                break;
                    }
                    while ((line = reader.ReadLine()) != null)
                    {

                        if (line.Contains("Hi, I'd like to buy your"))
                        {
                            textBox1.AppendText(line + Environment.NewLine);
                            currency_value = ExtractBetweenTwoStrings(line, "Hi, I'd like to buy your ", " for my", false, false);
                            textBox2.AppendText(currency_value + Environment.NewLine);
                            string[] message_split = currency_value.Split(' ');
                            Stash stash = new Stash(message_split[1], Int32.Parse(message_split[0]));
                            //group invite

                        }


                        if (line.Contains("has joined the area"))
                        {
                            textBox1.AppendText(line + Environment.NewLine);
                            // trade invite
                        }

                        lastLine = line;
                    }
                }
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            String procName = "PathOfExile_x64";
            Process[] procs = Process.GetProcessesByName(procName);
            var rect = new User32.Rect();
            int width = 0;
            int height = 0;

            foreach (Process proc in procs)
            {
                User32.GetWindowRect(proc.MainWindowHandle, ref rect);
                width = rect.right - rect.left;
                height = rect.bottom - rect.top;
                Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);

                Graphics graphics = Graphics.FromImage(bmp);
                graphics.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                pictureBox1.Image = bmp;
                a = bmp;
                bmp.Save("asd.png", System.Drawing.Imaging.ImageFormat.Png);
                // break foreach if an realistic rectangle found => main process found
                if (width != 0 && height != 0)
                {
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 312;
            int y = 205;
            int width = 51;
            int height = 51;
            int k = 0;
            Bitmap croppedImage;
            Rectangle crop;
            Size size = new Size(16, 16);
            for (int i = 0; i < 11; i++)
            {

                y = 205;
                for (int j = 0; j < 5; j++)
                {

                   crop = new Rectangle(x, y, width, height);
                   croppedImage = a.Clone(crop, a.PixelFormat);
                   croppedImage.Save(k+".png", System.Drawing.Imaging.ImageFormat.Png);
                   k++;
                   y += 53;
                }
                x += 53;
            }
        }
        public void setTimeStamp()
        {
            start = DateTime.Now;
            String year = start.Year.ToString();
            String month = start.Month.ToString();
            String day = start.Day.ToString();
            String hour = start.Hour.ToString();
            String minute = start.Minute.ToString();
            String second = start.Second.ToString();
            if (month.Length == 1)
                month = "0" + month;
            if (day.Length == 1)
                day = "0" + day;
            if (hour.Length == 1)
                hour = "0" + hour;
            if (minute.Length == 1)
                minute = "0" + minute;
            if (second.Length == 1)
                second = "0" + second;

            lastTimeStamp = start;
            label2.Text = year + "/" + month + "/" + day + " " + hour + ":" + minute + ":" + second;

        }

        public static string ExtractBetweenTwoStrings(string FullText, string StartString, string EndString, bool IncludeStartString, bool IncludeEndString)
        {
            try
            {
                int Pos1 = FullText.IndexOf(StartString) + StartString.Length;
                int Pos2 = FullText.IndexOf(EndString, Pos1);
                return ((IncludeStartString) ? StartString : "") + FullText.Substring(Pos1, Pos2 - Pos1) + ((IncludeEndString) ? EndString : "");
            }
            catch (Exception ex)
            { return ex.ToString(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //stash
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //chaos
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
            Bitmap b = (Bitmap)Image.FromFile(@"C:\Users\Daniel\Desktop\4.png", true);
            var page = ocr.Process(b);
            textBox2.Text = page.GetText();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
