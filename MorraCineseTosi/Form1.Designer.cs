namespace MorraCineseTosi
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
            CartaBtn = new Button();
            ForbiciBtn = new Button();
            SassoBtn = new Button();
            ResultLbl = new Label();
            PlayerChoicePic = new PictureBox();
            CpuChoicePic = new PictureBox();
            VersusPic = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            playerWinsLbl = new Label();
            cpuWinsLbl = new Label();
            drawsLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)PlayerChoicePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CpuChoicePic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VersusPic).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CartaBtn
            // 
            CartaBtn.AutoSize = true;
            CartaBtn.Image = Properties.Resources.Carta;
            CartaBtn.Location = new Point(12, 83);
            CartaBtn.Name = "CartaBtn";
            CartaBtn.Size = new Size(171, 171);
            CartaBtn.TabIndex = 0;
            CartaBtn.UseVisualStyleBackColor = true;
            CartaBtn.Click += CartaBtn_Click;
            // 
            // ForbiciBtn
            // 
            ForbiciBtn.AutoSize = true;
            ForbiciBtn.Image = Properties.Resources.Forbice;
            ForbiciBtn.Location = new Point(189, 83);
            ForbiciBtn.Name = "ForbiciBtn";
            ForbiciBtn.Size = new Size(171, 171);
            ForbiciBtn.TabIndex = 1;
            ForbiciBtn.UseVisualStyleBackColor = true;
            ForbiciBtn.Click += ForbiciBtn_Click;
            // 
            // SassoBtn
            // 
            SassoBtn.AutoSize = true;
            SassoBtn.Image = Properties.Resources.Sasso;
            SassoBtn.Location = new Point(366, 84);
            SassoBtn.Name = "SassoBtn";
            SassoBtn.Size = new Size(171, 170);
            SassoBtn.TabIndex = 2;
            SassoBtn.UseVisualStyleBackColor = true;
            SassoBtn.Click += SassoBtn_Click;
            // 
            // ResultLbl
            // 
            ResultLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ResultLbl.Location = new Point(12, 257);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.Size = new Size(525, 218);
            ResultLbl.TabIndex = 3;
            ResultLbl.Text = "Scegli la mossa";
            ResultLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PlayerChoicePic
            // 
            PlayerChoicePic.Location = new Point(12, 478);
            PlayerChoicePic.Name = "PlayerChoicePic";
            PlayerChoicePic.Size = new Size(171, 171);
            PlayerChoicePic.SizeMode = PictureBoxSizeMode.Zoom;
            PlayerChoicePic.TabIndex = 4;
            PlayerChoicePic.TabStop = false;
            // 
            // CpuChoicePic
            // 
            CpuChoicePic.Location = new Point(366, 478);
            CpuChoicePic.Name = "CpuChoicePic";
            CpuChoicePic.Size = new Size(171, 171);
            CpuChoicePic.SizeMode = PictureBoxSizeMode.Zoom;
            CpuChoicePic.TabIndex = 5;
            CpuChoicePic.TabStop = false;
            // 
            // VersusPic
            // 
            VersusPic.Image = Properties.Resources.vs;
            VersusPic.Location = new Point(189, 478);
            VersusPic.Name = "VersusPic";
            VersusPic.Size = new Size(171, 171);
            VersusPic.SizeMode = PictureBoxSizeMode.Zoom;
            VersusPic.TabIndex = 6;
            VersusPic.TabStop = false;
            VersusPic.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(drawsLbl);
            groupBox1.Controls.Add(cpuWinsLbl);
            groupBox1.Controls.Add(playerWinsLbl);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(543, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(676, 688);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Risultati";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(358, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(8, 8);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // playerWinsLbl
            // 
            playerWinsLbl.AutoSize = true;
            playerWinsLbl.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            playerWinsLbl.Location = new Point(573, 129);
            playerWinsLbl.Name = "playerWinsLbl";
            playerWinsLbl.Size = new Size(52, 62);
            playerWinsLbl.TabIndex = 1;
            playerWinsLbl.Text = "0";
            // 
            // cpuWinsLbl
            // 
            cpuWinsLbl.AutoSize = true;
            cpuWinsLbl.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            cpuWinsLbl.Location = new Point(573, 245);
            cpuWinsLbl.Name = "cpuWinsLbl";
            cpuWinsLbl.Size = new Size(52, 62);
            cpuWinsLbl.TabIndex = 2;
            cpuWinsLbl.Text = "0";
            // 
            // drawsLbl
            // 
            drawsLbl.AutoSize = true;
            drawsLbl.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            drawsLbl.Location = new Point(573, 362);
            drawsLbl.Name = "drawsLbl";
            drawsLbl.Size = new Size(52, 62);
            drawsLbl.TabIndex = 3;
            drawsLbl.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 129);
            label1.Name = "label1";
            label1.Size = new Size(394, 62);
            label1.TabIndex = 4;
            label1.Text = "Vittorie Giocatore";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 245);
            label2.Name = "label2";
            label2.Size = new Size(279, 62);
            label2.TabIndex = 5;
            label2.Text = "Vittorie CPU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 362);
            label3.Name = "label3";
            label3.Size = new Size(183, 62);
            label3.TabIndex = 6;
            label3.Text = "Pareggi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 712);
            Controls.Add(groupBox1);
            Controls.Add(VersusPic);
            Controls.Add(CpuChoicePic);
            Controls.Add(PlayerChoicePic);
            Controls.Add(ResultLbl);
            Controls.Add(SassoBtn);
            Controls.Add(ForbiciBtn);
            Controls.Add(CartaBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PlayerChoicePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)CpuChoicePic).EndInit();
            ((System.ComponentModel.ISupportInitialize)VersusPic).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CartaBtn;
        private Button ForbiciBtn;
        private Button SassoBtn;
        private Label ResultLbl;
        private PictureBox PlayerChoicePic;
        private PictureBox CpuChoicePic;
        private PictureBox VersusPic;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label drawsLbl;
        private Label cpuWinsLbl;
        private Label playerWinsLbl;
        private GroupBox groupBox2;
    }
}