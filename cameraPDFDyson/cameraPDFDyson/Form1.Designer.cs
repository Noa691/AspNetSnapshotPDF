namespace cameraPDFDyson
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxCameras = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolderText = new System.Windows.Forms.Label();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.imgPrevius = new System.Windows.Forms.PictureBox();
            this.btnSnapshot = new System.Windows.Forms.Button();
            this.btnActivateCamera = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevius)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(303, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxCameras
            // 
            this.comboBoxCameras.FormattingEnabled = true;
            this.comboBoxCameras.Location = new System.Drawing.Point(995, 63);
            this.comboBoxCameras.Name = "comboBoxCameras";
            this.comboBoxCameras.Size = new System.Drawing.Size(222, 24);
            this.comboBoxCameras.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFolderText);
            this.panel1.Controls.Add(this.btnRotate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtTracking);
            this.panel1.Controls.Add(this.imgPrevius);
            this.panel1.Controls.Add(this.btnSnapshot);
            this.panel1.Controls.Add(this.btnActivateCamera);
            this.panel1.Controls.Add(this.comboBoxCameras);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 844);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(499, 772);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folder: ";
            // 
            // txtFolderText
            // 
            this.txtFolderText.AutoSize = true;
            this.txtFolderText.BackColor = System.Drawing.Color.Black;
            this.txtFolderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderText.ForeColor = System.Drawing.Color.Lime;
            this.txtFolderText.Location = new System.Drawing.Point(609, 772);
            this.txtFolderText.Name = "txtFolderText";
            this.txtFolderText.Size = new System.Drawing.Size(0, 29);
            this.txtFolderText.TabIndex = 9;
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(254)))));
            this.btnRotate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRotate.Location = new System.Drawing.Point(44, 562);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(240, 47);
            this.btnRotate.TabIndex = 8;
            this.btnRotate.Text = "Rotate 90°";
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(254)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(44, 704);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 47);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save snap>>";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTracking
            // 
            this.txtTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTracking.Location = new System.Drawing.Point(44, 647);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(240, 30);
            this.txtTracking.TabIndex = 6;
            this.txtTracking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTracking_KeyDown);
            // 
            // imgPrevius
            // 
            this.imgPrevius.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgPrevius.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPrevius.Location = new System.Drawing.Point(44, 283);
            this.imgPrevius.Name = "imgPrevius";
            this.imgPrevius.Size = new System.Drawing.Size(240, 244);
            this.imgPrevius.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPrevius.TabIndex = 5;
            this.imgPrevius.TabStop = false;
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(254)))));
            this.btnSnapshot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnapshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnapshot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSnapshot.Location = new System.Drawing.Point(44, 203);
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.Size = new System.Drawing.Size(240, 47);
            this.btnSnapshot.TabIndex = 4;
            this.btnSnapshot.Text = "Snapshot";
            this.btnSnapshot.UseVisualStyleBackColor = false;
            this.btnSnapshot.Click += new System.EventHandler(this.btnSnapshot_Click);
            // 
            // btnActivateCamera
            // 
            this.btnActivateCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(254)))));
            this.btnActivateCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivateCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateCamera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActivateCamera.Location = new System.Drawing.Point(44, 112);
            this.btnActivateCamera.Name = "btnActivateCamera";
            this.btnActivateCamera.Size = new System.Drawing.Size(240, 47);
            this.btnActivateCamera.TabIndex = 3;
            this.btnActivateCamera.Text = "Activate camera";
            this.btnActivateCamera.UseVisualStyleBackColor = false;
            this.btnActivateCamera.Click += new System.EventHandler(this.btnActivateCamera_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1211, 822);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dev by Dev IT RLJones ELP ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 842);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DysonCameraPDF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrevius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxCameras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSnapshot;
        private System.Windows.Forms.Button btnActivateCamera;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.PictureBox imgPrevius;
        private System.Windows.Forms.Label txtFolderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

