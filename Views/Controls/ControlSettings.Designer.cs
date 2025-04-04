
namespace Therapheye.Views.Controls
{
    partial class ControlSettings
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlSettings));
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.ckbStenopeicFilter = new System.Windows.Forms.CheckBox();
            this.ckbDarkFilter = new System.Windows.Forms.CheckBox();
            this.ckbBlueFilter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxColor = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbApertureSpacing = new System.Windows.Forms.TrackBar();
            this.tbApertureSize = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStenopeicType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbStenopeicFilter = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBlueFilter = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDarkFilter = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colDlgStenopeicFilter = new System.Windows.Forms.ColorDialog();
            this.ntfIconFilters = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsScreenFilters = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDarkScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlueLight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStenopeic = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbApertureSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbApertureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStenopeicFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlueFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.cmsScreenFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(169)))), ((int)(((byte)(119)))));
            this.btnChangeColor.Enabled = false;
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.Location = new System.Drawing.Point(345, 228);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(96, 27);
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Text = "Cambiar";
            this.btnChangeColor.UseVisualStyleBackColor = false;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // ckbStenopeicFilter
            // 
            this.ckbStenopeicFilter.AutoSize = true;
            this.ckbStenopeicFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbStenopeicFilter.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbStenopeicFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.ckbStenopeicFilter.Location = new System.Drawing.Point(35, 179);
            this.ckbStenopeicFilter.Name = "ckbStenopeicFilter";
            this.ckbStenopeicFilter.Size = new System.Drawing.Size(216, 25);
            this.ckbStenopeicFilter.TabIndex = 1;
            this.ckbStenopeicFilter.Text = "Filtro reticular (por defecto)";
            this.ckbStenopeicFilter.UseVisualStyleBackColor = true;
            this.ckbStenopeicFilter.CheckedChanged += new System.EventHandler(this.ckbStenopeicFilter_CheckedChanged);
            // 
            // ckbDarkFilter
            // 
            this.ckbDarkFilter.AutoSize = true;
            this.ckbDarkFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbDarkFilter.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDarkFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.ckbDarkFilter.Location = new System.Drawing.Point(35, 73);
            this.ckbDarkFilter.Name = "ckbDarkFilter";
            this.ckbDarkFilter.Size = new System.Drawing.Size(155, 25);
            this.ckbDarkFilter.TabIndex = 2;
            this.ckbDarkFilter.Text = "Oscurecer pantalla";
            this.ckbDarkFilter.UseVisualStyleBackColor = true;
            this.ckbDarkFilter.CheckedChanged += new System.EventHandler(this.ckbDarkFilter_CheckedChanged);
            // 
            // ckbBlueFilter
            // 
            this.ckbBlueFilter.AutoSize = true;
            this.ckbBlueFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbBlueFilter.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBlueFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.ckbBlueFilter.Location = new System.Drawing.Point(35, 124);
            this.ckbBlueFilter.Name = "ckbBlueFilter";
            this.ckbBlueFilter.Size = new System.Drawing.Size(139, 25);
            this.ckbBlueFilter.TabIndex = 3;
            this.ckbBlueFilter.Text = "Filtro de luz azul";
            this.ckbBlueFilter.UseVisualStyleBackColor = true;
            this.ckbBlueFilter.CheckedChanged += new System.EventHandler(this.ckbBlueFilter_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(24)))), ((int)(((byte)(18)))));
            this.label2.Location = new System.Drawing.Point(29, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtros de pantalla";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(24)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.picBoxColor);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnChangeColor);
            this.panel1.Controls.Add(this.tbApertureSpacing);
            this.panel1.Controls.Add(this.tbApertureSize);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbStenopeicType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbStenopeicFilter);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbBlueFilter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbDarkFilter);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.ckbBlueFilter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ckbDarkFilter);
            this.panel1.Controls.Add(this.ckbStenopeicFilter);
            this.panel1.Location = new System.Drawing.Point(34, 67);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 385);
            this.panel1.TabIndex = 6;
            // 
            // picBoxColor
            // 
            this.picBoxColor.BackColor = System.Drawing.Color.Gainsboro;
            this.picBoxColor.Enabled = false;
            this.picBoxColor.Location = new System.Drawing.Point(311, 228);
            this.picBoxColor.Name = "picBoxColor";
            this.picBoxColor.Size = new System.Drawing.Size(28, 27);
            this.picBoxColor.TabIndex = 21;
            this.picBoxColor.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label9.Location = new System.Drawing.Point(459, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cambiar color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label8.Location = new System.Drawing.Point(459, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dis. apertura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label7.Location = new System.Drawing.Point(459, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tam. apertura";
            // 
            // tbApertureSpacing
            // 
            this.tbApertureSpacing.Enabled = false;
            this.tbApertureSpacing.Location = new System.Drawing.Point(194, 341);
            this.tbApertureSpacing.Minimum = 1;
            this.tbApertureSpacing.Name = "tbApertureSpacing";
            this.tbApertureSpacing.Size = new System.Drawing.Size(259, 45);
            this.tbApertureSpacing.TabIndex = 17;
            this.tbApertureSpacing.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbApertureSpacing.Value = 1;
            this.tbApertureSpacing.Scroll += new System.EventHandler(this.tbApertureSpacing_Scroll);
            // 
            // tbApertureSize
            // 
            this.tbApertureSize.Enabled = false;
            this.tbApertureSize.Location = new System.Drawing.Point(194, 309);
            this.tbApertureSize.Minimum = 1;
            this.tbApertureSize.Name = "tbApertureSize";
            this.tbApertureSize.Size = new System.Drawing.Size(259, 45);
            this.tbApertureSize.TabIndex = 14;
            this.tbApertureSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbApertureSize.Value = 1;
            this.tbApertureSize.Scroll += new System.EventHandler(this.tbApertureSize_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label6.Location = new System.Drawing.Point(459, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo";
            // 
            // cmbStenopeicType
            // 
            this.cmbStenopeicType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(169)))), ((int)(((byte)(119)))));
            this.cmbStenopeicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStenopeicType.Enabled = false;
            this.cmbStenopeicType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStenopeicType.FormattingEnabled = true;
            this.cmbStenopeicType.Items.AddRange(new object[] {
            "Circular",
            "Triangular",
            "Hexagonal"});
            this.cmbStenopeicType.Location = new System.Drawing.Point(311, 183);
            this.cmbStenopeicType.Name = "cmbStenopeicType";
            this.cmbStenopeicType.Size = new System.Drawing.Size(130, 21);
            this.cmbStenopeicType.TabIndex = 12;
            this.cmbStenopeicType.SelectedIndexChanged += new System.EventHandler(this.cmbStenopeicType_SelectedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label4.Location = new System.Drawing.Point(459, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Intensidad";
            // 
            // tbStenopeicFilter
            // 
            this.tbStenopeicFilter.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbStenopeicFilter.Enabled = false;
            this.tbStenopeicFilter.Location = new System.Drawing.Point(194, 275);
            this.tbStenopeicFilter.Minimum = 1;
            this.tbStenopeicFilter.Name = "tbStenopeicFilter";
            this.tbStenopeicFilter.Size = new System.Drawing.Size(259, 45);
            this.tbStenopeicFilter.TabIndex = 10;
            this.tbStenopeicFilter.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbStenopeicFilter.Value = 1;
            this.tbStenopeicFilter.Scroll += new System.EventHandler(this.tbStenopeicFilter_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(459, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intensidad";
            // 
            // tbBlueFilter
            // 
            this.tbBlueFilter.Enabled = false;
            this.tbBlueFilter.Location = new System.Drawing.Point(194, 128);
            this.tbBlueFilter.Minimum = 1;
            this.tbBlueFilter.Name = "tbBlueFilter";
            this.tbBlueFilter.Size = new System.Drawing.Size(259, 45);
            this.tbBlueFilter.TabIndex = 8;
            this.tbBlueFilter.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBlueFilter.Value = 1;
            this.tbBlueFilter.Scroll += new System.EventHandler(this.tbBlueFilter_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label1.Location = new System.Drawing.Point(459, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Intensidad";
            // 
            // tbDarkFilter
            // 
            this.tbDarkFilter.Enabled = false;
            this.tbDarkFilter.Location = new System.Drawing.Point(194, 77);
            this.tbDarkFilter.Minimum = 1;
            this.tbDarkFilter.Name = "tbDarkFilter";
            this.tbDarkFilter.Size = new System.Drawing.Size(259, 45);
            this.tbDarkFilter.TabIndex = 6;
            this.tbDarkFilter.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbDarkFilter.Value = 1;
            this.tbDarkFilter.Scroll += new System.EventHandler(this.tbDarkFilter_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Therapheye.Properties.Resources.outline_remove_red_eye_white_24dp;
            this.pictureBox2.Location = new System.Drawing.Point(525, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.label5.Location = new System.Drawing.Point(30, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(476, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estas son las opciones de filtros que tenemos para ti:";
            // 
            // ntfIconFilters
            // 
            this.ntfIconFilters.ContextMenuStrip = this.cmsScreenFilters;
            this.ntfIconFilters.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIconFilters.Icon")));
            this.ntfIconFilters.Text = "Filtros";
            this.ntfIconFilters.Visible = true;
            // 
            // cmsScreenFilters
            // 
            this.cmsScreenFilters.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDarkScreen,
            this.tsmiBlueLight,
            this.tsmiStenopeic});
            this.cmsScreenFilters.Name = "cmsScreenFilters";
            this.cmsScreenFilters.Size = new System.Drawing.Size(221, 70);
            this.cmsScreenFilters.Text = "Filtros";
            // 
            // tsmiDarkScreen
            // 
            this.tsmiDarkScreen.Enabled = false;
            this.tsmiDarkScreen.Name = "tsmiDarkScreen";
            this.tsmiDarkScreen.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.tsmiDarkScreen.Size = new System.Drawing.Size(220, 22);
            this.tsmiDarkScreen.Text = "Pantalla oscura";
            this.tsmiDarkScreen.Click += new System.EventHandler(this.tsmiDarkScreen_Click);
            // 
            // tsmiBlueLight
            // 
            this.tsmiBlueLight.Enabled = false;
            this.tsmiBlueLight.Name = "tsmiBlueLight";
            this.tsmiBlueLight.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.tsmiBlueLight.Size = new System.Drawing.Size(220, 22);
            this.tsmiBlueLight.Text = "Luz azul";
            this.tsmiBlueLight.Click += new System.EventHandler(this.tsmiBlueLight_Click);
            // 
            // tsmiStenopeic
            // 
            this.tsmiStenopeic.Enabled = false;
            this.tsmiStenopeic.Name = "tsmiStenopeic";
            this.tsmiStenopeic.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.tsmiStenopeic.Size = new System.Drawing.Size(220, 22);
            this.tsmiStenopeic.Text = "Estenopeico";
            this.tsmiStenopeic.Click += new System.EventHandler(this.tsmiStenopeic_Click);
            // 
            // ControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ControlSettings";
            this.Size = new System.Drawing.Size(670, 480);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbApertureSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbApertureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStenopeicFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlueFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDarkFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.cmsScreenFilters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.CheckBox ckbStenopeicFilter;
        private System.Windows.Forms.CheckBox ckbDarkFilter;
        private System.Windows.Forms.CheckBox ckbBlueFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbDarkFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbStenopeicFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbBlueFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStenopeicType;
        private System.Windows.Forms.TrackBar tbApertureSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbApertureSpacing;
        private System.Windows.Forms.ColorDialog colDlgStenopeicFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picBoxColor;
        private System.Windows.Forms.NotifyIcon ntfIconFilters;
        private System.Windows.Forms.ContextMenuStrip cmsScreenFilters;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarkScreen;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlueLight;
        private System.Windows.Forms.ToolStripMenuItem tsmiStenopeic;
    }
}
