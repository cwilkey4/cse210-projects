using System;

namespace FinalProject {
    public class Movie : Item {
        private string _cwtitle;
        private string _cwdirector;
        private string _cwstudio;
        private string _cwrating;
        private string _cwgenre;


        public void SetDetails(string cwtitle, string cwdirector, string cwstudio, string cwrating, string cwgenre)
        {
            _cwtitle = cwtitle;
            _cwdirector = cwdirector;
            _cwstudio = cwstudio;
            _cwrating = cwrating;
            _cwgenre = cwgenre;
        }
        public override string GetDetails()
        {
            return $"{_cwtitle} by {_cwdirector} ({_cwstudio}). {_cwrating} {_cwgenre}";
        }

    }
}