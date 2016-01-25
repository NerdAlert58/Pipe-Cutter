namespace Pipe_Cutter
{
    partial class BevelCalc
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExample = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblWallThickness = new System.Windows.Forms.Label();
            this.lblBevel = new System.Windows.Forms.Label();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.TBWallThick = new System.Windows.Forms.TextBox();
            this.TBBevelAngle = new System.Windows.Forms.TextBox();
            this.TBHypotenuse = new System.Windows.Forms.TextBox();
            this.TBHeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(13, 13);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(185, 49);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 69);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(185, 49);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(13, 125);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(185, 49);
            this.btnExample.TabIndex = 2;
            this.btnExample.Text = "&Example";
            this.btnExample.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(13, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 49);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWallThickness
            // 
            this.lblWallThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallThickness.Location = new System.Drawing.Point(204, 35);
            this.lblWallThickness.Name = "lblWallThickness";
            this.lblWallThickness.Size = new System.Drawing.Size(184, 27);
            this.lblWallThickness.TabIndex = 4;
            this.lblWallThickness.Text = "Wall Thickness";
            this.lblWallThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBevel
            // 
            this.lblBevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBevel.Location = new System.Drawing.Point(204, 83);
            this.lblBevel.Name = "lblBevel";
            this.lblBevel.Size = new System.Drawing.Size(184, 27);
            this.lblBevel.TabIndex = 5;
            this.lblBevel.Text = "Bevel Angle";
            this.lblBevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHypotenuse.Location = new System.Drawing.Point(204, 131);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(184, 27);
            this.lblHypotenuse.TabIndex = 6;
            this.lblHypotenuse.Text = "Hypotenuse";
            this.lblHypotenuse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(204, 179);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(184, 27);
            this.lblHeight.TabIndex = 7;
            this.lblHeight.Text = "Height";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBWallThick
            // 
            this.TBWallThick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBWallThick.Location = new System.Drawing.Point(394, 30);
            this.TBWallThick.Name = "TBWallThick";
            this.TBWallThick.Size = new System.Drawing.Size(282, 35);
            this.TBWallThick.TabIndex = 8;
            this.TBWallThick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBBevelAngle
            // 
            this.TBBevelAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBevelAngle.Location = new System.Drawing.Point(394, 78);
            this.TBBevelAngle.Name = "TBBevelAngle";
            this.TBBevelAngle.Size = new System.Drawing.Size(282, 35);
            this.TBBevelAngle.TabIndex = 9;
            this.TBBevelAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBHypotenuse
            // 
            this.TBHypotenuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBHypotenuse.Location = new System.Drawing.Point(394, 126);
            this.TBHypotenuse.Name = "TBHypotenuse";
            this.TBHypotenuse.Size = new System.Drawing.Size(282, 35);
            this.TBHypotenuse.TabIndex = 10;
            this.TBHypotenuse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBHeight
            // 
            this.TBHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBHeight.Location = new System.Drawing.Point(394, 174);
            this.TBHeight.Name = "TBHeight";
            this.TBHeight.Size = new System.Drawing.Size(282, 35);
            this.TBHeight.TabIndex = 11;
            this.TBHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pipe_Cutter.Properties.Resources.BevelProfile;
            this.pictureBox1.Location = new System.Drawing.Point(13, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BevelCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBHeight);
            this.Controls.Add(this.TBHypotenuse);
            this.Controls.Add(this.TBBevelAngle);
            this.Controls.Add(this.TBWallThick);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.lblBevel);
            this.Controls.Add(this.lblWallThickness);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "BevelCalc";
            this.Text = "Pipe Bevel Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblWallThickness;
        private System.Windows.Forms.Label lblBevel;
        private System.Windows.Forms.Label lblHypotenuse;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox TBWallThick;
        private System.Windows.Forms.TextBox TBBevelAngle;
        private System.Windows.Forms.TextBox TBHypotenuse;
        private System.Windows.Forms.TextBox TBHeight;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

