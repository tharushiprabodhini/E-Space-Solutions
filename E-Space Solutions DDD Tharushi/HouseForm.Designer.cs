namespace E_Space_Solutions_DDD_Tharushi
{
    partial class HouseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseForm));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cmb_Search = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.cmb_ColonistId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel_BackDshbrd = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Exit = new System.Windows.Forms.LinkLabel();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_register = new Guna.UI2.WinForms.Guna2Button();
            this.dGV_House = new System.Windows.Forms.DataGridView();
            this.txt_SquareFeet = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_NumOfRooms = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_House_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_house = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_House)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.cmb_Search);
            this.guna2GradientPanel1.Controls.Add(this.cmb_ColonistId);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.linkLabel_BackDshbrd);
            this.guna2GradientPanel1.Controls.Add(this.linkLabel_Exit);
            this.guna2GradientPanel1.Controls.Add(this.btn_Clear);
            this.guna2GradientPanel1.Controls.Add(this.btn_delete);
            this.guna2GradientPanel1.Controls.Add(this.btn_update);
            this.guna2GradientPanel1.Controls.Add(this.btn_register);
            this.guna2GradientPanel1.Controls.Add(this.dGV_House);
            this.guna2GradientPanel1.Controls.Add(this.txt_SquareFeet);
            this.guna2GradientPanel1.Controls.Add(this.txt_NumOfRooms);
            this.guna2GradientPanel1.Controls.Add(this.txt_House_id);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.btn_house);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(68)))), ((int)(((byte)(56)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(992, 650);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // cmb_Search
            // 
            this.cmb_Search.DropDownWidth = 234;
            this.cmb_Search.Location = new System.Drawing.Point(685, 136);
            this.cmb_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Search.Name = "cmb_Search";
            this.cmb_Search.Size = new System.Drawing.Size(280, 36);
            this.cmb_Search.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmb_Search.StateCommon.ComboBox.Border.Rounding = 13;
            this.cmb_Search.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmb_Search.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Search.TabIndex = 185;
            this.cmb_Search.Text = "Search";
            this.cmb_Search.SelectedIndexChanged += new System.EventHandler(this.cmb_Search_SelectedIndexChanged);
            // 
            // cmb_ColonistId
            // 
            this.cmb_ColonistId.BackColor = System.Drawing.Color.Transparent;
            this.cmb_ColonistId.BorderRadius = 10;
            this.cmb_ColonistId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_ColonistId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ColonistId.FillColor = System.Drawing.Color.MistyRose;
            this.cmb_ColonistId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ColonistId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_ColonistId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_ColonistId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_ColonistId.ItemHeight = 30;
            this.cmb_ColonistId.Location = new System.Drawing.Point(361, 362);
            this.cmb_ColonistId.Name = "cmb_ColonistId";
            this.cmb_ColonistId.Size = new System.Drawing.Size(219, 36);
            this.cmb_ColonistId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(67, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 176;
            this.label3.Text = "Colonist id:";
            // 
            // linkLabel_BackDshbrd
            // 
            this.linkLabel_BackDshbrd.AutoSize = true;
            this.linkLabel_BackDshbrd.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_BackDshbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_BackDshbrd.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel_BackDshbrd.Location = new System.Drawing.Point(16, 621);
            this.linkLabel_BackDshbrd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_BackDshbrd.Name = "linkLabel_BackDshbrd";
            this.linkLabel_BackDshbrd.Size = new System.Drawing.Size(123, 16);
            this.linkLabel_BackDshbrd.TabIndex = 170;
            this.linkLabel_BackDshbrd.TabStop = true;
            this.linkLabel_BackDshbrd.Text = "Back Dashboard";
            this.linkLabel_BackDshbrd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_BackDshbrd_LinkClicked);
            // 
            // linkLabel_Exit
            // 
            this.linkLabel_Exit.AutoSize = true;
            this.linkLabel_Exit.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Exit.Font = new System.Drawing.Font("Montserrat Subrayada", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_Exit.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel_Exit.Location = new System.Drawing.Point(922, 621);
            this.linkLabel_Exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_Exit.Name = "linkLabel_Exit";
            this.linkLabel_Exit.Size = new System.Drawing.Size(43, 19);
            this.linkLabel_Exit.TabIndex = 171;
            this.linkLabel_Exit.TabStop = true;
            this.linkLabel_Exit.Text = "Exit";
            this.linkLabel_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Exit_LinkClicked);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AutoRoundedCorners = true;
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.BorderRadius = 15;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Location = new System.Drawing.Point(832, 551);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(124, 32);
            this.btn_Clear.TabIndex = 148;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 15;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(33)))), ((int)(((byte)(22)))));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(832, 513);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 32);
            this.btn_delete.TabIndex = 147;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoRoundedCorners = true;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderRadius = 15;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(832, 473);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(124, 32);
            this.btn_update.TabIndex = 146;
            this.btn_update.Text = "Update";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_register
            // 
            this.btn_register.AutoRoundedCorners = true;
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.BorderRadius = 15;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(24)))));
            this.btn_register.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(832, 434);
            this.btn_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(124, 32);
            this.btn_register.TabIndex = 145;
            this.btn_register.Text = "Register";
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // dGV_House
            // 
            this.dGV_House.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dGV_House.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_House.Location = new System.Drawing.Point(28, 420);
            this.dGV_House.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGV_House.Name = "dGV_House";
            this.dGV_House.RowHeadersWidth = 51;
            this.dGV_House.RowTemplate.Height = 24;
            this.dGV_House.Size = new System.Drawing.Size(773, 174);
            this.dGV_House.TabIndex = 56;
            // 
            // txt_SquareFeet
            // 
            this.txt_SquareFeet.Animated = true;
            this.txt_SquareFeet.BackColor = System.Drawing.Color.Transparent;
            this.txt_SquareFeet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_SquareFeet.BorderRadius = 10;
            this.txt_SquareFeet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SquareFeet.DefaultText = "";
            this.txt_SquareFeet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SquareFeet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SquareFeet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SquareFeet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SquareFeet.FillColor = System.Drawing.Color.MistyRose;
            this.txt_SquareFeet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SquareFeet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SquareFeet.ForeColor = System.Drawing.Color.Black;
            this.txt_SquareFeet.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SquareFeet.Location = new System.Drawing.Point(361, 306);
            this.txt_SquareFeet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SquareFeet.Name = "txt_SquareFeet";
            this.txt_SquareFeet.PasswordChar = '\0';
            this.txt_SquareFeet.PlaceholderText = "";
            this.txt_SquareFeet.SelectedText = "";
            this.txt_SquareFeet.Size = new System.Drawing.Size(375, 31);
            this.txt_SquareFeet.TabIndex = 2;
            // 
            // txt_NumOfRooms
            // 
            this.txt_NumOfRooms.Animated = true;
            this.txt_NumOfRooms.BackColor = System.Drawing.Color.Transparent;
            this.txt_NumOfRooms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_NumOfRooms.BorderRadius = 10;
            this.txt_NumOfRooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NumOfRooms.DefaultText = "";
            this.txt_NumOfRooms.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_NumOfRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_NumOfRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NumOfRooms.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_NumOfRooms.FillColor = System.Drawing.Color.MistyRose;
            this.txt_NumOfRooms.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumOfRooms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_NumOfRooms.ForeColor = System.Drawing.Color.Black;
            this.txt_NumOfRooms.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumOfRooms.Location = new System.Drawing.Point(361, 250);
            this.txt_NumOfRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NumOfRooms.Name = "txt_NumOfRooms";
            this.txt_NumOfRooms.PasswordChar = '\0';
            this.txt_NumOfRooms.PlaceholderText = "";
            this.txt_NumOfRooms.SelectedText = "";
            this.txt_NumOfRooms.Size = new System.Drawing.Size(375, 31);
            this.txt_NumOfRooms.TabIndex = 1;
            // 
            // txt_House_id
            // 
            this.txt_House_id.Animated = true;
            this.txt_House_id.BackColor = System.Drawing.Color.Transparent;
            this.txt_House_id.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_House_id.BorderRadius = 10;
            this.txt_House_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_House_id.DefaultText = "";
            this.txt_House_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_House_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_House_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_House_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_House_id.FillColor = System.Drawing.Color.MistyRose;
            this.txt_House_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_House_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_House_id.ForeColor = System.Drawing.Color.Black;
            this.txt_House_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_House_id.Location = new System.Drawing.Point(361, 194);
            this.txt_House_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_House_id.Name = "txt_House_id";
            this.txt_House_id.PasswordChar = '\0';
            this.txt_House_id.PlaceholderText = "";
            this.txt_House_id.SelectedText = "";
            this.txt_House_id.Size = new System.Drawing.Size(375, 31);
            this.txt_House_id.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MistyRose;
            this.label6.Location = new System.Drawing.Point(67, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 26);
            this.label6.TabIndex = 137;
            this.label6.Text = "Square of Feet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(67, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 26);
            this.label5.TabIndex = 136;
            this.label5.Text = "Number of Rooms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(67, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 26);
            this.label4.TabIndex = 135;
            this.label4.Text = "House Id/ Colony lot No:";
            // 
            // btn_house
            // 
            this.btn_house.Animated = true;
            this.btn_house.BackColor = System.Drawing.Color.Transparent;
            this.btn_house.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_house.BorderRadius = 10;
            this.btn_house.BorderThickness = 2;
            this.btn_house.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_house.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_house.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_house.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_house.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_house.FillColor = System.Drawing.Color.Black;
            this.btn_house.Font = new System.Drawing.Font("Inter", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_house.ForeColor = System.Drawing.Color.White;
            this.btn_house.Location = new System.Drawing.Point(28, 126);
            this.btn_house.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_house.Name = "btn_house";
            this.btn_house.Size = new System.Drawing.Size(259, 46);
            this.btn_house.TabIndex = 131;
            this.btn_house.Text = "House Register";
            this.btn_house.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Inter", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(444, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 21);
            this.label2.TabIndex = 124;
            this.label2.Text = "A new chapter of human history";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(186)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(353, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 38);
            this.label1.TabIndex = 123;
            this.label1.Text = "E-Space Solutions (Pvt) Ltd";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 125;
            this.pictureBox1.TabStop = false;
            // 
            // HouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(992, 650);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "HouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HouseForm";
            this.Load += new System.EventHandler(this.HouseForm_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_House)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_house;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txt_SquareFeet;
        private Guna.UI2.WinForms.Guna2TextBox txt_NumOfRooms;
        private Guna.UI2.WinForms.Guna2TextBox txt_House_id;
        private System.Windows.Forms.DataGridView dGV_House;
        private Guna.UI2.WinForms.Guna2Button btn_Clear;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_register;
        private System.Windows.Forms.LinkLabel linkLabel_BackDshbrd;
        private System.Windows.Forms.LinkLabel linkLabel_Exit;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_ColonistId;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmb_Search;
    }
}