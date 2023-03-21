using System;

namespace FinalProject {
    public class AudioBook : Book {
        private string _title;
        private string _author;
        private string _genre;
        private string _narrator;

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
    }
}