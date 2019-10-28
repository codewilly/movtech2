﻿namespace movtech.Desktop.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonUserLogged = new System.Windows.Forms.Button();
            this.buttonEntranceAndExit = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureMinimize = new System.Windows.Forms.PictureBox();
            this.pictureRestore = new System.Windows.Forms.PictureBox();
            this.pictureMaximize = new System.Windows.Forms.PictureBox();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            this.pictureHamburguer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHamburguer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelSidebar.Controls.Add(this.buttonExit);
            this.panelSidebar.Controls.Add(this.buttonUserLogged);
            this.panelSidebar.Controls.Add(this.pictureBox2);
            this.panelSidebar.Controls.Add(this.buttonEntranceAndExit);
            this.panelSidebar.Controls.Add(this.buttonHome);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 611);
            this.panelSidebar.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(0, 559);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonExit.Size = new System.Drawing.Size(250, 40);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Sair";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonUserLogged
            // 
            this.buttonUserLogged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserLogged.FlatAppearance.BorderSize = 0;
            this.buttonUserLogged.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonUserLogged.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonUserLogged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserLogged.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserLogged.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUserLogged.Image = ((System.Drawing.Image)(resources.GetObject("buttonUserLogged.Image")));
            this.buttonUserLogged.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUserLogged.Location = new System.Drawing.Point(0, 513);
            this.buttonUserLogged.Name = "buttonUserLogged";
            this.buttonUserLogged.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonUserLogged.Size = new System.Drawing.Size(250, 40);
            this.buttonUserLogged.TabIndex = 8;
            this.buttonUserLogged.Text = "     Marco Antonio";
            this.buttonUserLogged.UseVisualStyleBackColor = true;
            // 
            // buttonEntranceAndExit
            // 
            this.buttonEntranceAndExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEntranceAndExit.FlatAppearance.BorderSize = 0;
            this.buttonEntranceAndExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonEntranceAndExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonEntranceAndExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntranceAndExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntranceAndExit.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEntranceAndExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEntranceAndExit.Image")));
            this.buttonEntranceAndExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEntranceAndExit.Location = new System.Drawing.Point(0, 311);
            this.buttonEntranceAndExit.Name = "buttonEntranceAndExit";
            this.buttonEntranceAndExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonEntranceAndExit.Size = new System.Drawing.Size(250, 40);
            this.buttonEntranceAndExit.TabIndex = 2;
            this.buttonEntranceAndExit.Text = "       Entrada / Saída";
            this.buttonEntranceAndExit.UseVisualStyleBackColor = true;
            this.buttonEntranceAndExit.Click += new System.EventHandler(this.ButtonEntranceAndExit_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonHome.Location = new System.Drawing.Point(0, 263);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHome.Size = new System.Drawing.Size(250, 40);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.Text = "Início";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.ButtonHome_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTitle.Controls.Add(this.pictureMinimize);
            this.panelTitle.Controls.Add(this.pictureRestore);
            this.panelTitle.Controls.Add(this.pictureMaximize);
            this.panelTitle.Controls.Add(this.pictureExit);
            this.panelTitle.Controls.Add(this.pictureHamburguer);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(250, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1034, 50);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitle_MouseDown);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 50);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1034, 561);
            this.panelContainer.TabIndex = 2;
            // 
            // pictureMinimize
            // 
            this.pictureMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureMinimize.Image")));
            this.pictureMinimize.Location = new System.Drawing.Point(915, 7);
            this.pictureMinimize.Name = "pictureMinimize";
            this.pictureMinimize.Size = new System.Drawing.Size(25, 25);
            this.pictureMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimize.TabIndex = 4;
            this.pictureMinimize.TabStop = false;
            this.pictureMinimize.Click += new System.EventHandler(this.PictureMinimize_Click);
            // 
            // pictureRestore
            // 
            this.pictureRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureRestore.Image = ((System.Drawing.Image)(resources.GetObject("pictureRestore.Image")));
            this.pictureRestore.Location = new System.Drawing.Point(946, 7);
            this.pictureRestore.Name = "pictureRestore";
            this.pictureRestore.Size = new System.Drawing.Size(25, 25);
            this.pictureRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRestore.TabIndex = 3;
            this.pictureRestore.TabStop = false;
            this.pictureRestore.Visible = false;
            this.pictureRestore.Click += new System.EventHandler(this.PictureRestore_Click);
            // 
            // pictureMaximize
            // 
            this.pictureMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureMaximize.Image = global::movtech.Desktop.Properties.Resources.maximize_size_option;
            this.pictureMaximize.Location = new System.Drawing.Point(946, 7);
            this.pictureMaximize.Name = "pictureMaximize";
            this.pictureMaximize.Size = new System.Drawing.Size(25, 25);
            this.pictureMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMaximize.TabIndex = 2;
            this.pictureMaximize.TabStop = false;
            this.pictureMaximize.Click += new System.EventHandler(this.PictureMaximize_Click);
            // 
            // pictureExit
            // 
            this.pictureExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureExit.ErrorImage")));
            this.pictureExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureExit.Image")));
            this.pictureExit.Location = new System.Drawing.Point(977, 7);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(25, 25);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 1;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.PictureExit_Click);
            // 
            // pictureHamburguer
            // 
            this.pictureHamburguer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureHamburguer.ErrorImage = null;
            this.pictureHamburguer.Image = ((System.Drawing.Image)(resources.GetObject("pictureHamburguer.Image")));
            this.pictureHamburguer.Location = new System.Drawing.Point(12, 7);
            this.pictureHamburguer.Name = "pictureHamburguer";
            this.pictureHamburguer.Size = new System.Drawing.Size(61, 35);
            this.pictureHamburguer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHamburguer.TabIndex = 0;
            this.pictureHamburguer.TabStop = false;
            this.pictureHamburguer.Click += new System.EventHandler(this.pictureHamburguer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelSidebar.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHamburguer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureHamburguer;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureMaximize;
        private System.Windows.Forms.PictureBox pictureExit;
        private System.Windows.Forms.PictureBox pictureMinimize;
        private System.Windows.Forms.PictureBox pictureRestore;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonEntranceAndExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonUserLogged;
        private System.Windows.Forms.Button buttonExit;
    }
}