using System;

namespace FinalProject {
    // Make this an abstract class
    public class Item {
        //
        private string _title;
        private string _genre;


        protected string GetTitle() {
            return _title;
        }

        protected void SetTitle(string title) {
            _title = title;
        }

        protected string GetGenre() {
            return _genre;
        }

        protected void SetGenre(string genre) {
            _genre = genre;
        }

        // Make "Get Details" an abstract method.
        // public abstract string GetDetails();


        // public virtual string GetDetails() {
        //     return $"{_title} {_genre}";
        // }
    }
}