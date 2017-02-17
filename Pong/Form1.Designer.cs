namespace Pong
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPointCounter = new System.Windows.Forms.TextBox();
            this.lblGamePoints = new System.Windows.Forms.Label();
            this.lblEndGamePoints = new System.Windows.Forms.Label();
            this.txtEndGamePoints = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(419, 491);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(125, 15);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Black;
            this.ball.Location = new System.Drawing.Point(458, 281);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(10, 10);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.Controls.Add(this.txtEndGamePoints);
            this.playground.Controls.Add(this.lblEndGamePoints);
            this.playground.Controls.Add(this.lblGamePoints);
            this.playground.Controls.Add(this.txtPointCounter);
            this.playground.Controls.Add(this.label2);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(956, 509);
            this.playground.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "YOU SUCK AT THIS GAME!!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press ESC to quit!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPointCounter
            // 
            this.txtPointCounter.Enabled = false;
            this.txtPointCounter.Location = new System.Drawing.Point(81, 12);
            this.txtPointCounter.Name = "txtPointCounter";
            this.txtPointCounter.ShortcutsEnabled = false;
            this.txtPointCounter.Size = new System.Drawing.Size(39, 20);
            this.txtPointCounter.TabIndex = 0;
            this.txtPointCounter.TabStop = false;
            // 
            // lblGamePoints
            // 
            this.lblGamePoints.AutoSize = true;
            this.lblGamePoints.Location = new System.Drawing.Point(25, 15);
            this.lblGamePoints.Name = "lblGamePoints";
            this.lblGamePoints.Size = new System.Drawing.Size(50, 13);
            this.lblGamePoints.TabIndex = 5;
            this.lblGamePoints.Text = "POINTS:";
            // 
            // lblEndGamePoints
            // 
            this.lblEndGamePoints.AutoSize = true;
            this.lblEndGamePoints.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndGamePoints.Location = new System.Drawing.Point(289, 317);
            this.lblEndGamePoints.Name = "lblEndGamePoints";
            this.lblEndGamePoints.Size = new System.Drawing.Size(134, 42);
            this.lblEndGamePoints.TabIndex = 6;
            this.lblEndGamePoints.Text = "SCORE:";
            this.lblEndGamePoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEndGamePoints
            // 
            this.txtEndGamePoints.Enabled = false;
            this.txtEndGamePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndGamePoints.Location = new System.Drawing.Point(429, 319);
            this.txtEndGamePoints.Name = "txtEndGamePoints";
            this.txtEndGamePoints.ShortcutsEnabled = false;
            this.txtEndGamePoints.Size = new System.Drawing.Size(147, 44);
            this.txtEndGamePoints.TabIndex = 7;
            this.txtEndGamePoints.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 509);
            this.Controls.Add(this.playground);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPointCounter;
        private System.Windows.Forms.Label lblGamePoints;
        private System.Windows.Forms.TextBox txtEndGamePoints;
        private System.Windows.Forms.Label lblEndGamePoints;
    }
}

