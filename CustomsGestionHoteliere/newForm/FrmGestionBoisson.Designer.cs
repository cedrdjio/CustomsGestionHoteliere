namespace CustomsGestionHoteliere.newForm
{
    partial class FrmGestionBoisson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionBoisson));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.AjouterBoisson = new System.Windows.Forms.TabPage();
            this.LinkFermer = new Guna.UI.WinForms.GunaLinkLabel();
            this.txtPhoto = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtIdBoisson = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEnregistrer = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrixBoisson = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomBoisson = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ListeBoisson = new System.Windows.Forms.TabPage();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2TextBox4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuCustomDataGrid4 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slider = new System.Windows.Forms.PictureBox();
            this.materialTabControl1.SuspendLayout();
            this.AjouterBoisson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.ListeBoisson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.AjouterBoisson);
            this.materialTabControl1.Controls.Add(this.ListeBoisson);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 63);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(859, 502);
            this.materialTabControl1.TabIndex = 20;
            // 
            // AjouterBoisson
            // 
            this.AjouterBoisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.AjouterBoisson.Controls.Add(this.LinkFermer);
            this.AjouterBoisson.Controls.Add(this.txtPhoto);
            this.AjouterBoisson.Controls.Add(this.gunaPictureBox1);
            this.AjouterBoisson.Controls.Add(this.txtIdBoisson);
            this.AjouterBoisson.Controls.Add(this.btnEnregistrer);
            this.AjouterBoisson.Controls.Add(this.txtPrixBoisson);
            this.AjouterBoisson.Controls.Add(this.txtNomBoisson);
            this.AjouterBoisson.Controls.Add(this.bunifuCustomLabel5);
            this.AjouterBoisson.Location = new System.Drawing.Point(4, 22);
            this.AjouterBoisson.Name = "AjouterBoisson";
            this.AjouterBoisson.Padding = new System.Windows.Forms.Padding(3);
            this.AjouterBoisson.Size = new System.Drawing.Size(851, 476);
            this.AjouterBoisson.TabIndex = 0;
            this.AjouterBoisson.Text = "Ajouter Boisson";
            this.AjouterBoisson.Click += new System.EventHandler(this.AjouterBoisson_Click);
            // 
            // LinkFermer
            // 
            this.LinkFermer.AutoSize = true;
            this.LinkFermer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LinkFermer.Location = new System.Drawing.Point(669, 81);
            this.LinkFermer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LinkFermer.Name = "LinkFermer";
            this.LinkFermer.Size = new System.Drawing.Size(14, 15);
            this.LinkFermer.TabIndex = 76;
            this.LinkFermer.TabStop = true;
            this.LinkFermer.Text = "X";
            // 
            // txtPhoto
            // 
            this.txtPhoto.BaseColor = System.Drawing.Color.Transparent;
            this.txtPhoto.BorderColor = System.Drawing.Color.Silver;
            this.txtPhoto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoto.FocusedBaseColor = System.Drawing.Color.Transparent;
            this.txtPhoto.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPhoto.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhoto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoto.Location = new System.Drawing.Point(465, 72);
            this.txtPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.PasswordChar = '\0';
            this.txtPhoto.SelectedText = "";
            this.txtPhoto.Size = new System.Drawing.Size(51, 26);
            this.txtPhoto.TabIndex = 75;
            this.txtPhoto.Text = "Photo";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaPictureBox1.Location = new System.Drawing.Point(465, 102);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(218, 221);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 74;
            this.gunaPictureBox1.TabStop = false;
            // 
            // txtIdBoisson
            // 
            this.txtIdBoisson.BorderColor = System.Drawing.Color.Indigo;
            this.txtIdBoisson.BorderRadius = 16;
            this.txtIdBoisson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdBoisson.DefaultText = "idBoisson";
            this.txtIdBoisson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdBoisson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdBoisson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBoisson.DisabledState.Parent = this.txtIdBoisson;
            this.txtIdBoisson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdBoisson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBoisson.FocusedState.Parent = this.txtIdBoisson;
            this.txtIdBoisson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdBoisson.HoverState.Parent = this.txtIdBoisson;
            this.txtIdBoisson.Location = new System.Drawing.Point(88, 102);
            this.txtIdBoisson.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBoisson.Name = "txtIdBoisson";
            this.txtIdBoisson.PasswordChar = '\0';
            this.txtIdBoisson.PlaceholderText = "";
            this.txtIdBoisson.SelectedText = "";
            this.txtIdBoisson.SelectionStart = 9;
            this.txtIdBoisson.ShadowDecoration.Parent = this.txtIdBoisson;
            this.txtIdBoisson.Size = new System.Drawing.Size(300, 46);
            this.txtIdBoisson.TabIndex = 0;
            this.txtIdBoisson.TextChanged += new System.EventHandler(this.txtIdBoisson_TextChanged);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.BorderRadius = 19;
            this.btnEnregistrer.BorderThickness = 2;
            this.btnEnregistrer.CheckedState.Parent = this.btnEnregistrer;
            this.btnEnregistrer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEnregistrer.CustomImages.Parent = this.btnEnregistrer;
            this.btnEnregistrer.FillColor = System.Drawing.Color.Indigo;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.HoverState.Parent = this.btnEnregistrer;
            this.btnEnregistrer.Location = new System.Drawing.Point(315, 368);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.ShadowDecoration.Parent = this.btnEnregistrer;
            this.btnEnregistrer.Size = new System.Drawing.Size(188, 45);
            this.btnEnregistrer.TabIndex = 3;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtPrixBoisson
            // 
            this.txtPrixBoisson.BorderColor = System.Drawing.Color.Indigo;
            this.txtPrixBoisson.BorderRadius = 16;
            this.txtPrixBoisson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrixBoisson.DefaultText = "PrixBoisson";
            this.txtPrixBoisson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrixBoisson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrixBoisson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrixBoisson.DisabledState.Parent = this.txtPrixBoisson;
            this.txtPrixBoisson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrixBoisson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrixBoisson.FocusedState.Parent = this.txtPrixBoisson;
            this.txtPrixBoisson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrixBoisson.HoverState.Parent = this.txtPrixBoisson;
            this.txtPrixBoisson.Location = new System.Drawing.Point(88, 288);
            this.txtPrixBoisson.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrixBoisson.Name = "txtPrixBoisson";
            this.txtPrixBoisson.PasswordChar = '\0';
            this.txtPrixBoisson.PlaceholderText = "";
            this.txtPrixBoisson.SelectedText = "";
            this.txtPrixBoisson.SelectionStart = 11;
            this.txtPrixBoisson.ShadowDecoration.Parent = this.txtPrixBoisson;
            this.txtPrixBoisson.Size = new System.Drawing.Size(300, 36);
            this.txtPrixBoisson.TabIndex = 2;
            // 
            // txtNomBoisson
            // 
            this.txtNomBoisson.BorderColor = System.Drawing.Color.Indigo;
            this.txtNomBoisson.BorderRadius = 16;
            this.txtNomBoisson.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomBoisson.DefaultText = "NomBoisson";
            this.txtNomBoisson.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomBoisson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomBoisson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomBoisson.DisabledState.Parent = this.txtNomBoisson;
            this.txtNomBoisson.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomBoisson.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomBoisson.FocusedState.Parent = this.txtNomBoisson;
            this.txtNomBoisson.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomBoisson.HoverState.Parent = this.txtNomBoisson;
            this.txtNomBoisson.Location = new System.Drawing.Point(88, 193);
            this.txtNomBoisson.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomBoisson.Name = "txtNomBoisson";
            this.txtNomBoisson.PasswordChar = '\0';
            this.txtNomBoisson.PlaceholderText = "";
            this.txtNomBoisson.SelectedText = "";
            this.txtNomBoisson.SelectionStart = 10;
            this.txtNomBoisson.ShadowDecoration.Parent = this.txtNomBoisson;
            this.txtNomBoisson.Size = new System.Drawing.Size(300, 36);
            this.txtNomBoisson.TabIndex = 1;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(311, 288);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(0, 20);
            this.bunifuCustomLabel5.TabIndex = 65;
            // 
            // ListeBoisson
            // 
            this.ListeBoisson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ListeBoisson.Controls.Add(this.guna2GradientButton4);
            this.ListeBoisson.Controls.Add(this.guna2TextBox4);
            this.ListeBoisson.Controls.Add(this.bunifuCustomDataGrid4);
            this.ListeBoisson.Location = new System.Drawing.Point(4, 22);
            this.ListeBoisson.Name = "ListeBoisson";
            this.ListeBoisson.Padding = new System.Windows.Forms.Padding(3);
            this.ListeBoisson.Size = new System.Drawing.Size(851, 476);
            this.ListeBoisson.TabIndex = 1;
            this.ListeBoisson.Text = "Liste Boisson";
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.BorderRadius = 16;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Location = new System.Drawing.Point(730, 26);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(108, 45);
            this.guna2GradientButton4.TabIndex = 16;
            this.guna2GradientButton4.Text = "Rechercher";
            // 
            // guna2TextBox4
            // 
            this.guna2TextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2TextBox4.BorderRadius = 16;
            this.guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox4.DefaultText = " Recherche";
            this.guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.DisabledState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.FocusedState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox4.HoverState.Parent = this.guna2TextBox4;
            this.guna2TextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox4.IconLeft")));
            this.guna2TextBox4.Location = new System.Drawing.Point(457, 26);
            this.guna2TextBox4.Name = "guna2TextBox4";
            this.guna2TextBox4.PasswordChar = '\0';
            this.guna2TextBox4.PlaceholderText = "";
            this.guna2TextBox4.SelectedText = "";
            this.guna2TextBox4.SelectionStart = 10;
            this.guna2TextBox4.ShadowDecoration.Parent = this.guna2TextBox4;
            this.guna2TextBox4.Size = new System.Drawing.Size(257, 45);
            this.guna2TextBox4.TabIndex = 15;
            // 
            // bunifuCustomDataGrid4
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid4.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid4.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid4.DoubleBuffered = true;
            this.bunifuCustomDataGrid4.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid4.GridColor = System.Drawing.Color.Indigo;
            this.bunifuCustomDataGrid4.HeaderBgColor = System.Drawing.Color.Indigo;
            this.bunifuCustomDataGrid4.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid4.Location = new System.Drawing.Point(3, 92);
            this.bunifuCustomDataGrid4.Name = "bunifuCustomDataGrid4";
            this.bunifuCustomDataGrid4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid4.RowHeadersWidth = 51;
            this.bunifuCustomDataGrid4.Size = new System.Drawing.Size(845, 381);
            this.bunifuCustomDataGrid4.TabIndex = 13;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Liste Boisson";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(187, 12);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Indigo;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(162, 30);
            this.bunifuFlatButton2.TabIndex = 23;
            this.bunifuFlatButton2.Text = "Liste Boisson";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Ajouter Boisson";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(4, 12);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(177, 30);
            this.bunifuFlatButton3.TabIndex = 21;
            this.bunifuFlatButton3.Text = "Ajouter Boisson";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.slider.Location = new System.Drawing.Point(4, 47);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(160, 10);
            this.slider.TabIndex = 22;
            this.slider.TabStop = false;
            // 
            // FrmGestionBoisson
            // 
            this.AcceptButton = this.btnEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(871, 577);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.materialTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGestionBoisson";
            this.Text = "frmGestTypeBoisson";
            this.materialTabControl1.ResumeLayout(false);
            this.AjouterBoisson.ResumeLayout(false);
            this.AjouterBoisson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ListeBoisson.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage AjouterBoisson;
        private Guna.UI.WinForms.GunaLinkLabel LinkFermer;
        private Guna.UI.WinForms.GunaTextBox txtPhoto;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtIdBoisson;
        private Guna.UI2.WinForms.Guna2Button btnEnregistrer;
        private Guna.UI2.WinForms.Guna2TextBox txtPrixBoisson;
        private Guna.UI2.WinForms.Guna2TextBox txtNomBoisson;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TabPage ListeBoisson;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.PictureBox slider;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox4;
    }
}