using System;

namespace FinalProject {
    public class AudioBook : Book {
        private string _cwtitle;
        private string _cwauthor;
        private string _cwgenre;
        private string _cwnarrator;

        // _cwtitle = Item.GetTitle();
        // Item.SetTitle(string cwtitle);
        // _cwgenre = Item.GetGenre();
        // Item.SetGenre(string cwgenre);
        // _cwauthor = Book.GetAuthor();
        // Book.SetAuthor(string cwtitle);

        protected string GetNarrator() {
            return _cwnarrator;
        }

        protected void SetNarrator(string narrator) {
            _cwnarrator = narrator;
        }


        public void SetDetails(string cwtitle, string cwauthor, string cwnarrator, string cwgenre)
        {
            _cwtitle = cwtitle;
            _cwauthor = cwauthor;
            _cwnarrator = cwnarrator;
            _cwgenre = cwgenre;
        }
        public override string GetDetails()
        {
            return $"{_cwtitle} by {_cwauthor}. Narrated by {_cwnarrator}. ({_cwgenre})";
        }
    }
}