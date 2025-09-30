using System;

public class Word
{
    // Private state: the text and whether it is hidden
    private string _text;
    private bool _isHidden = false;

    // Constructor: set the original word text
    public Word(string text)
    {
        _text = text;
    }

    // Hide this word
    public void Hide()
    {
        _isHidden = true;
    }

    // Tell if this word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Display the word or underscores with the same length
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // keep punctuation if the word ends with it (very simple handling)
            char last = _text[_text.Length - 1];
            bool endsWithPunct = char.IsPunctuation(last);
            int letters = endsWithPunct ? _text.Length - 1 : _text.Length;

            string underscores = new string('_', Math.Max(1, letters));
            return endsWithPunct ? underscores + last : underscores;
        }
        return _text;
    }
}
