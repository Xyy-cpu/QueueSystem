namespace QueueSystem
{
    partial class ServingForm
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
            lblServingNum = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblServingNum
            // 
            lblServingNum.AutoSize = true;
            lblServingNum.Font = new Font("Segoe UI Semibold", 23.8153839F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblServingNum.Location = new Point(152, 104);
            lblServingNum.Name = "lblServingNum";
            lblServingNum.Size = new Size(93, 59);
            lblServingNum.TabIndex = 0;
            lblServingNum.Text = "----";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.2769222F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(152, 39);
            label2.Name = "label2";
            label2.Size = new Size(219, 45);
            label2.TabIndex = 1;
            label2.Text = "Now Serving";
            // 
            // ServingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 251);
            Controls.Add(label2);
            Controls.Add(lblServingNum);
            Name = "ServingForm";
            Text = "ServingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServingNum;
        private Label label2;
    }
}