using System;

public class Reference
{
    private string _wipbook;
    private string _wipchapter;
    private string _wipverse;
    private string _wipendVerse;

    public Reference(string wipbook, string wipchapter, string wipverse)
    {
        _wipbook = wipbook;
        _wipchapter = wipchapter;
        _wipverse = wipverse;
    }
    public Reference(string wipbook, string wipchapter, string wipverse, string wipendVerse)
    {
        _wipbook = wipbook;
        _wipchapter = wipchapter;
        _wipverse = wipverse;
        _wipendVerse = wipendVerse; 
    }




    public string GetReference()
    {
        return _wipbook, _wipchapter, _wipverse, _wipendVerse;
    }

    public string SetReference()
    {

    }

    // public Reference()
    // {
    //     _wipbook = "2 Nephi";
    //     _wipchapter = 2;
    //     _wipverse = 24;
    //     _wipendVerse = 25;
    // }

    // public string getBook() 
    // {
    //     return _wipbook;
    // }

    // public int getChapter()
    // {
    //     return _wipchapter;
    // }

    // public int getVerse()
    // {
    //     return _wipverse;
    // }

    // public int getEndVerse()
    // {
    //     return _wipendVerse;
    // }
}



// Getter Setter example:
// public class Person
// {
//     private string name;

//     public string Name
//     {
//         get
//         {
//             return name;
//         }
//         set
//         {
//             name = value;
//         }
//     }
// }

