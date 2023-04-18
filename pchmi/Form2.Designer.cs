namespace pchmi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.diary = new System.Windows.Forms.Button();
            this.recs = new System.Windows.Forms.Button();
            this.basic = new System.Windows.Forms.Button();
            this.snack = new System.Windows.Forms.PictureBox();
            this.dinner = new System.Windows.Forms.PictureBox();
            this.lunch = new System.Windows.Forms.PictureBox();
            this.breakfast = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.snack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // diary
            // 
            this.diary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.diary.Font = new System.Drawing.Font("T-FLEX Type B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diary.Location = new System.Drawing.Point(831, 7);
            this.diary.Margin = new System.Windows.Forms.Padding(4);
            this.diary.Name = "diary";
            this.diary.Size = new System.Drawing.Size(220, 95);
            this.diary.TabIndex = 8;
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
            this.recs.TabIndex = 7;
            this.recs.Text = "Рецепты";
            this.recs.UseVisualStyleBackColor = true;
            // 
            // basic
            // 
            this.basic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.basic.Font = new System.Drawing.Font("T-FLEX Type B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.basic.Location = new System.Drawing.Point(375, 7);
            this.basic.Margin = new System.Windows.Forms.Padding(4);
            this.basic.Name = "basic";
            this.basic.Size = new System.Drawing.Size(220, 95);
            this.basic.TabIndex = 6;
            this.basic.Text = "Главная";
            this.basic.UseVisualStyleBackColor = true;
            this.basic.Click += new System.EventHandler(this.basic_Click);
            // 
            // snack
            // 
            this.snack.BackgroundImage = global::pchmi.Properties.Resources.snack;
            this.snack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snack.Location = new System.Drawing.Point(831, 425);
            this.snack.Margin = new System.Windows.Forms.Padding(4);
            this.snack.Name = "snack";
            this.snack.Size = new System.Drawing.Size(220, 203);
            this.snack.TabIndex = 16;
            this.snack.TabStop = false;
            this.snack.Click += new System.EventHandler(this.snack_Click);
            // 
            // dinner
            // 
            this.dinner.BackgroundImage = global::pchmi.Properties.Resources.dinner;
            this.dinner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dinner.Location = new System.Drawing.Point(603, 425);
            this.dinner.Margin = new System.Windows.Forms.Padding(4);
            this.dinner.Name = "dinner";
            this.dinner.Size = new System.Drawing.Size(220, 203);
            this.dinner.TabIndex = 14;
            this.dinner.TabStop = false;
            this.dinner.Click += new System.EventHandler(this.dinner_Click);
            // 
            // lunch
            // 
            this.lunch.BackgroundImage = global::pchmi.Properties.Resources.lunch;
            this.lunch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lunch.Location = new System.Drawing.Point(831, 161);
            this.lunch.Margin = new System.Windows.Forms.Padding(4);
            this.lunch.Name = "lunch";
            this.lunch.Size = new System.Drawing.Size(220, 203);
            this.lunch.TabIndex = 12;
            this.lunch.TabStop = false;
            this.lunch.Click += new System.EventHandler(this.lunch_Click);
            // 
            // breakfast
            // 
            this.breakfast.BackgroundImage = global::pchmi.Properties.Resources.bkfst;
            this.breakfast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breakfast.Location = new System.Drawing.Point(603, 161);
            this.breakfast.Margin = new System.Windows.Forms.Padding(4);
            this.breakfast.Name = "breakfast";
            this.breakfast.Size = new System.Drawing.Size(220, 203);
            this.breakfast.TabIndex = 10;
            this.breakfast.TabStop = false;
            this.breakfast.Click += new System.EventHandler(this.breakfast_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 103);
            this.pictureBox2.TabIndex = 9;
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
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.CausesValidation = false;
            this.checkedListBox1.Font = new System.Drawing.Font("T-FLEX Type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Яица",
            "Молоко",
            "Творог",
            "Сыр",
            "Курица",
            "Индейка",
            "Говядина",
            "Картофель",
            "Морковь",
            "Помидор",
            "Огурец"});
            this.checkedListBox1.Location = new System.Drawing.Point(17, 190);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(132, 240);
            this.checkedListBox1.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("T-FLEX Type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(16, 457);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 33);
            this.button4.TabIndex = 21;
            this.button4.Text = "Поиск";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.SystemColors.Info;
            this.checkedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox2.Font = new System.Drawing.Font("T-FLEX Type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Авокадо",
            "Зелень",
            "Клубника",
            "Смородина",
            "Яблоко",
            "Банан",
            "Крупа гречневая",
            "Крупа перловая",
            "Крупа пшенная",
            "Рис",
            "Макаронные изделия"});
            this.checkedListBox2.Location = new System.Drawing.Point(157, 190);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(205, 240);
            this.checkedListBox2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(665, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Завтрак";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(905, 364);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Обед";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(677, 628);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ужин";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(889, 628);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Перекус";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(604, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Подборка рецептов специально для Вас";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("T-FLEX Type B", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 58);
            this.label6.TabIndex = 28;
            this.label6.Text = "Укажите желаемые продукты,\r\nи мы подберем для Вас рецепт";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1065, 694);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.snack);
            this.Controls.Add(this.dinner);
            this.Controls.Add(this.lunch);
            this.Controls.Add(this.breakfast);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.diary);
            this.Controls.Add(this.recs);
            this.Controls.Add(this.basic);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.snack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakfast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button diary;
        private System.Windows.Forms.Button recs;
        private System.Windows.Forms.Button basic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox breakfast;
        private System.Windows.Forms.PictureBox lunch;
        private System.Windows.Forms.PictureBox dinner;
        private System.Windows.Forms.PictureBox snack;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}