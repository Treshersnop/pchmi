namespace pchmi
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button4 = new System.Windows.Forms.Button();
            this.diary = new System.Windows.Forms.Button();
            this.recs = new System.Windows.Forms.Button();
            this.basic = new System.Windows.Forms.Button();
            this.name_r = new System.Windows.Forms.Label();
            this.val_r = new System.Windows.Forms.Label();
            this.time_r = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ingr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("T-FLEX Type B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(16, 121);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 39);
            this.button4.TabIndex = 45;
            this.button4.Text = "🠔";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // diary
            // 
            this.diary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diary.Font = new System.Drawing.Font("T-FLEX Type B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diary.Location = new System.Drawing.Point(831, 7);
            this.diary.Margin = new System.Windows.Forms.Padding(4);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(220, 95);
            this.diary.TabIndex = 43;
            this.diary.Text = "Дневник питания";
            this.diary.UseVisualStyleBackColor = true;
            this.diary.Click += new System.EventHandler(this.diary_Click);
            // 
            // recs
            // 
            this.recs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.recs.Font = new System.Drawing.Font("T-FLEX Type B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recs.Location = new System.Drawing.Point(603, 7);
            this.recs.Margin = new System.Windows.Forms.Padding(4);
            this.recs.Name = "recs";
            this.recs.Size = new System.Drawing.Size(220, 95);
            this.recs.TabIndex = 42;
            this.recs.Text = "Рецепты";
            this.recs.UseVisualStyleBackColor = true;
            this.recs.Click += new System.EventHandler(this.recs_Click);
            // 
            // basic
            // 
            this.basic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.basic.Font = new System.Drawing.Font("T-FLEX Type B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basic.Location = new System.Drawing.Point(375, 7);
            this.basic.Margin = new System.Windows.Forms.Padding(4);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(220, 95);
            this.basic.TabIndex = 41;
            this.basic.Text = "Главная";
            this.basic.UseVisualStyleBackColor = true;
            this.basic.Click += new System.EventHandler(this.basic_Click);
            // 
            // name_r
            // 
            this.name_r.AutoSize = true;
            this.name_r.Font = new System.Drawing.Font("T-FLEX Type B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_r.Location = new System.Drawing.Point(307, 177);
            this.name_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_r.Name = "name_r";
            this.name_r.Size = new System.Drawing.Size(243, 33);
            this.name_r.TabIndex = 47;
            this.name_r.Text = "Название рецепта";
            // 
            // val_r
            // 
            this.val_r.AutoSize = true;
            this.val_r.Font = new System.Drawing.Font("T-FLEX Type B", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.val_r.Location = new System.Drawing.Point(16, 503);
            this.val_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.val_r.Name = "val_r";
            this.val_r.Size = new System.Drawing.Size(78, 33);
            this.val_r.TabIndex = 49;
            this.val_r.Text = "КБЖУ";
            // 
            // time_r
            // 
            this.time_r.AutoSize = true;
            this.time_r.Font = new System.Drawing.Font("T-FLEX Type B", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_r.Location = new System.Drawing.Point(16, 457);
            this.time_r.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time_r.Name = "time_r";
            this.time_r.Size = new System.Drawing.Size(84, 33);
            this.time_r.TabIndex = 48;
            this.time_r.Text = "Время";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desc.Location = new System.Drawing.Point(308, 304);
            this.desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desc.MaximumSize = new System.Drawing.Size(750, 0);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(684, 348);
            this.desc.TabIndex = 50;
            this.desc.Text = resources.GetString("desc.Text");
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBox1.Font = new System.Drawing.Font("T-FLEX Type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье",
            "Отложенное"});
            this.comboBox1.Location = new System.Drawing.Point(820, 121);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 35);
            this.comboBox1.TabIndex = 56;
            this.comboBox1.Text = "Добавить в дневник";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::pchmi.Properties.Resources.snack2;
            this.pictureBox3.Location = new System.Drawing.Point(16, 177);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 261);
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 103);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1065, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // ingr
            // 
            this.ingr.AutoSize = true;
            this.ingr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ingr.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingr.Location = new System.Drawing.Point(308, 210);
            this.ingr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ingr.MaximumSize = new System.Drawing.Size(750, 0);
            this.ingr.Name = "ingr";
            this.ingr.Size = new System.Drawing.Size(520, 87);
            this.ingr.TabIndex = 57;
            this.ingr.Text = "Ингредиенты ингериенты ингериенты ингериенты\r\nИнгредиенты ингериенты ингериенты и" +
    "нгериенты\r\nИнгредиенты ингериенты ингериенты ингериенты";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1065, 694);
            this.Controls.Add(this.ingr);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.val_r);
            this.Controls.Add(this.time_r);
            this.Controls.Add(this.name_r);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.diary);
            this.Controls.Add(this.recs);
            this.Controls.Add(this.basic);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button diary;
        private System.Windows.Forms.Button recs;
        private System.Windows.Forms.Button basic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label name_r;
        private System.Windows.Forms.Label val_r;
        private System.Windows.Forms.Label time_r;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ingr;
    }
}