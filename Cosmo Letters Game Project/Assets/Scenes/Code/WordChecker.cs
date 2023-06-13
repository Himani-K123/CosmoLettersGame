using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WordChecker : MonoBehaviour
{
    public TextAsset ScrabbleWordList;
    public Action<string> onWordValid; // Event or delegate to handle valid word
    public Action<string> onWordInvalid; // Event or delegate to handle invalid word
    public Action<string> onCharacterInvalid; // Event or delegate to handle invalid character

    private HashSet<string> scrabbleDictionary;

    private void Awake()
    {
        LoadScrabbleDictionary();
    }

    private void LoadScrabbleDictionary()
    {
        string[] words = ScrabbleWordList.text.Split('\n');
        scrabbleDictionary = new HashSet<string>(words.Select(word => word.Trim()));
    }

    public bool CheckWord(string word, char[] charList)
    {
        bool isMadeOfChars = true;

        // Check if the word is made up of the characters in the charList
        foreach (char c in word)
        {
            if (!charList.Contains(c))
            {
                isMadeOfChars = false;
                break;
            }
        }

        if (!isMadeOfChars)
        {
            onCharacterInvalid?.Invoke("Character not found in the list");
            return false; // Character not found in the list
        }

        // Check if the word is in the Scrabble dictionary
        if (!scrabbleDictionary.Contains(word.ToUpper()))
        {
            onWordInvalid?.Invoke("Word not found in the Scrabble dictionary");
            return false; // Word not found in the Scrabble dictionary
        }

        onWordValid?.Invoke("Word is valid!"); // Invoke the event for a valid word
        return true; // Word is made up of characters from the list and is in the dictionary
    }
}