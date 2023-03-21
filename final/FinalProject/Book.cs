using System;

namespace FinalProject {
    public class Book : Item {
        private string _title;
        private string _author;
        private string _genre;

        protected string GetAuthor() {
            return _author;
        }

        protected void SetAuthor(string author) {
            _author = author;
        }

        // protected string GetGenre() {
        //     return _genre;
        // }

        // protected void SetGenre(string genre) {
        //     _genre = genre;
        // }
    }
}