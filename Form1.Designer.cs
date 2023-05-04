namespace LimpaDuplicados
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.Button();
            this.Recursivo = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Buscar = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.txtMetodo = new System.Windows.Forms.TextBox();
            this.MD5 = new System.Windows.Forms.RadioButton();
            this.Tamanho = new System.Windows.Forms.RadioButton();
            this.SHA2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(284, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 29);
            this.textBox1.TabIndex = 0;
            // 
            // Path
            // 
            this.Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.Location = new System.Drawing.Point(31, 24);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(241, 43);
            this.Path.TabIndex = 1;
            this.Path.Text = "Escolha uma pasta";
            this.Path.UseVisualStyleBackColor = true;
            // 
            // Recursivo
            // 
            this.Recursivo.AutoSize = true;
            this.Recursivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recursivo.Location = new System.Drawing.Point(675, 32);
            this.Recursivo.Name = "Recursivo";
            this.Recursivo.Size = new System.Drawing.Size(98, 24);
            this.Recursivo.TabIndex = 2;
            this.Recursivo.Text = "Recursivo";
            this.Recursivo.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(742, 248);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Buscar
            // 
            this.Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar.Location = new System.Drawing.Point(31, 394);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(241, 43);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar duplicados";
            this.Buscar.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(532, 394);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(241, 43);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Limpar selecionados";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMetodo
            // 
            this.txtMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetodo.Location = new System.Drawing.Point(31, 84);
            this.txtMetodo.Name = "txtMetodo";
            this.txtMetodo.Size = new System.Drawing.Size(197, 26);
            this.txtMetodo.TabIndex = 6;
            this.txtMetodo.Text = "Método de comparação";
            this.txtMetodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MD5
            // 
            this.MD5.AutoSize = true;
            this.MD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MD5.Location = new System.Drawing.Point(284, 86);
            this.MD5.Name = "MD5";
            this.MD5.Size = new System.Drawing.Size(61, 24);
            this.MD5.TabIndex = 10;
            this.MD5.TabStop = true;
            this.MD5.Text = "MD5";
            this.MD5.UseVisualStyleBackColor = true;
            // 
            // Tamanho
            // 
            this.Tamanho.AutoSize = true;
            this.Tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tamanho.Location = new System.Drawing.Point(494, 86);
            this.Tamanho.Name = "Tamanho";
            this.Tamanho.Size = new System.Drawing.Size(94, 24);
            this.Tamanho.TabIndex = 11;
            this.Tamanho.TabStop = true;
            this.Tamanho.Text = "Tamanho";
            this.Tamanho.UseVisualStyleBackColor = true;
            // 
            // SHA2
            // 
            this.SHA2.AutoSize = true;
            this.SHA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHA2.Location = new System.Drawing.Point(380, 86);
            this.SHA2.Name = "SHA2";
            this.SHA2.Size = new System.Drawing.Size(70, 24);
            this.SHA2.TabIndex = 12;
            this.SHA2.TabStop = true;
            this.SHA2.Text = "SHA2";
            this.SHA2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SHA2);
            this.Controls.Add(this.Tamanho);
            this.Controls.Add(this.MD5);
            this.Controls.Add(this.txtMetodo);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Recursivo);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Limpa arquivos duplicados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Path;
        private System.Windows.Forms.CheckBox Recursivo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox txtMetodo;
        private System.Windows.Forms.RadioButton MD5;
        private System.Windows.Forms.RadioButton Tamanho;
        private System.Windows.Forms.RadioButton SHA2;
    }
}

