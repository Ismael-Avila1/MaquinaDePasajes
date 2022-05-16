namespace MaquinaDePasajes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonDiezPesos = new System.Windows.Forms.Button();
            this.buttonCincoPesos = new System.Windows.Forms.Button();
            this.buttonDosPesos = new System.Windows.Forms.Button();
            this.buttonUnPeso = new System.Windows.Forms.Button();
            this.buttonCincuentaCentavos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaquinaDePasajes.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(276, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Black;
            this.label.Font = new System.Drawing.Font("Digital-7", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.Red;
            this.label.Location = new System.Drawing.Point(386, 207);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(180, 90);
            this.label.TabIndex = 1;
            this.label.Text = "--";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDiezPesos
            // 
            this.buttonDiezPesos.BackgroundImage = global::MaquinaDePasajes.Properties.Resources.DiezPesos;
            this.buttonDiezPesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDiezPesos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDiezPesos.Location = new System.Drawing.Point(12, 389);
            this.buttonDiezPesos.Name = "buttonDiezPesos";
            this.buttonDiezPesos.Size = new System.Drawing.Size(152, 152);
            this.buttonDiezPesos.TabIndex = 2;
            this.buttonDiezPesos.UseVisualStyleBackColor = true;
            this.buttonDiezPesos.Click += new System.EventHandler(this.buttonDiezPesos_Click);
            // 
            // buttonCincoPesos
            // 
            this.buttonCincoPesos.BackgroundImage = global::MaquinaDePasajes.Properties.Resources.SinkoPeso;
            this.buttonCincoPesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCincoPesos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCincoPesos.Location = new System.Drawing.Point(206, 389);
            this.buttonCincoPesos.Name = "buttonCincoPesos";
            this.buttonCincoPesos.Size = new System.Drawing.Size(152, 152);
            this.buttonCincoPesos.TabIndex = 3;
            this.buttonCincoPesos.UseVisualStyleBackColor = true;
            this.buttonCincoPesos.Click += new System.EventHandler(this.buttonCincoPesos_Click);
            // 
            // buttonDosPesos
            // 
            this.buttonDosPesos.BackgroundImage = global::MaquinaDePasajes.Properties.Resources.DosPesos;
            this.buttonDosPesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDosPesos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDosPesos.Location = new System.Drawing.Point(400, 389);
            this.buttonDosPesos.Name = "buttonDosPesos";
            this.buttonDosPesos.Size = new System.Drawing.Size(152, 152);
            this.buttonDosPesos.TabIndex = 4;
            this.buttonDosPesos.UseVisualStyleBackColor = true;
            this.buttonDosPesos.Click += new System.EventHandler(this.buttonDosPesos_Click);
            // 
            // buttonUnPeso
            // 
            this.buttonUnPeso.BackgroundImage = global::MaquinaDePasajes.Properties.Resources.UnPeso;
            this.buttonUnPeso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUnPeso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUnPeso.Location = new System.Drawing.Point(614, 389);
            this.buttonUnPeso.Name = "buttonUnPeso";
            this.buttonUnPeso.Size = new System.Drawing.Size(152, 152);
            this.buttonUnPeso.TabIndex = 5;
            this.buttonUnPeso.UseVisualStyleBackColor = true;
            this.buttonUnPeso.Click += new System.EventHandler(this.buttonUnPeso_Click);
            // 
            // buttonCincuentaCentavos
            // 
            this.buttonCincuentaCentavos.BackgroundImage = global::MaquinaDePasajes.Properties.Resources.CincuentaCentavos;
            this.buttonCincuentaCentavos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCincuentaCentavos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCincuentaCentavos.Location = new System.Drawing.Point(818, 389);
            this.buttonCincuentaCentavos.Name = "buttonCincuentaCentavos";
            this.buttonCincuentaCentavos.Size = new System.Drawing.Size(152, 152);
            this.buttonCincuentaCentavos.TabIndex = 6;
            this.buttonCincuentaCentavos.UseVisualStyleBackColor = true;
            this.buttonCincuentaCentavos.Click += new System.EventHandler(this.buttonCincuentaCentavos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCincuentaCentavos);
            this.Controls.Add(this.buttonUnPeso);
            this.Controls.Add(this.buttonDosPesos);
            this.Controls.Add(this.buttonCincoPesos);
            this.Controls.Add(this.buttonDiezPesos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina de Pasajes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label;
        private Button buttonDiezPesos;
        private Button buttonCincoPesos;
        private Button buttonDosPesos;
        private Button buttonUnPeso;
        private Button buttonCincuentaCentavos;
    }
}