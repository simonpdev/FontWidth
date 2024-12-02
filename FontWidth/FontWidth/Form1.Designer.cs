namespace FontWidth
{
    partial class frmBase
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnComputeWidth = new System.Windows.Forms.Button();
            this.lblCharWidth = new System.Windows.Forms.Label();
            this.lblCharHeight = new System.Windows.Forms.Label();
            this.lblSelectedFont = new System.Windows.Forms.Label();
            this.rtxOutputWidth = new System.Windows.Forms.RichTextBox();
            this.lblCharsWidth = new System.Windows.Forms.Label();
            this.lblCharset = new System.Windows.Forms.Label();
            this.txtCharset = new System.Windows.Forms.TextBox();
            this.imgFont = new System.Windows.Forms.PictureBox();
            this.pnlFontImage = new System.Windows.Forms.Panel();
            this.numLetterSpacing = new System.Windows.Forms.NumericUpDown();
            this.lblLetterSpacing = new System.Windows.Forms.Label();
            this.numCharHeight = new System.Windows.Forms.NumericUpDown();
            this.numCharWidth = new System.Windows.Forms.NumericUpDown();
            this.rtxOutputJSON = new System.Windows.Forms.RichTextBox();
            this.lblConstructJSON = new System.Windows.Forms.Label();
            this.numWordSpacing = new System.Windows.Forms.NumericUpDown();
            this.lblWordSpacing = new System.Windows.Forms.Label();
            this.btnCopyJSON = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbImageZoom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgFont)).BeginInit();
            this.pnlFontImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLetterSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(587, 409);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(168, 25);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Select image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.ImageBtn_Click);
            // 
            // btnComputeWidth
            // 
            this.btnComputeWidth.Location = new System.Drawing.Point(817, 409);
            this.btnComputeWidth.Name = "btnComputeWidth";
            this.btnComputeWidth.Size = new System.Drawing.Size(168, 25);
            this.btnComputeWidth.TabIndex = 6;
            this.btnComputeWidth.Text = "Calculate Char Width";
            this.btnComputeWidth.UseVisualStyleBackColor = true;
            this.btnComputeWidth.Click += new System.EventHandler(this.CharWidth_Click);
            // 
            // lblCharWidth
            // 
            this.lblCharWidth.AutoSize = true;
            this.lblCharWidth.Location = new System.Drawing.Point(25, 381);
            this.lblCharWidth.Name = "lblCharWidth";
            this.lblCharWidth.Size = new System.Drawing.Size(84, 13);
            this.lblCharWidth.TabIndex = 11;
            this.lblCharWidth.Text = "Character Width";
            // 
            // lblCharHeight
            // 
            this.lblCharHeight.AutoSize = true;
            this.lblCharHeight.Location = new System.Drawing.Point(155, 380);
            this.lblCharHeight.Name = "lblCharHeight";
            this.lblCharHeight.Size = new System.Drawing.Size(87, 13);
            this.lblCharHeight.TabIndex = 12;
            this.lblCharHeight.Text = "Character Height";
            // 
            // lblSelectedFont
            // 
            this.lblSelectedFont.AutoSize = true;
            this.lblSelectedFont.Location = new System.Drawing.Point(25, 18);
            this.lblSelectedFont.Name = "lblSelectedFont";
            this.lblSelectedFont.Size = new System.Drawing.Size(73, 13);
            this.lblSelectedFont.TabIndex = 17;
            this.lblSelectedFont.Text = "Selected Font";
            // 
            // rtxOutputWidth
            // 
            this.rtxOutputWidth.BackColor = System.Drawing.Color.White;
            this.rtxOutputWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxOutputWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxOutputWidth.Location = new System.Drawing.Point(587, 54);
            this.rtxOutputWidth.Name = "rtxOutputWidth";
            this.rtxOutputWidth.ReadOnly = true;
            this.rtxOutputWidth.Size = new System.Drawing.Size(398, 200);
            this.rtxOutputWidth.TabIndex = 18;
            this.rtxOutputWidth.Text = "";
            // 
            // lblCharsWidth
            // 
            this.lblCharsWidth.AutoSize = true;
            this.lblCharsWidth.Location = new System.Drawing.Point(584, 18);
            this.lblCharsWidth.Name = "lblCharsWidth";
            this.lblCharsWidth.Size = new System.Drawing.Size(89, 13);
            this.lblCharsWidth.TabIndex = 19;
            this.lblCharsWidth.Text = "Characters Width";
            // 
            // lblCharset
            // 
            this.lblCharset.AutoSize = true;
            this.lblCharset.Location = new System.Drawing.Point(25, 297);
            this.lblCharset.Name = "lblCharset";
            this.lblCharset.Size = new System.Drawing.Size(72, 13);
            this.lblCharset.TabIndex = 21;
            this.lblCharset.Text = "Character Set";
            // 
            // txtCharset
            // 
            this.txtCharset.Location = new System.Drawing.Point(28, 327);
            this.txtCharset.Name = "txtCharset";
            this.txtCharset.Size = new System.Drawing.Size(481, 20);
            this.txtCharset.TabIndex = 22;
            // 
            // imgFont
            // 
            this.imgFont.BackColor = System.Drawing.Color.Gainsboro;
            this.imgFont.Location = new System.Drawing.Point(3, 3);
            this.imgFont.Name = "imgFont";
            this.imgFont.Size = new System.Drawing.Size(471, 200);
            this.imgFont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFont.TabIndex = 16;
            this.imgFont.TabStop = false;
            // 
            // pnlFontImage
            // 
            this.pnlFontImage.AutoScroll = true;
            this.pnlFontImage.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlFontImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFontImage.Controls.Add(this.imgFont);
            this.pnlFontImage.Location = new System.Drawing.Point(28, 54);
            this.pnlFontImage.Name = "pnlFontImage";
            this.pnlFontImage.Size = new System.Drawing.Size(481, 210);
            this.pnlFontImage.TabIndex = 24;
            // 
            // numLetterSpacing
            // 
            this.numLetterSpacing.Location = new System.Drawing.Point(286, 412);
            this.numLetterSpacing.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numLetterSpacing.Name = "numLetterSpacing";
            this.numLetterSpacing.Size = new System.Drawing.Size(76, 20);
            this.numLetterSpacing.TabIndex = 27;
            // 
            // lblLetterSpacing
            // 
            this.lblLetterSpacing.AutoSize = true;
            this.lblLetterSpacing.Location = new System.Drawing.Point(283, 380);
            this.lblLetterSpacing.Name = "lblLetterSpacing";
            this.lblLetterSpacing.Size = new System.Drawing.Size(76, 13);
            this.lblLetterSpacing.TabIndex = 28;
            this.lblLetterSpacing.Text = "Letter Spacing";
            // 
            // numCharHeight
            // 
            this.numCharHeight.Location = new System.Drawing.Point(158, 412);
            this.numCharHeight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCharHeight.Name = "numCharHeight";
            this.numCharHeight.Size = new System.Drawing.Size(84, 20);
            this.numCharHeight.TabIndex = 29;
            this.numCharHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // numCharWidth
            // 
            this.numCharWidth.Location = new System.Drawing.Point(28, 412);
            this.numCharWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numCharWidth.Name = "numCharWidth";
            this.numCharWidth.Size = new System.Drawing.Size(84, 20);
            this.numCharWidth.TabIndex = 30;
            this.numCharWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // rtxOutputJSON
            // 
            this.rtxOutputJSON.BackColor = System.Drawing.Color.White;
            this.rtxOutputJSON.Location = new System.Drawing.Point(587, 318);
            this.rtxOutputJSON.Name = "rtxOutputJSON";
            this.rtxOutputJSON.ReadOnly = true;
            this.rtxOutputJSON.Size = new System.Drawing.Size(398, 75);
            this.rtxOutputJSON.TabIndex = 31;
            this.rtxOutputJSON.Text = "";
            // 
            // lblConstructJSON
            // 
            this.lblConstructJSON.AutoSize = true;
            this.lblConstructJSON.Location = new System.Drawing.Point(584, 288);
            this.lblConstructJSON.Name = "lblConstructJSON";
            this.lblConstructJSON.Size = new System.Drawing.Size(92, 13);
            this.lblConstructJSON.TabIndex = 32;
            this.lblConstructJSON.Text = "Construct 2 JSON";
            // 
            // numWordSpacing
            // 
            this.numWordSpacing.Location = new System.Drawing.Point(407, 412);
            this.numWordSpacing.Name = "numWordSpacing";
            this.numWordSpacing.Size = new System.Drawing.Size(76, 20);
            this.numWordSpacing.TabIndex = 33;
            // 
            // lblWordSpacing
            // 
            this.lblWordSpacing.AutoSize = true;
            this.lblWordSpacing.Location = new System.Drawing.Point(408, 380);
            this.lblWordSpacing.Name = "lblWordSpacing";
            this.lblWordSpacing.Size = new System.Drawing.Size(75, 13);
            this.lblWordSpacing.TabIndex = 34;
            this.lblWordSpacing.Text = "Word Spacing";
            // 
            // btnCopyJSON
            // 
            this.btnCopyJSON.Location = new System.Drawing.Point(910, 283);
            this.btnCopyJSON.Name = "btnCopyJSON";
            this.btnCopyJSON.Size = new System.Drawing.Size(75, 23);
            this.btnCopyJSON.TabIndex = 35;
            this.btnCopyJSON.Text = "Copy JSON";
            this.btnCopyJSON.UseVisualStyleBackColor = true;
            this.btnCopyJSON.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Zoom";
            // 
            // cmbImageZoom
            // 
            this.cmbImageZoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageZoom.FormattingEnabled = true;
            this.cmbImageZoom.Location = new System.Drawing.Point(450, 18);
            this.cmbImageZoom.Name = "cmbImageZoom";
            this.cmbImageZoom.Size = new System.Drawing.Size(59, 21);
            this.cmbImageZoom.TabIndex = 38;
            this.cmbImageZoom.SelectedIndexChanged += new System.EventHandler(this.ComboZoom_SelectedIndexChanged);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 484);
            this.Controls.Add(this.cmbImageZoom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCopyJSON);
            this.Controls.Add(this.lblWordSpacing);
            this.Controls.Add(this.numWordSpacing);
            this.Controls.Add(this.lblConstructJSON);
            this.Controls.Add(this.rtxOutputJSON);
            this.Controls.Add(this.numCharWidth);
            this.Controls.Add(this.numCharHeight);
            this.Controls.Add(this.lblLetterSpacing);
            this.Controls.Add(this.numLetterSpacing);
            this.Controls.Add(this.pnlFontImage);
            this.Controls.Add(this.txtCharset);
            this.Controls.Add(this.lblCharset);
            this.Controls.Add(this.lblCharsWidth);
            this.Controls.Add(this.rtxOutputWidth);
            this.Controls.Add(this.lblSelectedFont);
            this.Controls.Add(this.lblCharHeight);
            this.Controls.Add(this.lblCharWidth);
            this.Controls.Add(this.btnComputeWidth);
            this.Controls.Add(this.btnLoadImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1033, 523);
            this.MinimumSize = new System.Drawing.Size(1033, 523);
            this.Name = "frmBase";
            this.ShowIcon = false;
            this.Text = "FontWidth";
            this.Load += new System.EventHandler(this.frmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFont)).EndInit();
            this.pnlFontImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLetterSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCharWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordSpacing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnComputeWidth;
        private System.Windows.Forms.Label lblCharWidth;
        private System.Windows.Forms.Label lblCharHeight;
        private System.Windows.Forms.Label lblSelectedFont;
        private System.Windows.Forms.RichTextBox rtxOutputWidth;
        private System.Windows.Forms.Label lblCharsWidth;
        private System.Windows.Forms.Label lblCharset;
        private System.Windows.Forms.TextBox txtCharset;
        private System.Windows.Forms.PictureBox imgFont;
        private System.Windows.Forms.Panel pnlFontImage;
        private System.Windows.Forms.NumericUpDown numLetterSpacing;
        private System.Windows.Forms.Label lblLetterSpacing;
        private System.Windows.Forms.NumericUpDown numCharHeight;
        private System.Windows.Forms.NumericUpDown numCharWidth;
        private System.Windows.Forms.RichTextBox rtxOutputJSON;
        private System.Windows.Forms.Label lblConstructJSON;
        private System.Windows.Forms.NumericUpDown numWordSpacing;
        private System.Windows.Forms.Label lblWordSpacing;
        private System.Windows.Forms.Button btnCopyJSON;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbImageZoom;
    }
}

