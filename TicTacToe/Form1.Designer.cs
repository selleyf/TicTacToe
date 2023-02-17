using System.Windows.Forms;

namespace TicTacToe
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._ButtonSize = new System.Windows.Forms.Button();
            this._Size = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.játékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._NewGame2 = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuSaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this._MenuLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this._CloseGame = new System.Windows.Forms.ToolStripMenuItem();
            this._SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Size)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._ButtonSize);
            this.groupBox1.Controls.Add(this._Size);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(616, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Méret";
            // 
            // _ButtonSize
            // 
            this._ButtonSize.Location = new System.Drawing.Point(433, 17);
            this._ButtonSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._ButtonSize.Name = "_ButtonSize";
            this._ButtonSize.Size = new System.Drawing.Size(152, 32);
            this._ButtonSize.TabIndex = 2;
            this._ButtonSize.Text = "Méretváltás";
            this._ButtonSize.UseVisualStyleBackColor = true;
            this._ButtonSize.Click += new System.EventHandler(this._ButtonSize_Click);
            // 
            // _Size
            // 
            this._Size.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._Size.Location = new System.Drawing.Point(153, 23);
            this._Size.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._Size.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this._Size.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._Size.Name = "_Size";
            this._Size.ReadOnly = true;
            this._Size.Size = new System.Drawing.Size(43, 22);
            this._Size.TabIndex = 1;
            this._Size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tábla mérete:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(16, 110);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(616, 62);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Játékosok";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(320, 23);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2. játékos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(43, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1. játékos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.játékToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // játékToolStripMenuItem
            // 
            this.játékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NewGame2,
            this._MenuSaveGame,
            this._MenuLoadGame,
            this._CloseGame});
            this.játékToolStripMenuItem.Name = "játékToolStripMenuItem";
            this.játékToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.játékToolStripMenuItem.Text = "Játék";
            // 
            // _NewGame2
            // 
            this._NewGame2.Name = "_NewGame2";
            this._NewGame2.Size = new System.Drawing.Size(200, 26);
            this._NewGame2.Text = "Új játék";
            this._NewGame2.Click += new System.EventHandler(this._NewGame2_Click);
            // 
            // _MenuSaveGame
            // 
            this._MenuSaveGame.Name = "_MenuSaveGame";
            this._MenuSaveGame.Size = new System.Drawing.Size(200, 26);
            this._MenuSaveGame.Text = "Játék mentése...";
            this._MenuSaveGame.Click += new System.EventHandler(this._MenuSaveGame_Click);
            // 
            // _MenuLoadGame
            // 
            this._MenuLoadGame.Name = "_MenuLoadGame";
            this._MenuLoadGame.Size = new System.Drawing.Size(200, 26);
            this._MenuLoadGame.Text = "Játék betöltése...";
            this._MenuLoadGame.Click += new System.EventHandler(this._MenuLoadGame_Click);
            // 
            // _CloseGame
            // 
            this._CloseGame.Name = "_CloseGame";
            this._CloseGame.Size = new System.Drawing.Size(200, 26);
            this._CloseGame.Text = "Bezárás";
            this._CloseGame.Click += new System.EventHandler(this._CloseGame_Click);
            // 
            // _SaveFileDialog
            // 
            this._SaveFileDialog.Filter = "TicTacToe Table (*.ttl)|*.ttl";
            this._SaveFileDialog.Title = "Save TicTacToe Table";
            // 
            // _OpenFileDialog
            // 
            this._OpenFileDialog.FileName = "openFileDialog1";
            this._OpenFileDialog.Filter = "TicTacToe Table (*.ttl)|*.ttl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 186);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Amőba";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Size)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown _Size;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button _ButtonSize;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem játékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _MenuSaveGame;
        private System.Windows.Forms.ToolStripMenuItem _MenuLoadGame;
        private System.Windows.Forms.SaveFileDialog _SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog _OpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem _NewGame2;
        private System.Windows.Forms.ToolStripMenuItem _CloseGame;
    }

}

