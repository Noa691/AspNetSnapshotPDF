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
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Google.Cloud.Vision.V1;
using Image = Google.Cloud.Vision.V1.Image;
using AForge.Imaging.Filters;
using Rectangle = System.Drawing.Rectangle;




namespace cameraPDFDyson
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public bool validateCameraActive = false;
       

        public Form1()
        {
            InitializeComponent();
            
            LoadCameraDevices();
            SetPlaceholderText(txtTracking, "Type your tracking here");
            PersonalizeButtons();
            txtFolderText.Text = "C:\\DysonTrackingLabel";
            btnSnapshot.Enabled = false;

            // Iniciar la cámara automáticamente al cargar el formulario
        }

        

        private void SetPlaceholderText(TextBox textBox, string placeholderText)
        {
            // Establecer el texto de marcador de posición
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            // Asociar eventos para gestionar el texto de marcador de posición
            textBox.Enter += (s, e) => { if (textBox.Text == placeholderText) textBox.Text = string.Empty; textBox.ForeColor = Color.Black; };
            textBox.Leave += (s, e) => { if (textBox.Text == string.Empty) textBox.Text = placeholderText; };
        }
        private void PersonalizeButtons()
        {
            btnActivateCamera.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 254); // Cambia el color del borde de contorno
            btnActivateCamera.FlatAppearance.BorderSize = 1; // Puedes ajustar el grosor del borde si lo deseas
            btnActivateCamera.FlatStyle = FlatStyle.Flat;
            btnActivateCamera.UseVisualStyleBackColor = false;

            btnRotate.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 254); // Cambia el color del borde de contorno
            btnRotate.FlatAppearance.BorderSize = 1; // Puedes ajustar el grosor del borde si lo deseas
            btnRotate.FlatStyle = FlatStyle.Flat;
            btnRotate.UseVisualStyleBackColor = false;

            btnSnapshot.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 254); // Cambia el color del borde de contorno
            btnSnapshot.FlatAppearance.BorderSize = 1; // Puedes ajustar el grosor del borde si lo deseas
            btnSnapshot.FlatStyle = FlatStyle.Flat;
            btnSnapshot.UseVisualStyleBackColor = false;

            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 128, 254); // Cambia el color del borde de contorno
            btnSave.FlatAppearance.BorderSize = 1; // Puedes ajustar el grosor del borde si lo deseas
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.UseVisualStyleBackColor = false;

            comboBoxCameras.Visible = false;

        }


        
        private void LoadCameraDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                comboBoxCameras.Items.Add(device.Name);
            }

            if (comboBoxCameras.Items.Count > 0)
                comboBoxCameras.SelectedIndex = 0;
        }

        private void StartCamera()
        {
            if (comboBoxCameras.SelectedIndex >= 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[comboBoxCameras.SelectedIndex].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSource.Start();
               
            }
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bitmap;
        }

       


        private void btnActivateCamera_Click(object sender, EventArgs e)
        {
            if (!validateCameraActive)
            {
                // Iniciar la cámara
                if (StartCamera2())
                {
                    btnActivateCamera.Text = "DeActive cam";
                    validateCameraActive = true;
                    btnSnapshot.Enabled = true;
                }
                // Puedes manejar cualquier lógica adicional si el inicio de la cámara falla
            }
            else
            {
                // Detener la cámara
                StopCamera();
                validateCameraActive = false;
                btnActivateCamera.Text = "Activate cam";
            }

        }

        private bool StartCamera2()
        {
            try
            {
                // Lógica para iniciar la cámara (puedes usar tu propia implementación)
                // videoSource.Start();
                // Puedes agregar más lógica según tus necesidades
                StartCamera();
                return true; // Indica que la cámara se inició con éxito
            }
            catch (Exception ex)
            {
                // Manejar la excepción, si ocurre alguna
                MessageBox.Show("Mistake when try to init camera<< " + ex.Message, "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Indica que hubo un error al iniciar la cámara
            }
        }

        private void StopCamera()
        {
            videoSource.Stop();
            pictureBox1.Image = null;
            btnSnapshot.Enabled = false;
        }






        private void TakeSnapShot()
        {
            if (validateCameraActive)
            {
                 // Tomar la foto
                  Bitmap img = (Bitmap)pictureBox1.Image.Clone();
                  // Rotar la imagen
                  img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                  // Mostrar la imagen en el PictureBox llamado imgPrevius
                  imgPrevius.Image = img;
                  StopCamera();
                  validateCameraActive = false;
                  btnActivateCamera.Text = "Activate cam";
                  txtTracking.Focus();
                 // Tomar la foto


            }
            else
            {
                MessageBox.Show("Please activate camera first<<", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private void btnSnapshot_Click(object sender, EventArgs e)
        {
            TakeSnapShot();
        }

        private void RotatePicture()
        {
            if (imgPrevius.Image != null)
            {
                // Obtener la imagen actual del PictureBox
                Bitmap imagenActual = (Bitmap)imgPrevius.Image.Clone();

                // Rotar la imagen en sentido contrario a las agujas del reloj (en sentido antihorario)
                imagenActual.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // Mostrar la imagen rotada en el PictureBox
                imgPrevius.Image = imagenActual;
            }
            else
            {
                MessageBox.Show("No image to rotate<<", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ;
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            RotatePicture();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SavePhoto();

        }


        private void SavePhoto()
        {
            // Obtener el texto de los cuadros de texto
            string trackingText = txtTracking.Text.Trim();
            string folderText = txtFolderText.Text.Trim();

            // Verificar que haya un texto en ambos cuadros de texto
            if (string.IsNullOrEmpty(trackingText) || string.IsNullOrEmpty(folderText) || txtTracking.Text== "Type your tracking here")
            {
                MessageBox.Show("Please select Folder / scan tracking number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener la ruta del directorio de la aplicación
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Construir la ruta completa al script de Python
            string pythonScriptPath = Path.Combine(appDirectory, "generatePDF.py");

            // Construir la ruta completa a la imagen temporal y al PDF de salida
            string tempImagePath = Path.Combine(folderText, $"{trackingText}_temp.png");
            string pdfOutputPath = Path.Combine(folderText, $"{trackingText}.pdf");

            if(imgPrevius.Image == null)
            {
                MessageBox.Show("Please take a photo first<<", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Guardar la imagen del PictureBox en un archivo temporal
            imgPrevius.Image.Save(tempImagePath, System.Drawing.Imaging.ImageFormat.Png);

            // Crear el documento PDF con iTextSharp
            using (FileStream fs = new FileStream(pdfOutputPath, FileMode.Create))
            {
                using (Document document = new Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    float marginInPoints = 36;
                    
                    document.SetMargins(marginInPoints, marginInPoints, marginInPoints, marginInPoints);

                    // Convertir la imagen a un formato que iTextSharp pueda manejar
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(tempImagePath)))
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());

                        // Ajustar la escala de la imagen para que se ajuste al área restante después de establecer los márgenes
                        float maxWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                        float maxHeight = document.PageSize.Height - document.TopMargin - document.BottomMargin;

                        img.ScaleToFit(maxWidth, maxHeight);

                        // Agregar la imagen al documento PDF
                        document.Add(img);
                    }
                }
            }

            // Eliminar la imagen temporal después de usarla
            File.Delete(tempImagePath);
            txtTracking.Text = "";
            imgPrevius.Image = null;
            SetPlaceholderText(txtTracking, "Type your tracking here");
            btnSnapshot.Enabled = false;
            MessageBox.Show($"Successfully image saved in>> {pdfOutputPath}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
            }

        }

        private void txtTracking_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SavePhoto();
            }
        }
    }

}
