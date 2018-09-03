﻿using MOBA_Manager.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MOBA_Manager
{
    /// <summary>
    /// Interaction logic for NewsPage.xaml
    /// </summary>
    public partial class NewsPage : Page
    {
        public NewsPage()
        {
            InitializeComponent();
        }

        public void PushNewsPost(NewsPost post)
        {
            NewsListBox.Items.Add(post.Title);
            NewsTitleBox.Text = post.Title;
            NewsTextBlock.Text = post.Content;
        }

        public void PopulatePosts(List<NewsPost> posts)
        {
            foreach(NewsPost post in posts)
            {
                PushNewsPost(post);
            }
        }
    }
}
