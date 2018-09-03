using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.src
{
    public class NewsPost
    {
        private String _title;
        private String _content;

        public NewsPost()
        {
        }

        public NewsPost(String title, String content)
        {
            this._title = title;
            this._content = content;
        }

        public string Content { get => _content; set => _content = value; }
        public string Title { get => _title; set => _title = value; }
    }
}
