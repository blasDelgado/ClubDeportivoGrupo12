namespace ClubDeportivo
{
    partial class ListarActividades
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
            components = new System.ComponentModel.Container();
            dtgvActividades = new DataGridView();
            actividadBindingSource = new BindingSource(components);
            btnAgregarAct = new Button();
            btnVolver = new Button();
            actividadBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dtgvActividades
            // 
            dtgvActividades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvActividades.Location = new Point(78, 68);
            dtgvActividades.Name = "dtgvActividades";
            dtgvActividades.RowTemplate.Height = 25;
            dtgvActividades.Size = new Size(485, 243);
            dtgvActividades.TabIndex = 1;
            dtgvActividades.Tag = "Listado Actividades";
            dtgvActividades.CellContentClick += dtgvActividades_CellContentClick;
            // 
            // actividadBindingSource
            // 
            actividadBindingSource.DataSource = typeof(Actividad);
            // 
            // btnAgregarAct
            // 
            btnAgregarAct.BackColor = SystemColors.ButtonHighlight;
            btnAgregarAct.FlatStyle = FlatStyle.Popup;
            btnAgregarAct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAct.Location = new Point(140, 333);
            btnAgregarAct.Name = "btnAgregarAct";
            btnAgregarAct.Size = new Size(159, 52);
            btnAgregarAct.TabIndex = 2;
            btnAgregarAct.Text = "Agregar";
            btnAgregarAct.UseVisualStyleBackColor = false;
            btnAgregarAct.Click += btnAgregar_click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.ButtonHighlight;
            btnVolver.FlatStyle = FlatStyle.Popup;
            btnVolver.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(351, 333);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(159, 52);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_click;
            // 
            // actividadBindingSource1
            // 
            actividadBindingSource1.DataSource = typeof(Actividad);
            // 
            // ListarActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 448);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarAct);
            Controls.Add(dtgvActividades);
            Name = "ListarActividades";
            Text = "Listado Actividades";
            Load += ListarActividades_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvActividades).EndInit();
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)actividadBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvActividades;
        private Button btnAgregarAct;
        private Button btnVolver;
        private BindingSource actividadBindingSource;
        private BindingSource actividadBindingSource1;
    }
}