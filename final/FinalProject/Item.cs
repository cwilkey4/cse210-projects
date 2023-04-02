using System;

namespace FinalProject {
    public abstract class Item {
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
        public abstract string GetDetails();
    }
}