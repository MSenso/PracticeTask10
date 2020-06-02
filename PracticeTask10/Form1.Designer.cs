namespace PracticeTask10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.созданиеСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычислениеПолиномаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.list_output = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеСпискаToolStripMenuItem,
            this.вычислениеПолиномаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(408, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // созданиеСпискаToolStripMenuItem
            // 
            this.созданиеСпискаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.созданиеСпискаToolStripMenuItem.Name = "созданиеСпискаToolStripMenuItem";
            this.созданиеСпискаToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.созданиеСпискаToolStripMenuItem.Text = "Создание списка";
            this.созданиеСпискаToolStripMenuItem.Click += new System.EventHandler(this.созданиеСпискаToolStripMenuItem_Click);
            // 
            // вычислениеПолиномаToolStripMenuItem
            // 
            this.вычислениеПолиномаToolStripMenuItem.Enabled = false;
            this.вычислениеПолиномаToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вычислениеПолиномаToolStripMenuItem.Name = "вычислениеПолиномаToolStripMenuItem";
            this.вычислениеПолиномаToolStripMenuItem.Size = new System.Drawing.Size(158, 25);
            this.вычислениеПолиномаToolStripMenuItem.Text = "Вычисление полинома";
            this.вычислениеПолиномаToolStripMenuItem.Click += new System.EventHandler(this.вычислениеПолиномаToolStripMenuItem_Click);
            // 
            // list_output
            // 
            this.list_output.AutoSize = true;
            this.list_output.BackColor = System.Drawing.Color.Transparent;
            this.list_output.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.list_output.Location = new System.Drawing.Point(12, 44);
            this.list_output.Name = "list_output";
            this.list_output.Size = new System.Drawing.Size(0, 33);
            this.list_output.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PracticeTask10.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(408, 492);
            this.Controls.Add(this.list_output);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Полином";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem созданиеСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычислениеПолиномаToolStripMenuItem;
        private System.Windows.Forms.Label list_output;
    }
}

