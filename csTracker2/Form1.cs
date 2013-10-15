using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Emgu voor color tracking
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

//voor UDP pakketten door te sturen
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace csTracker2
{
    public partial class Form1 : Form
    {
        //capture device
        Capture capWebcam = null;
        //see if its capturing
        bool blnCapturingProcess = false;
        Image<Bgr, Byte> imgOriginal;
        Image<Gray, Byte> imgProcessed;
        //image in HSV
        Image<Hsv, Byte> imgHSVOriginal;

        //Trackbar intputs
        int minH, minS, minV, maxH, maxS, maxV;
        //radius of the circles
        int minRadius, maxRadius;
        int intAccum, intCanny;

        //Sending
        IPAddress ip;
        int portNr;
        bool bSendPackets = false;

        //when to send the package
        int intSendTime = 3;
        int intframe = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                initializedValues();

                capWebcam = new Capture();  //associate capture object to the default webcam
            }
            catch (NullReferenceException except) //catch error if unsucessfull
            {
                txtXYRadius.Text = except.Message;  //show error object message in text box
                return;
            }
         //once we have a good capture object
            Application.Idle += processFrameAndUpdateGUI; //add precess image function to the application's list of tasks
            blnCapturingProcess = true; //update member flag variable
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (capWebcam != null)
            {
                capWebcam.Dispose();
            }
        }

        void processFrameAndUpdateGUI(object sender, EventArgs arg)
        {
            imgOriginal = capWebcam.QueryFrame(); //get the next frame from the webcam
            imgHSVOriginal = imgOriginal.Convert<Hsv, Byte>();
            if (imgOriginal == null) return; //if we did not get a frame, bail
            //imgProcessed = imgOriginal.InRange(new Bgr(minB, minG, minR), new Bgr(maxB, maxG, maxR)); //min filter value( if color is greater than or equal to this), maxfilter value(if color is less or equal to this
            imgProcessed = imgHSVOriginal.InRange(new Hsv(minH, minS, minV), new Hsv(maxH, maxS, maxV));
            imgProcessed = imgProcessed.SmoothGaussian(9); //we call SmoothGaussian with only 1 param, that begin the x and y size of the filterwindow
            //CvInvoke.cvShowImage("Threshold Image", imgProcessed);
            CircleF[] circles = imgProcessed.HoughCircles(new Gray(intCanny),        //canny threshold new Gray(100)
                                                          new Gray(intAccum),         //accumulator threshold new Gray(50)
                                                          2,                    //size of the image / this param = "accumulator resolution"
                                                          imgProcessed.Height / 4, //min distance in pixels between the center of the detexted circles
                                                          minRadius,                   //min radius of the detected circles
                                                          maxRadius)[0];              //max radius of the detected circles, get cirles from the first channel

            foreach (CircleF circle in circles)
            {
                                        //draw a small green circle at the center of the detected object
                                        //to do this, we will call the openCV 1.x function, this is necessary b/c
                                        //we are drawing a circle of radius 3, even though the size of the detected circle will be much bigger
                                        //the CVInvoke object can be used to make openCV 1.x function calls
                CvInvoke.cvCircle(imgOriginal,                  //draw on the original image
                                  new Point((int)circle.Center.X, (int)circle.Center.Y), //center point of the circle
                                  3,                                 //radius of circle in pixels
                                  new MCvScalar(0, 255, 0),          //draw pure green
                                  -1,                                //thickness of the circle in pixels, -11 indicates to fill the circle
                                  LINE_TYPE.CV_AA,                   //use aa to smooth the pixels
                                  0);                                //no shift
            
                                        //draw a red circle around the detected object
                imgOriginal.Draw(circle,                    //current circle we are on the for each loop
                                 new Bgr(Color.Red),        //draw pure red
                                 3);                        //thickness of the circle in pixels
            }//end foreach
            ibOriginal.Image = imgOriginal;
            ibProcessed.Image = imgProcessed;

            intframe++;
            //if bool is true and current frame equal or bigger then sendtimemax
            if (bSendPackets && intframe >= intSendTime  )
            {
                intframe = 0;
                //UDP Packets
                byte[] packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(circles.Length.ToString());

                IPEndPoint ep = new IPEndPoint(ip, portNr);

                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                client.SendTo(packetData, ep);
            }
        }
        private void initializedValues()
        {
            //default values
            minH = tbMinH.Value;
            minS = tbMinS.Value;
            minV = tbMinV.Value;
            maxH = tbMaxH.Value;
            maxS = tbMaxS.Value;
            maxV = tbMaxV.Value;
            intCanny = tbCanny.Value;
            intAccum = tbAccu.Value;
            minRadius = tbMinRadius.Value;
            maxRadius = tbMaxRadius.Value;

            lblminH.Text = tbMinH.Value.ToString();
            lblminS.Text = tbMinS.Value.ToString();
            lblminV.Text = tbMinV.Value.ToString();

            lblmaxH.Text = tbMaxH.Value.ToString();
            lblMaxS.Text = tbMaxS.Value.ToString();
            lblMaxV.Text = tbMaxV.Value.ToString();

            lblCanny.Text = tbCanny.Value.ToString();
            lblAccum.Text = tbAccu.Value.ToString();
        }
        private void btnPauseOrPlay_Click(object sender, EventArgs e)
        {
            if (blnCapturingProcess == true)    //if we are currently processing an image, user just choose pause, so..
            {
                Application.Idle -= processFrameAndUpdateGUI;       //remove the process image function from the application
                blnCapturingProcess = false;                        //update flag variable
                btnPauseOrPlay.Text = "Resume";
            }
            else
            {
                Application.Idle += processFrameAndUpdateGUI;       //add the process image function from the application
                blnCapturingProcess = true;                         //update flag variable
                btnPauseOrPlay.Text = "Pause";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            minH = tbMinH.Value;
            lblminH.Text = tbMinH.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            minS = tbMinS.Value;
            lblminS.Text = tbMinS.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            minV = tbMinV.Value;
            lblminV.Text = tbMinV.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            maxH = tbMaxH.Value;
            lblmaxH.Text = tbMaxH.Value.ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            maxS = tbMaxS.Value;
            lblMaxS.Text = tbMaxS.Value.ToString();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            maxV = tbMaxV.Value;
            lblMaxV.Text = tbMaxV.Value.ToString();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            minRadius = tbMinRadius.Value;
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            maxRadius = tbMaxRadius.Value;
        }

        private void tbCanny_Scroll(object sender, EventArgs e)
        {
            intCanny = tbCanny.Value;
            lblCanny.Text = tbCanny.Value.ToString();
        }

        private void tbAccu_Scroll(object sender, EventArgs e)
        {
            intAccum = tbAccu.Value;
            lblAccum.Text = tbAccu.Value.ToString();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //if ip adres can be parsed and port can be parsed
            if (IPAddress.TryParse(txtIp.Text, out ip) && int.TryParse(txtPortNr.Text, out portNr))
            {
                bSendPackets = !bSendPackets;
                
            }
           
            btnSend.Text = (bSendPackets) ? "Stop Send" : "Send";
        }
    }
}
