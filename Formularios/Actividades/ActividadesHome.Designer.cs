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
            btnListAct.Location = new Point(75, 99);
            btnListAct.Name = "btnListAct";
            btnListAct.Size = new Size(304, 61);
            btnListAct.TabIndex = 0;
            btnListAct.Text = "Ver actividades vigentes";
            btnListAct.UseVisualStyleBackColor = true;
            btnListAct.Click += button1_Click;
            // 
            // btnActPrecios
            // 
            btnActPrecios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnActPrecios.Location = new Point(75, 198);
            btnActPrecios.Name = "btnActPrecios";
            btnActPrecios.Size = new Size(304, 61);
            btnActPrecios.TabIndex = 1;
            btnActPrecios.Text = "Actualizar precios";
            btnActPrecios.UseVisualStyleBackColor = true;
            btnActPrecios.Click += btnActPrecios_Click;
            // 
            // ActividadesHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 341);
            Controls.Add(btnActPrecios);
            Controls.Add(btnListAct);
            Name = "ActividadesHome";
            Text = "ActividadesHome";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListAct;
        private Button btnActPrecios;
    }
}