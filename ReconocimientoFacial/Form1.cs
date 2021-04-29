using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace ReconocimientoFacial
{
    public partial class Form1 : Form
    {
        //Variables
        int testid = 0;
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        private bool facesDetectionEnabled = false;
        CascadeClassifier faceCasacdeClassifier = new CascadeClassifier(@"C:\Users\luis_\source\repos\ReconocimientoFacial\ReconocimientoFacial\haarcascade_frontalface_alt.xml");
        Image<Bgr, Byte> faceResult = null;
        List<Image<Gray, Byte>> TrainedFaces = new List<Image<Gray, byte>>();
        List<int> PersonsLabes = new List<int>();

        bool EnableSaveImage = false;
        private bool isTrained = false;
        EigenFaceRecognizer recognizer;
        List<string> PersonsNames = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (videoCapture != null) videoCapture.Dispose();
            videoCapture = new Capture();
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            //Captura del video
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, Byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);


                if (facesDetectionEnabled)
                {

                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);

                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);

                    if (faces.Length > 0)
                    {

                        foreach (var face in faces)
                        {
                            Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                            resultImage.ROI = face;
                            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                            pictureBox2.Image = resultImage.Bitmap;

                            if (EnableSaveImage)
                            {
                                //Aqui se crea el directorio si no existe
                                string path = Directory.GetCurrentDirectory() + @"\Imagenes";
                                if (!Directory.Exists(path))
                                    Directory.CreateDirectory(path);

                                Task.Factory.StartNew(() => {
                                    for (int i = 0; i < 10; i++)
                                    {
                                        resultImage.Resize(200, 200, Inter.Cubic).Save(path + @"\" + txtName.Text + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg");
                                        Thread.Sleep(1000);
                                    }
                                });

                            }
                            EnableSaveImage = false;

                            if (btnAdd.InvokeRequired)
                            {
                                btnAdd.Invoke(new ThreadStart(delegate {
                                    btnAdd.Enabled = true;
                                }));
                            }


                            if (isTrained)
                            {
                                Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                pictureBox2.Image = grayFaceResult.Bitmap;
                                pictureBox3.Image = TrainedFaces[result.Label].Bitmap;
                                Debug.WriteLine(result.Label + ". " + result.Distance);

                                if (result.Label != -1 && result.Distance < 2000)
                                {
                                    CvInvoke.PutText(currentFrame, PersonsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                                }

                                else
                                {
                                    CvInvoke.PutText(currentFrame, "Desconocido", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                                }
                            }
                        }
                    }
                }

                pictureBox1.Image = currentFrame.Bitmap;
            }

            if (currentFrame != null)
                currentFrame.Dispose();
        }

        private void btnDeteccion_Click(object sender, EventArgs e)
        {
            facesDetectionEnabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            EnableSaveImage = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnAdd.Enabled = true;
            EnableSaveImage = false;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            TrainImagesFromDir();
        }

        private bool TrainImagesFromDir()
        {
            int ImagesCount = 0;
            double Threshold = 2000;
            TrainedFaces.Clear();
            PersonsLabes.Clear();
            PersonsNames.Clear();
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\Imagenes";
                string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    Image<Gray, byte> trainedImage = new Image<Gray, byte>(file).Resize(200, 200, Inter.Cubic);
                    CvInvoke.EqualizeHist(trainedImage, trainedImage);
                    TrainedFaces.Add(trainedImage);
                    PersonsLabes.Add(ImagesCount);
                    string name = file.Split('\\').Last().Split('_')[0];
                    PersonsNames.Add(name);
                    ImagesCount++;
                    Debug.WriteLine(ImagesCount + ". " + name);

                }

                if (TrainedFaces.Count() > 0)
                {
                    recognizer = new EigenFaceRecognizer(ImagesCount, Threshold);
                    recognizer.Train(TrainedFaces.ToArray(), PersonsLabes.ToArray());

                    isTrained = true;
                    return true;
                }
                else
                {
                    isTrained = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                return false;
            }

        }
    }
}
