namespace main_form
{
    using main_form;
    using main_form.Draw;

    partial class Form_Main
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
            pan_funtion = new Panel();
            pan_order = new Panel();
            SuspendLayout();
            // 
            // pan_funtion
            // 
            pan_funtion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pan_funtion.Location = new Point(0, 0);
            pan_funtion.Name = "pan_funtion";
            pan_funtion.Size = new Size(525, 533);
            pan_funtion.TabIndex = 0;
            pan_funtion.Paint += dpanel.DrawRight;
            // 
            // pan_order
            // 
            pan_order.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pan_order.Location = new Point(460, 0);
            pan_order.Name = "pan_order";
            pan_order.Size = new Size(589, 532);
            pan_order.TabIndex = 0;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 533);
            Controls.Add(pan_funtion);
            Controls.Add(pan_order);
            MaximizeBox = false;
            Name = "Form_Main";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private Panel pan_funtion;
        private Panel pan_order;
        DrawPanel dpanel = new DrawPanel();
    }
}
