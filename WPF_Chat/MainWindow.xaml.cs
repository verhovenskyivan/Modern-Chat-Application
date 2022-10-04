using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using AForge.Video;
using System.Security.Cryptography.X509Certificates;
using System.Drawing;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;

namespace WPF_Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
            this.Cursor = Cursors.Hand;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            this.Cursor = Cursors.Hand;
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            this.Cursor = Cursors.Hand;
        }

        private void UploadButton_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image Files|* .bmp;*. jpg;*.png;*.jpeg";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == true)
            {
                imagePicture.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
            this.Cursor = Cursors.Hand;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)


        {
            [DllImport("winmm.dll", EntryPoint = "mciSendStringA", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);

            static void Main(string[] args)
            {
                mciSendString("open new Type waveaudio Alias recsound", "", 0, 0);
                mciSendString("record recsound", "", 0, 0);
                Console.WriteLine("recording, press Enter to stop and save ...");
                Console.ReadLine();

                mciSendString("save recsound c:\\work\\result.wav", "", 0, 0);
                mciSendString("close recsound ", "", 0, 0);
            }
        }

        public partial class Form1 : Form
        {

            MJPEGStream stream;
            public Form1()
            {
                Initializecomponent();
                stream = new MJPEGStream("http://192.168.1.120/action/stream?subject=mjpeg&user=admin&pwd=12345");
                stream.NewFrame += GetNewFrame;

            }

            private void Initializecomponent()
            {
                throw new NotImplementedException();
            }

            void GetNewFrame(object sender, NewFrameEventArgs eventarg)
            {
                Bitmap bmp = (Bitmap)eventarg.Frame.Clone();
                pictureBox1.Image = bmp;
            }

            private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
            {
                stream.Start();
            }
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            videoCaptureDevice= new VideoCaptureDevice(filterInfoCollection[cboCamera.Selecte]);
        }

        private void Image_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
    }

    public class Form
    {
    }
}
 
    
   

