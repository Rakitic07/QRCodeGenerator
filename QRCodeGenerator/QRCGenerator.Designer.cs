namespace QRCGenerator
{
    partial class QRCGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRCGenerator));
            this.circleProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.FormEclipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.GenerateQRBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.SaveQR = new Bunifu.Framework.UI.BunifuFlatButton();
            this.QRText = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // circleProgress
            // 
            this.circleProgress.animated = true;
            this.circleProgress.animationIterval = 5;
            this.circleProgress.animationSpeed = 15;
            this.circleProgress.BackColor = System.Drawing.Color.White;
            this.circleProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circleProgress.BackgroundImage")));
            this.circleProgress.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.circleProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.circleProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(89)))), ((int)(((byte)(171)))));
            this.circleProgress.LabelVisible = true;
            this.circleProgress.LineProgressThickness = 12;
            this.circleProgress.LineThickness = 7;
            this.circleProgress.Location = new System.Drawing.Point(201, 196);
            this.circleProgress.Margin = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this.circleProgress.MaxValue = 102;
            this.circleProgress.Name = "circleProgress";
            this.circleProgress.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circleProgress.ProgressColor = System.Drawing.Color.SeaGreen;
            this.circleProgress.Size = new System.Drawing.Size(201, 201);
            this.circleProgress.TabIndex = 6;
            this.circleProgress.Value = 0;
            // 
            // FormEclipse
            // 
            this.FormEclipse.ElipseRadius = 25;
            this.FormEclipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.circleProgress);
            this.panel1.Controls.Add(this.pBox);
            this.panel1.Controls.Add(this.GenerateQRBtn);
            this.panel1.Controls.Add(this.SaveQR);
            this.panel1.Controls.Add(this.QRText);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 641);
            this.panel1.TabIndex = 7;
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pBox.Location = new System.Drawing.Point(19, 69);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(545, 493);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBox.TabIndex = 9;
            this.pBox.TabStop = false;
            // 
            // GenerateQRBtn
            // 
            this.GenerateQRBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.GenerateQRBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenerateQRBtn.color = System.Drawing.Color.SeaGreen;
            this.GenerateQRBtn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.GenerateQRBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateQRBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.GenerateQRBtn.ForeColor = System.Drawing.Color.White;
            this.GenerateQRBtn.Image = null;
            this.GenerateQRBtn.ImagePosition = 20;
            this.GenerateQRBtn.ImageZoom = 50;
            this.GenerateQRBtn.LabelPosition = 32;
            this.GenerateQRBtn.LabelText = "Generate";
            this.GenerateQRBtn.Location = new System.Drawing.Point(363, 573);
            this.GenerateQRBtn.Margin = new System.Windows.Forms.Padding(6);
            this.GenerateQRBtn.Name = "GenerateQRBtn";
            this.GenerateQRBtn.Size = new System.Drawing.Size(157, 39);
            this.GenerateQRBtn.TabIndex = 8;
            this.GenerateQRBtn.Click += new System.EventHandler(this.GenerateQRBtn_Click);
            // 
            // SaveQR
            // 
            this.SaveQR.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.SaveQR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.SaveQR.BackgroundImage = global::QRCGenerator.Properties.Resources.Save;
            this.SaveQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveQR.BorderRadius = 0;
            this.SaveQR.ButtonText = "";
            this.SaveQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveQR.DisabledColor = System.Drawing.Color.Gray;
            this.SaveQR.Iconcolor = System.Drawing.Color.Transparent;
            this.SaveQR.Iconimage = null;
            this.SaveQR.Iconimage_right = null;
            this.SaveQR.Iconimage_right_Selected = null;
            this.SaveQR.Iconimage_Selected = null;
            this.SaveQR.IconMarginLeft = 0;
            this.SaveQR.IconMarginRight = 0;
            this.SaveQR.IconRightVisible = true;
            this.SaveQR.IconRightZoom = 0D;
            this.SaveQR.IconVisible = true;
            this.SaveQR.IconZoom = 90D;
            this.SaveQR.IsTab = false;
            this.SaveQR.Location = new System.Drawing.Point(523, 572);
            this.SaveQR.Name = "SaveQR";
            this.SaveQR.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(35)))));
            this.SaveQR.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveQR.OnHoverTextColor = System.Drawing.Color.White;
            this.SaveQR.selected = false;
            this.SaveQR.Size = new System.Drawing.Size(49, 42);
            this.SaveQR.TabIndex = 7;
            this.SaveQR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveQR.Textcolor = System.Drawing.Color.White;
            this.SaveQR.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // QRText
            // 
            this.QRText.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.QRText.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QRText.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QRText.BorderThickness = 3;
            this.QRText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QRText.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.QRText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.QRText.isPassword = false;
            this.QRText.Location = new System.Drawing.Point(17, 571);
            this.QRText.Margin = new System.Windows.Forms.Padding(4);
            this.QRText.Name = "QRText";
            this.QRText.Size = new System.Drawing.Size(336, 44);
            this.QRText.TabIndex = 1;
            this.QRText.Text = "...Your Text here...";
            this.QRText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QRText.Enter += new System.EventHandler(this.QRText_Enter);
            this.QRText.Leave += new System.EventHandler(this.QRText_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(190)))));
            this.panel2.Controls.Add(this.bunifuFlatButton2);
            this.panel2.Controls.Add(this.bunifuFlatButton1);
            this.panel2.Location = new System.Drawing.Point(0, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 51);
            this.panel2.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "-";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(467, 9);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(51, 38);
            this.bunifuFlatButton2.TabIndex = 9;
            this.bunifuFlatButton2.Text = "-";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.BunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "X";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(521, 9);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(190)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(51, 38);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "X";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.panel1;
            this.DragControl.Vertical = true;
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.panel2;
            this.DragControl2.Vertical = true;
            // 
            // DragControl3
            // 
            this.DragControl3.Fixed = true;
            this.DragControl3.Horizontal = true;
            this.DragControl3.TargetControl = this.pBox;
            this.DragControl3.Vertical = true;
            // 
            // QRCGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 624);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "QRCGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRCode Generator";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse FormEclipse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
        private Bunifu.Framework.UI.BunifuMetroTextbox QRText;
        private Bunifu.Framework.UI.BunifuFlatButton SaveQR;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circleProgress;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuTileButton GenerateQRBtn;
        private System.Windows.Forms.PictureBox pBox;
        private Bunifu.Framework.UI.BunifuDragControl DragControl3;
    }
}

