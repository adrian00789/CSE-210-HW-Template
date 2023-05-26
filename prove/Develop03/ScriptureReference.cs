using System;
using System.Collections.Generic;
using System.Linq;
class ScriptureReference
{
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int? _endVerse;

    public ScriptureReference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = null;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}" : $"{_book} {_chapter}:{_startVerse}";
    }
}