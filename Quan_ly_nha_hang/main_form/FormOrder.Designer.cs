namespace main_form
{
    using main_form.Draw;
    partial class FormOrder
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
            pan_table = new Panel();
            pan_detail = new Panel();
            SuspendLayout();
            // 
            // pan_table
            // 
            pan_table.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_table.Location = new Point(0, 0);
            pan_table.Name = "pan_table";
            pan_table.Size = new Size(308, 545);
            pan_table.TabIndex = 0;
            // 
            // pan_detail
            // 
            pan_detail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pan_detail.Location = new Point(275, 1);
            pan_detail.Name = "pan_detail";
            pan_detail.Size = new Size(675, 544);
            pan_detail.TabIndex = 0;
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 545);
            Controls.Add(pan_detail);
            Controls.Add(pan_table);
            Name = "FormOrder";
            Text = "FormOrder";
            ResumeLayout(false);
        }

        #endregion

        private Panel pan_table;
        private Panel pan_detail;
        DrawPanel dpanel = new DrawPanel();
    }
}