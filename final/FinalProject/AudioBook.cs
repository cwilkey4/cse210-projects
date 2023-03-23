using System;

namespace FinalProject {
    public class AudioBook : Book {
        private string _title;
        private string _author;
        private string _genre;
        private string _narrator;

        // Item.GetTitle();
        // Item.SetTitle();
        // Item.GetGenre();
        // Item.SetGenre();
        // Book.GetAuthor();
        // Book.SetAuthor();

        protected string GetNarrator() {
            return _narrator;
        }

        protected void SetNarrator(string narrator) {
            _narrator = narrator;
        }

        // protected string GetGenre() {
        //     return _genre;
        // }

        // protected void SetGenre(string genre) {
        //     _genre = genre;
        // }

        protected override string GetDetails()
        {
            return $"{_title} by {_author}. Narrated by {_narrator}. ({_genre})";
        }
    }
}