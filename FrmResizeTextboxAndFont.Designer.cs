namespace FormResizeTextboxAndFonts
{
    partial class FrmResizeTextboxAndFont
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
            this.btnClick = new System.Windows.Forms.Button();
            this.TxtSingle = new System.Windows.Forms.TextBox();
            this.TxtMultiline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(15, 38);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(100, 40);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            // 
            // TxtSingle
            // 
            this.TxtSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSingle.Location = new System.Drawing.Point(144, 44);
            this.TxtSingle.Name = "TxtSingle";
            this.TxtSingle.Size = new System.Drawing.Size(150, 29);
            this.TxtSingle.TabIndex = 1;
            this.TxtSingle.Text = "Single Line";
            // 
            // TxtMultiline
            // 
            this.TxtMultiline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMultiline.Location = new System.Drawing.Point(322, 44);
            this.TxtMultiline.Multiline = true;
            this.TxtMultiline.Name = "TxtMultiline";
            this.TxtMultiline.Size = new System.Drawing.Size(150, 29);
            this.TxtMultiline.TabIndex = 2;
            this.TxtMultiline.Text = "Multiline";
            // 
            // FrmResizeTextboxAndFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.TxtMultiline);
            this.Controls.Add(this.TxtSingle);
            this.Controls.Add(this.btnClick);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FrmResizeTextboxAndFont";
            this.Text = "Form Resize Textbox abd Fonts";
            this.Load += new System.EventHandler(this.FrmResizeTextboxAndFont_Load);
            this.Resize += new System.EventHandler(this.FrmResizeTextboxAndFont_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox TxtSingle;
        private System.Windows.Forms.TextBox TxtMultiline;
    }
}

