namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_CloseMainWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CloseMainWindow
            // 
            this.BTN_CloseMainWindow.AccessibleName = "BTN_CloseMainWindow";
            this.BTN_CloseMainWindow.CausesValidation = false;
            this.BTN_CloseMainWindow.Location = new System.Drawing.Point(2132, 1184);
            this.BTN_CloseMainWindow.Name = "BTN_CloseMainWindow";
            this.BTN_CloseMainWindow.Size = new System.Drawing.Size(219, 153);
            this.BTN_CloseMainWindow.TabIndex = 0;
            this.BTN_CloseMainWindow.Text = "BTN_CloseMainWindow";
            this.BTN_CloseMainWindow.UseVisualStyleBackColor = true;
            this.BTN_CloseMainWindow.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.Unbenannt;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(2363, 1349);
            this.Controls.Add(this.BTN_CloseMainWindow);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BTN_CloseMainWindow;
        private Button BTN_CloseMainWindow1;
    }
}