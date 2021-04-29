
namespace ReconocimientoFacial
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnDeteccion = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.txtAptooo = new System.Windows.Forms.Label();
            this.txtApto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 293);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(15, 33);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(245, 54);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "Abrir Camara";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnDeteccion
            // 
            this.btnDeteccion.Location = new System.Drawing.Point(15, 104);
            this.btnDeteccion.Name = "btnDeteccion";
            this.btnDeteccion.Size = new System.Drawing.Size(245, 54);
            this.btnDeteccion.TabIndex = 2;
            this.btnDeteccion.Text = "Detectar rostro";
            this.btnDeteccion.UseVisualStyleBackColor = true;
            this.btnDeteccion.Click += new System.EventHandler(this.btnDeteccion_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 26);
            this.txtName.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(12, 348);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(916, 48);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(15, 175);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(245, 53);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "Buscar rostro";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(15, 245);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(245, 53);
            this.btnRecognize.TabIndex = 6;
            this.btnRecognize.Text = "Recognize";
            this.btnRecognize.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(374, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 117);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(245, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(495, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 117);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApto);
            this.groupBox1.Controls.Add(this.txtAptooo);
            this.groupBox1.Controls.Add(this.txtEdificio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(362, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 170);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar persona";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapture);
            this.groupBox2.Controls.Add(this.btnDeteccion);
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.Controls.Add(this.btnRecognize);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(655, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 316);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilidades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Camara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Captures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edificio";
            // 
            // txtEdificio
            // 
            this.txtEdificio.Location = new System.Drawing.Point(83, 61);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(177, 26);
            this.txtEdificio.TabIndex = 10;
            // 
            // txtAptooo
            // 
            this.txtAptooo.AutoSize = true;
            this.txtAptooo.Location = new System.Drawing.Point(8, 99);
            this.txtAptooo.Name = "txtAptooo";
            this.txtAptooo.Size = new System.Drawing.Size(47, 20);
            this.txtAptooo.TabIndex = 11;
            this.txtAptooo.Text = "Apto.";
            // 
            // txtApto
            // 
            this.txtApto.Location = new System.Drawing.Point(83, 96);
            this.txtApto.Name = "txtApto";
            this.txtApto.Size = new System.Drawing.Size(177, 26);
            this.txtApto.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 420);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reconocimiento Facial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btnDeteccion;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApto;
        private System.Windows.Forms.Label txtAptooo;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.Label label4;
    }
}

