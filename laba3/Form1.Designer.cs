namespace laba3
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
            this.title = new System.Windows.Forms.CheckBox();
            this.author = new System.Windows.Forms.CheckBox();
            this.year = new System.Windows.Forms.CheckBox();
            this.episodes = new System.Windows.Forms.CheckBox();
            this.rating = new System.Windows.Forms.CheckBox();
            this.genre = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Button();
            this.convert = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.titlelist = new System.Windows.Forms.ComboBox();
            this.yearlist = new System.Windows.Forms.ComboBox();
            this.authorlist = new System.Windows.Forms.ComboBox();
            this.episodeslist = new System.Windows.Forms.ComboBox();
            this.genrelist = new System.Windows.Forms.ComboBox();
            this.ratinglist = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(12, 50);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(42, 17);
            this.title.TabIndex = 0;
            this.title.Text = "title";
            this.title.UseVisualStyleBackColor = true;
            this.title.CheckedChanged += new System.EventHandler(this.Title_CheckedChanged);
            // 
            // author
            // 
            this.author.AutoSize = true;
            this.author.Location = new System.Drawing.Point(12, 98);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(56, 17);
            this.author.TabIndex = 1;
            this.author.Text = "author";
            this.author.UseVisualStyleBackColor = true;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(12, 145);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(46, 17);
            this.year.TabIndex = 2;
            this.year.Text = "year";
            this.year.UseVisualStyleBackColor = true;
            // 
            // episodes
            // 
            this.episodes.AutoSize = true;
            this.episodes.Location = new System.Drawing.Point(12, 194);
            this.episodes.Name = "episodes";
            this.episodes.Size = new System.Drawing.Size(68, 17);
            this.episodes.TabIndex = 3;
            this.episodes.Text = "episodes";
            this.episodes.UseVisualStyleBackColor = true;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(12, 244);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(52, 17);
            this.rating.TabIndex = 4;
            this.rating.Text = "rating";
            this.rating.UseVisualStyleBackColor = true;
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(15, 299);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(53, 17);
            this.genre.TabIndex = 5;
            this.genre.Text = "genre";
            this.genre.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(323, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(469, 453);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(15, 357);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(50, 17);
            this.DOM.TabIndex = 13;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(97, 357);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(46, 17);
            this.SAX.TabIndex = 14;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(178, 357);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(50, 17);
            this.LINQ.TabIndex = 15;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(15, 403);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(93, 31);
            this.search.TabIndex = 16;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(157, 403);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(105, 31);
            this.convert.TabIndex = 17;
            this.convert.Text = "convert to HTML";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(88, 448);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(93, 31);
            this.clear.TabIndex = 18;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // titlelist
            // 
            this.titlelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titlelist.Items.AddRange(new object[] {
            "Naruto",
            "Bleach",
            "Sword Art Online",
            "Psycho Pass",
            "Hagane no renkinjutsushi",
            "Blue exorcist",
            "Kuroshitsuji"});
            this.titlelist.Location = new System.Drawing.Point(96, 48);
            this.titlelist.Name = "titlelist";
            this.titlelist.Size = new System.Drawing.Size(121, 21);
            this.titlelist.TabIndex = 19;
            this.titlelist.SelectedIndexChanged += new System.EventHandler(this.Titlelist_SelectedIndexChanged);
            // 
            // yearlist
            // 
            this.yearlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearlist.Items.AddRange(new object[] {
            "2012",
            "2002",
            "2004",
            "2003",
            "2006",
            "2011"});
            this.yearlist.Location = new System.Drawing.Point(96, 143);
            this.yearlist.Name = "yearlist";
            this.yearlist.Size = new System.Drawing.Size(121, 21);
            this.yearlist.TabIndex = 20;
            this.yearlist.SelectedIndexChanged += new System.EventHandler(this.Yearlist_SelectedIndexChanged);
            // 
            // authorlist
            // 
            this.authorlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorlist.Items.AddRange(new object[] {
            "Masasi Kisimoto",
            "Tite Kubo",
            "Reki Kawahara",
            "Naoyoshi Shiotani",
            "Hiromu Arakawa",
            "Kazue Kato",
            "Yana Toboso"});
            this.authorlist.Location = new System.Drawing.Point(96, 96);
            this.authorlist.Name = "authorlist";
            this.authorlist.Size = new System.Drawing.Size(121, 21);
            this.authorlist.TabIndex = 21;
            // 
            // episodeslist
            // 
            this.episodeslist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.episodeslist.Items.AddRange(new object[] {
            "720",
            "366",
            "96",
            "41",
            "51",
            "25",
            "37"});
            this.episodeslist.Location = new System.Drawing.Point(96, 192);
            this.episodeslist.Name = "episodeslist";
            this.episodeslist.Size = new System.Drawing.Size(121, 21);
            this.episodeslist.TabIndex = 22;
            // 
            // genrelist
            // 
            this.genrelist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genrelist.Items.AddRange(new object[] {
            "adventure",
            "fantasy",
            "martial arts",
            "supernatural",
            "science fiction",
            "crime",
            "cyberpunk",
            "dystopia",
            "dark fantasy",
            "thriller"});
            this.genrelist.Location = new System.Drawing.Point(97, 299);
            this.genrelist.Name = "genrelist";
            this.genrelist.Size = new System.Drawing.Size(121, 21);
            this.genrelist.TabIndex = 23;
            // 
            // ratinglist
            // 
            this.ratinglist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ratinglist.Items.AddRange(new object[] {
            "8.5",
            "8.1",
            "7.7",
            "8.2",
            "8.6",
            "7.6",
            "7.8"});
            this.ratinglist.Location = new System.Drawing.Point(97, 244);
            this.ratinglist.Name = "ratinglist";
            this.ratinglist.Size = new System.Drawing.Size(121, 21);
            this.ratinglist.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.ratinglist);
            this.Controls.Add(this.genrelist);
            this.Controls.Add(this.episodeslist);
            this.Controls.Add(this.authorlist);
            this.Controls.Add(this.yearlist);
            this.Controls.Add(this.titlelist);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.search);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.episodes);
            this.Controls.Add(this.year);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Zaytseva Elyzaveta laba3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox title;
        private System.Windows.Forms.CheckBox author;
        private System.Windows.Forms.CheckBox year;
        private System.Windows.Forms.CheckBox episodes;
        private System.Windows.Forms.CheckBox rating;
        private System.Windows.Forms.CheckBox genre;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox titlelist;
        private System.Windows.Forms.ComboBox yearlist;
        private System.Windows.Forms.ComboBox authorlist;
        private System.Windows.Forms.ComboBox episodeslist;
        private System.Windows.Forms.ComboBox genrelist;
        private System.Windows.Forms.ComboBox ratinglist;
    }
}

