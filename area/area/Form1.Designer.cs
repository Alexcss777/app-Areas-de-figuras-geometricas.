namespace area
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.altura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.area = new System.Windows.Forms.Label();
            this.perimetro = new System.Windows.Forms.Label();
            this.radio = new System.Windows.Forms.Label();
            this.percirculo = new System.Windows.Forms.TextBox();
            this.limpia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "rectangulo",
            "triangulo",
            "circulo",
            "cuadrado"});
            this.comboBox1.Location = new System.Drawing.Point(42, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(706, 107);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(45, 17);
            this.altura.TabIndex = 2;
            this.altura.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(706, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "perimetro";
            // 
            // bas
            // 
            this.bas.AutoSize = true;
            this.bas.Location = new System.Drawing.Point(706, 175);
            this.bas.Name = "bas";
            this.bas.Size = new System.Drawing.Size(40, 17);
            this.bas.TabIndex = 4;
            this.bas.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Area";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 415);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(849, 107);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 22);
            this.num1.TabIndex = 7;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(849, 172);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 22);
            this.num2.TabIndex = 8;
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(901, 267);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(0, 17);
            this.area.TabIndex = 9;
            // 
            // perimetro
            // 
            this.perimetro.AutoSize = true;
            this.perimetro.Location = new System.Drawing.Point(903, 329);
            this.perimetro.Name = "perimetro";
            this.perimetro.Size = new System.Drawing.Size(0, 17);
            this.perimetro.TabIndex = 10;
            // 
            // radio
            // 
            this.radio.AutoSize = true;
            this.radio.Location = new System.Drawing.Point(705, 388);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(40, 17);
            this.radio.TabIndex = 11;
            this.radio.Text = "radio";
            // 
            // percirculo
            // 
            this.percirculo.Location = new System.Drawing.Point(849, 383);
            this.percirculo.Name = "percirculo";
            this.percirculo.Size = new System.Drawing.Size(100, 22);
            this.percirculo.TabIndex = 12;
            // 
            // limpia
            // 
            this.limpia.Location = new System.Drawing.Point(917, 451);
            this.limpia.Name = "limpia";
            this.limpia.Size = new System.Drawing.Size(75, 23);
            this.limpia.TabIndex = 13;
            this.limpia.Text = "limpiar";
            this.limpia.UseVisualStyleBackColor = true;
            this.limpia.Click += new System.EventHandler(this.Limpia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 534);
            this.Controls.Add(this.limpia);
            this.Controls.Add(this.percirculo);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.perimetro);
            this.Controls.Add(this.area);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label perimetro;
        private System.Windows.Forms.Label radio;
        private System.Windows.Forms.TextBox percirculo;
        private System.Windows.Forms.Button limpia;
    }
}

