using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Private reference and words
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    // Build scripture from a Reference and plain verse text
    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;

        // Split by spaces to create Word objects (very beginner simple)
        foreach (string token in verseText.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(token));
        }
    }

    // Join reference + current words display
    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}  —  {wordsText}";
    }

    // Hide N random *visible* words (skip already hidden)
    public void HideRandomWords(int count)
    {
        // Take all not-hidden indices
        List<int> open = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                open.Add(i);
        }

        // If nothing to hide, stop
        if (open.Count == 0) return;

        // Hide up to 'count' different positions
        int toHide = Math.Min(count, open.Count);
        for (int n = 0; n < toHide; n++)
        {
            // Pick a random index from remaining
            int pick = _random.Next(open.Count);
            int wordIndex = open[pick];
            _words[wordIndex].Hide();

            // Remove from the pool so we don't pick it again
            open.RemoveAt(pick);
        }
    }

    // True when every word is hidden
    public bool IsCompletelyHidden()
    {
        // Stop when all words are hidden
        return _words.All(w => w.IsHidden());
    }
}
