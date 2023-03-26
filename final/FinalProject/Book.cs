using System;

namespace FinalProject {
    public class Book : Item {
        private string _title;
        private string _author;
        private string _genre;

        // In Item.cs
        // protected string GetTitle() {
        //     return _title;
        // }

        // protected void SetTitle(string title) {
        //     _title = title;
        // }
        // Item.GetTitle
        // Item.SetTitle

        protected string GetAuthor() {
            return _author;
        }

        protected void SetAuthor(string author) {
            _author = author;
        }

        // In Item.cs
        // protected string GetGenre() {
        //     return _genre;
        // }

        // protected void SetGenre(string genre) {
        //     _genre = genre;
        // }

        // protected override string GetDetails()
        // {
        //     return $"{_title} by {_author}. ({_genre})";
        // }

    }
}