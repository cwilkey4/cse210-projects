using System;

namespace FinalProject {
    public class Book : Item {
        private string _cwtitle;
        private string _cwauthor;
        private string _cwgenre;

        // In Item.cs
        // protected string GetTitle() {
        //     return _title;
        // }

        // protected void SetTitle(string title) {
        //     _title = title;
        // }
        // Item.GetTitle
        // Item.SetTitle

        // protected string GetAuthor() {
        //     return _cwauthor;
        // }

        // protected void SetAuthor(string cwauthor) {
        //     _cwauthor = cwauthor;
        // }

        // In Item.cs
        // protected string GetGenre() {
        //     return _genre;
        // }

        // protected void SetGenre(string genre) {
        //     _genre = genre;
        // }

        public void SetDetails(string cwtitle, string cwauthor, string cwgenre)
        {
            _cwtitle = cwtitle;
            _cwauthor = cwauthor;
            _cwgenre = cwgenre;
        }

        public override string GetDetails()
        {
            return $"{_cwtitle} by {_cwauthor}. ({_cwgenre})";
        }
    }
}