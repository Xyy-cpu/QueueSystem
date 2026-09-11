namespace QueueSystem
{
    partial class CashierWindowQueueForm
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
            components = new System.ComponentModel.Container();
            btnNext = new Button();
            btnRefresh = new Button();
            listCashierQueue = new ListView();
            btnBack = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnNext
            // 
            btnNext.Location = new Point(18, 21);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(102, 31);
            btnNext.TabIndex = 0;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(18, 58);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 31);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.Location = new Point(126, 21);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(223, 320);
            listCashierQueue.TabIndex = 2;
            listCashierQueue.UseCompatibleStateImageBehavior = false;
            listCashierQueue.View = View.List;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 331);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 31);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 374);
            Controls.Add(btnBack);
            Controls.Add(listCashierQueue);
            Controls.Add(btnRefresh);
            Controls.Add(btnNext);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNext;
        private Button btnRefresh;
        private ListView listCashierQueue;
        private Button btnBack;
        private System.Windows.Forms.Timer timer1;
    }
}