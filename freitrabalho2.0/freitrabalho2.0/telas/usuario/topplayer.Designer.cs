﻿namespace freitrabalho2._0.telas.usuario
{
    partial class topplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(topplayer));
            this.dvgtopplayer = new System.Windows.Forms.DataGridView();
            this.nick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.picbarra = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgtopplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgtopplayer
            // 
            this.dvgtopplayer.AllowUserToAddRows = false;
            this.dvgtopplayer.AllowUserToDeleteRows = false;
            this.dvgtopplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgtopplayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nick,
            this.id,
            this.pontuacao,
            this.idpontuacao,
            this.usuario});
            this.dvgtopplayer.Location = new System.Drawing.Point(118, 70);
            this.dvgtopplayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgtopplayer.Name = "dvgtopplayer";
            this.dvgtopplayer.ReadOnly = true;
            this.dvgtopplayer.Size = new System.Drawing.Size(634, 451);
            this.dvgtopplayer.TabIndex = 38;
            // 
            // nick
            // 
            this.nick.DataPropertyName = "nick";
            this.nick.HeaderText = "nick";
            this.nick.Name = "nick";
            this.nick.ReadOnly = true;
            this.nick.Width = 229;
            // 
            // id
            // 
            this.id.DataPropertyName = "idusuario";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // pontuacao
            // 
            this.pontuacao.DataPropertyName = "pontuacao";
            this.pontuacao.HeaderText = "pontuacao";
            this.pontuacao.Name = "pontuacao";
            this.pontuacao.ReadOnly = true;
            this.pontuacao.Width = 150;
            // 
            // idpontuacao
            // 
            this.idpontuacao.DataPropertyName = "idpontuacao";
            this.idpontuacao.HeaderText = "idpontuacao";
            this.idpontuacao.Name = "idpontuacao";
            this.idpontuacao.ReadOnly = true;
            this.idpontuacao.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "tbusuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            this.usuario.Width = 229;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Top player";
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Teal;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(718, -1);
            this.picclose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(58, 48);
            this.picclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picclose.TabIndex = 36;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            this.picclose.MouseEnter += new System.EventHandler(this.picclose_MouseEnter);
            this.picclose.MouseLeave += new System.EventHandler(this.picclose_MouseLeave);
            // 
            // picbarra
            // 
            this.picbarra.BackColor = System.Drawing.Color.Teal;
            this.picbarra.Location = new System.Drawing.Point(2, -1);
            this.picbarra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picbarra.Name = "picbarra";
            this.picbarra.Size = new System.Drawing.Size(774, 48);
            this.picbarra.TabIndex = 35;
            this.picbarra.TabStop = false;
            this.picbarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picbarra_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Silver;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(61, 141);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // topplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(772, 566);
            this.Controls.Add(this.dvgtopplayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picclose);
            this.Controls.Add(this.picbarra);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "topplayer";
            this.Text = "topplayer";
            ((System.ComponentModel.ISupportInitialize)(this.dvgtopplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgtopplayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nick;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpontuacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.PictureBox picbarra;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}