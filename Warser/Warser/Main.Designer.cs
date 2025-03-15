namespace Warser
{
    partial class Main
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txt_search = new TextBox();
            btn_search = new Button();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 510);
            webView21.Name = "webView21";
            webView21.Size = new Size(988, 43);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(-179, 55);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(172, 27);
            txt_search.TabIndex = 1;
            txt_search.TextChanged += textBox1_TextChanged;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_search.AutoSize = true;
            btn_search.Location = new Point(692, 4);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(294, 30);
            btn_search.TabIndex = 2;
            btn_search.Text = "search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += button1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(48, 108);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txt_search);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(536, 237);
            splitContainer1.SplitterDistance = 178;
            splitContainer1.TabIndex = 3;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(988, 553);
            Controls.Add(splitContainer1);
            Controls.Add(btn_search);
            Controls.Add(webView21);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox txt_search;
        private Button btn_search;
        private SplitContainer splitContainer1;
    }
}