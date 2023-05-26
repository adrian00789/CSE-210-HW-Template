using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public ScriptureReference _reference;
    public List<ScriptureWord> _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new ScriptureWord(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<ScriptureWord> visibleWords = _words.Where(word => !word._isHidden).ToList();

        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index]._isHidden = true;
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word._isHidden);
    }

    public override string ToString()
    {
        return $"{_reference}\n{string.Join(" ", _words.Select(word => word._isHidden ? "____" : word._text))}";
    }
}