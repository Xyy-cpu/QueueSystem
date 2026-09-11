namespace QueueSystem
{
    partial class QueuingForm
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
            btnCashier = new Button();
            lblQueue = new Label();
            label2 = new Label();
            btnList = new Button();
            SuspendLayout();
            // 
            // btnCashier
            // 
            btnCashier.Font = new Font("Segoe UI", 9.969231F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCashier.Location = new Point(79, 72);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(100, 100);
            btnCashier.TabIndex = 0;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 16.0615387F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(311, 97);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(148, 40);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "P - 10007";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8461533F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(242, 39);
            label2.Name = "label2";
            label2.Size = new Size(277, 35);
            label2.TabIndex = 2;
            label2.Text = "Your Position in Queue";
            // 
            // btnList
            // 
            btnList.Location = new Point(438, 220);
            btnList.Name = "btnList";
            btnList.Size = new Size(102, 31);
            btnList.TabIndex = 3;
            btnList.Text = "To Cashier";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 254);
            Controls.Add(btnList);
            Controls.Add(label2);
            Controls.Add(lblQueue);
            Controls.Add(btnCashier);
            Name = "QueuingForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCashier;
        private Label lblQueue;
        private Label label2;
        private Button btnList;
    }
}
