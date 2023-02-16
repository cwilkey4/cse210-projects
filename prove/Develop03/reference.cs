using System;

public class Reference
{
    private string _wipbook;
    private int _wipchapter;
    private int _wipverse;
    private int _wipendVerse;

    public Reference()
    {
        _wipbook = "2 Nephi";
        _wipchapter = 2;
        _wipverse = 24;
        _wipendVerse = 25;
    }

    public string getBook() 
    {
        return _wipbook;
    }

    public int getChapter()
    {
        return _wipchapter;
    }

    public int getVerse()
    {
        return _wipverse;
    }

    public int getEndVerse()
    {
        return _wipendVerse;
    }
}

