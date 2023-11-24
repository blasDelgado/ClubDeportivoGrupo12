namespace ClubDeportivo
{
    partial class ActividadesHome
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
            btnListAct = new Button();
            btnActPrecios = new Button();
            SuspendLayout();
            // 
            // btnListAct
            // 
            btnListAct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnListAct.Location = new Point(86, 132);
            btnListAct.Margin = new Padding(3, 4, 3, 4);
            btnListAct.Name = "btnListAct";
            btnListAct.Size = new Size(347, 81);
            btnListAct.TabIndex = 0;
            btnListAct.Text = "Ver actividades vigentes";
            btnListAct.UseVisualStyleBackColor = true;
            btnListAct.Click += button1_Click;
            // 
            // btnActPrecios
            // 
            btnActPrecios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnActPrecios.Location = new Point(86, 264);
            btnActPrecios.Margin = new Padding(3, 4, 3, 4);
            btnActPrecios.Name = "btnActPrecios";
            btnActPrecios.Size = new Size(347, 81);
            btnActPrecios.TabIndex = 1;
            btnActPrecios.Text = "Actualizar precios";
            btnActPrecios.UseVisualStyleBackColor = true;
            btnActPrecios.Click += btnActPrecios_Click;
            // 
            // ActividadesHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 455);
            Controls.Add(btnActPrecios);
            Controls.Add(btnListAct);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ActividadesHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ActividadesHome";
            Load += ActividadesHome_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnListAct;
        private Button btnActPrecios;
    }
}