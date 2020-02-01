using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Xsl;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DOM.Checked = true;
        }
        string path = "XMLFile1.xml";
        List<Anime> final = new List<Anime>();
        private Anime User_ch()
        {
            string[] info = new string[6];
            if (title.Checked && titlelist.SelectedItem!=null) info[0] = Convert.ToString(titlelist.SelectedItem);
            if (author.Checked && authorlist.SelectedItem != null) info[1] = Convert.ToString(authorlist.SelectedItem);
            if (year.Checked && yearlist.SelectedItem != null) info[2] = Convert.ToString(yearlist.SelectedItem);
            if (episodes.Checked && episodeslist.SelectedItem != null) info[3] = Convert.ToString(episodeslist.SelectedItem);
            if (rating.Checked && ratinglist.SelectedItem != null) info[4] = Convert.ToString(ratinglist.SelectedItem);
            if (genre.Checked && genrelist.SelectedItem != null) info[5] = Convert.ToString(genrelist.SelectedItem);
            Anime a = new Anime(info);
            return a;
        }
        private void Output(List<Anime> final)
        {
            foreach(Anime a in final)
            {
                richTextBox1.AppendText(a.title+"\n");
                richTextBox1.AppendText(a.author + "\n");
                richTextBox1.AppendText(a.year + "\n");
                richTextBox1.AppendText(a.episodes + "\n");
                richTextBox1.AppendText(a.rating + "\n");
                richTextBox1.AppendText(a.genres + "\n");
                richTextBox1.AppendText("------------------------------------------------\n");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Title_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Authorlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Anime a = User_ch();
            if(DOM.Checked)
            {
                Istrategy istrategy = new DOM(path);                                                                                     istrategy = new LINQ(path);
                final = istrategy.Search(a, path);
                Output(final);
            }
            if (SAX.Checked)
            {
                Istrategy istrategy = new SAX(path);                                                                      
                final = istrategy.Search(a, path);
                Output(final);
            }
            if (LINQ.Checked)
            {
                Istrategy istrategy = new LINQ(path);
                final = istrategy.Search(a, path);
                Output(final);
            }
        }

        private void Yearlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Titlelist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            title.Checked = false;
            author.Checked = false;
            year.Checked = false;
            rating.Checked = false;
            episodes.Checked = false;
            genre.Checked = false;

            titlelist.SelectedItem = null;
            authorlist.SelectedItem = null;
            yearlist.SelectedItem = null;
            ratinglist.SelectedItem = null;
            episodeslist.SelectedItem = null;
            genrelist.SelectedItem = null;

            DOM.Checked = true;

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("C:/OOP/laba3/XSLTFile1.xsl");
            string input= @"C:\OOP\laba3\output.xml"; //<?xml-stylesheet type="text/xsl" href="XSLTFile1.xsl"?>
            string result=@"lol.html";
            xslt.Transform(input, result);
            
        }
    }
}
