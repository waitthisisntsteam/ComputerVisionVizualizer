using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVisionVizualizer.Controls
{
    [CvControlDisplayNameAttribute("Video Capture")]
    public partial class Camera : CVIOBase
    {
        private VideoCapture Video;

        public Camera()
        {
            InitializeComponent();

            Video = new VideoCapture(0);
            Video.Set(CapProp.FrameWidth, 1080);
            Video.Set(CapProp.FrameHeight, 720);
            Video.Set(CapProp.Exposure, -6);


            Application.Idle += GetFrame;
        }

        private void GetFrame(object sender, EventArgs e)
        {
            Mat currentFrame = Video.QueryFrame();
            CameraBox.Image = currentFrame;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TakePic_Click(object sender, EventArgs e) => TakenPicture.SetImage(Video.QueryFrame());
    }
}
