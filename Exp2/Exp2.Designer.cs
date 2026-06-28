namespace Exp2
{
    partial class Exp2
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
            label1 = new Label();
            tb_TargetIP = new TextBox();
            tb_TargetPort = new TextBox();
            label2 = new Label();
            bt_Listen = new Button();
            tb_ListenPort = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 21);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 29);
            label1.TabIndex = 0;
            label1.Text = "目標IP:";
            // 
            // tb_TargetIP
            // 
            tb_TargetIP.BorderStyle = BorderStyle.FixedSingle;
            tb_TargetIP.Location = new Point(108, 18);
            tb_TargetIP.Name = "tb_TargetIP";
            tb_TargetIP.Size = new Size(125, 37);
            tb_TargetIP.TabIndex = 1;
            tb_TargetIP.Text = "127.0.0.1";
            tb_TargetIP.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_TargetPort
            // 
            tb_TargetPort.BorderStyle = BorderStyle.FixedSingle;
            tb_TargetPort.Location = new Point(376, 18);
            tb_TargetPort.Name = "tb_TargetPort";
            tb_TargetPort.Size = new Size(101, 37);
            tb_TargetPort.TabIndex = 3;
            tb_TargetPort.Text = "80";
            tb_TargetPort.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 21);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 29);
            label2.TabIndex = 2;
            label2.Text = "目標Port:";
            // 
            // bt_Listen
            // 
            bt_Listen.Location = new Point(751, 14);
            bt_Listen.Name = "bt_Listen";
            bt_Listen.Size = new Size(120, 43);
            bt_Listen.TabIndex = 4;
            bt_Listen.Text = "監聽";
            bt_Listen.UseVisualStyleBackColor = true;
            bt_Listen.Click += bt_Listen_Click;
            // 
            // tb_ListenPort
            // 
            tb_ListenPort.BorderStyle = BorderStyle.FixedSingle;
            tb_ListenPort.Location = new Point(623, 18);
            tb_ListenPort.Name = "tb_ListenPort";
            tb_ListenPort.Size = new Size(101, 37);
            tb_ListenPort.TabIndex = 6;
            tb_ListenPort.Text = "90";
            tb_ListenPort.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(505, 21);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 29);
            label3.TabIndex = 5;
            label3.Text = "監聽Port:";
            // 
            // Exp2
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 443);
            Controls.Add(tb_ListenPort);
            Controls.Add(label3);
            Controls.Add(bt_Listen);
            Controls.Add(tb_TargetPort);
            Controls.Add(label2);
            Controls.Add(tb_TargetIP);
            Controls.Add(label1);
            Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 136);
            Margin = new Padding(5);
            Name = "Exp2";
            Text = "UDP 傳紙條";
            FormClosing += Exp2_FormClosing;
            Load += Exp2_Load;
            MouseDown += Exp2_MouseDown;
            MouseMove += Exp2_MouseMove;
            MouseUp += Exp2_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox tb_TargetIP;
        private TextBox tb_TargetPort;
        private Label label2;
        private Button bt_Listen;
        private TextBox tb_ListenPort;
        private Label label3;
    }
}
