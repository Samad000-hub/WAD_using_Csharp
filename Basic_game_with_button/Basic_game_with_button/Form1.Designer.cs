namespace Basic_game_with_button
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
            this.btnRight = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.frmwidth = new System.Windows.Forms.Button();
            this.frmheight = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.objLeft = new System.Windows.Forms.Button();
            this.objWidth = new System.Windows.Forms.Button();
            this.objTop = new System.Windows.Forms.Button();
            this.objHeight = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(12, 12);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 0;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(93, 13);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(174, 13);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(255, 13);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // frmwidth
            // 
            this.frmwidth.Location = new System.Drawing.Point(465, 13);
            this.frmwidth.Name = "frmwidth";
            this.frmwidth.Size = new System.Drawing.Size(114, 23);
            this.frmwidth.TabIndex = 4;
            this.frmwidth.Text = "Show Form Width";
            this.frmwidth.UseVisualStyleBackColor = true;
            this.frmwidth.Click += new System.EventHandler(this.frmwidth_Click);
            // 
            // frmheight
            // 
            this.frmheight.Location = new System.Drawing.Point(465, 54);
            this.frmheight.Name = "frmheight";
            this.frmheight.Size = new System.Drawing.Size(114, 23);
            this.frmheight.TabIndex = 5;
            this.frmheight.Text = "Show Form Height";
            this.frmheight.UseVisualStyleBackColor = true;
            this.frmheight.Click += new System.EventHandler(this.frmheight_Click);
            // 
            // exitApp
            // 
            this.exitApp.Location = new System.Drawing.Point(465, 97);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(114, 23);
            this.exitApp.TabIndex = 6;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // objLeft
            // 
            this.objLeft.Location = new System.Drawing.Point(624, 13);
            this.objLeft.Name = "objLeft";
            this.objLeft.Size = new System.Drawing.Size(114, 23);
            this.objLeft.TabIndex = 7;
            this.objLeft.Text = "Object Left";
            this.objLeft.UseVisualStyleBackColor = true;
            this.objLeft.Click += new System.EventHandler(this.objLeft_Click);
            // 
            // objWidth
            // 
            this.objWidth.Location = new System.Drawing.Point(624, 54);
            this.objWidth.Name = "objWidth";
            this.objWidth.Size = new System.Drawing.Size(114, 23);
            this.objWidth.TabIndex = 8;
            this.objWidth.Text = "Object WIdth";
            this.objWidth.UseVisualStyleBackColor = true;
            this.objWidth.Click += new System.EventHandler(this.objWidth_Click);
            // 
            // objTop
            // 
            this.objTop.Location = new System.Drawing.Point(624, 97);
            this.objTop.Name = "objTop";
            this.objTop.Size = new System.Drawing.Size(114, 23);
            this.objTop.TabIndex = 9;
            this.objTop.Text = "Object Top";
            this.objTop.UseVisualStyleBackColor = true;
            this.objTop.Click += new System.EventHandler(this.objTop_Click);
            // 
            // objHeight
            // 
            this.objHeight.Location = new System.Drawing.Point(624, 142);
            this.objHeight.Name = "objHeight";
            this.objHeight.Size = new System.Drawing.Size(114, 23);
            this.objHeight.TabIndex = 10;
            this.objHeight.Text = "Object Height";
            this.objHeight.UseVisualStyleBackColor = true;
            this.objHeight.Click += new System.EventHandler(this.objHeight_Click);
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(30, 240);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(164, 54);
            this.btnMove.TabIndex = 11;
            this.btnMove.Text = "Object to move";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.objHeight);
            this.Controls.Add(this.objTop);
            this.Controls.Add(this.objWidth);
            this.Controls.Add(this.objLeft);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.frmheight);
            this.Controls.Add(this.frmwidth);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button frmwidth;
        private System.Windows.Forms.Button frmheight;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Button objLeft;
        private System.Windows.Forms.Button objWidth;
        private System.Windows.Forms.Button objTop;
        private System.Windows.Forms.Button objHeight;
        private System.Windows.Forms.Button btnMove;
    }
}

