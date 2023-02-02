
namespace Приложуха
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Startbutton1 = new System.Windows.Forms.Button();
            this.Wallbutton1 = new System.Windows.Forms.Button();
            this.Endbutton1 = new System.Windows.Forms.Button();
            this.Findbutton1 = new System.Windows.Forms.Button();
            this.Restartbutton1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(859, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // Startbutton1
            // 
            this.Startbutton1.BackColor = System.Drawing.Color.White;
            this.Startbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Startbutton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Startbutton1.Location = new System.Drawing.Point(953, 38);
            this.Startbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Startbutton1.Name = "Startbutton1";
            this.Startbutton1.Size = new System.Drawing.Size(235, 75);
            this.Startbutton1.TabIndex = 1;
            this.Startbutton1.Text = "Начальная точка";
            this.Startbutton1.UseVisualStyleBackColor = false;
            this.Startbutton1.Click += new System.EventHandler(this.Gobutton1_Click);
            // 
            // Wallbutton1
            // 
            this.Wallbutton1.BackColor = System.Drawing.Color.Blue;
            this.Wallbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Wallbutton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.Wallbutton1.Location = new System.Drawing.Point(953, 121);
            this.Wallbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Wallbutton1.Name = "Wallbutton1";
            this.Wallbutton1.Size = new System.Drawing.Size(235, 74);
            this.Wallbutton1.TabIndex = 2;
            this.Wallbutton1.Text = "Задать заборы";
            this.Wallbutton1.UseVisualStyleBackColor = false;
            this.Wallbutton1.Click += new System.EventHandler(this.Wallbutton1_Click);
            // 
            // Endbutton1
            // 
            this.Endbutton1.BackColor = System.Drawing.Color.Red;
            this.Endbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Endbutton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.Endbutton1.Location = new System.Drawing.Point(953, 202);
            this.Endbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Endbutton1.Name = "Endbutton1";
            this.Endbutton1.Size = new System.Drawing.Size(235, 94);
            this.Endbutton1.TabIndex = 3;
            this.Endbutton1.Text = "Конечная точка";
            this.Endbutton1.UseVisualStyleBackColor = false;
            this.Endbutton1.Click += new System.EventHandler(this.Endbutton1_Click);
            // 
            // Findbutton1
            // 
            this.Findbutton1.BackColor = System.Drawing.Color.Purple;
            this.Findbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Findbutton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.Findbutton1.Location = new System.Drawing.Point(16, 438);
            this.Findbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Findbutton1.Name = "Findbutton1";
            this.Findbutton1.Size = new System.Drawing.Size(235, 75);
            this.Findbutton1.TabIndex = 4;
            this.Findbutton1.Text = "Поиск пути";
            this.Findbutton1.UseVisualStyleBackColor = false;
            this.Findbutton1.Click += new System.EventHandler(this.Findbutton1_Click);
            // 
            // Restartbutton1
            // 
            this.Restartbutton1.BackColor = System.Drawing.Color.Purple;
            this.Restartbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restartbutton1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.Restartbutton1.Location = new System.Drawing.Point(259, 451);
            this.Restartbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Restartbutton1.Name = "Restartbutton1";
            this.Restartbutton1.Size = new System.Drawing.Size(179, 48);
            this.Restartbutton1.TabIndex = 5;
            this.Restartbutton1.Text = "Сброс ";
            this.Restartbutton1.UseVisualStyleBackColor = false;
            this.Restartbutton1.Click += new System.EventHandler(this.Restartbutton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.оПрограммеToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 554);
            this.Controls.Add(this.Restartbutton1);
            this.Controls.Add(this.Findbutton1);
            this.Controls.Add(this.Endbutton1);
            this.Controls.Add(this.Wallbutton1);
            this.Controls.Add(this.Startbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Ли";
            this.Load += new System.EventHandler(this.MainApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Startbutton1;
        private System.Windows.Forms.Button Wallbutton1;
        private System.Windows.Forms.Button Endbutton1;
        private System.Windows.Forms.Button Findbutton1;
        private System.Windows.Forms.Button Restartbutton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
    }
}