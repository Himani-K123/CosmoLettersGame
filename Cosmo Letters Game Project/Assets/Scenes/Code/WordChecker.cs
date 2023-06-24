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
    public static int score = 0;

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

    private HashSet<string> previousWords = new HashSet<string>();

public bool CheckWord(string word, List<char> charList)
{
    bool isMadeOfChars = true;

    // Check if the word is made up of the characters in the charList
    foreach (char c in word)
    {
        if (!charList.Contains(Char.ToUpper(c)))
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

    // Check if the word has been inputted before
    if (IsWordRepeated(word))
    {
        onWordInvalid?.Invoke("Word has been entered before");
        return false; // Word has been entered before
    }

    System.Random random = new System.Random();
    string[] congratulatoryMessages = new string[]
    {
        "Out of this world!",
        "You're a star!",
        "You're the Pluto to my heart",
        "It's rocket science, but you make it look easy!",
        "You're a cosmic force to be reckoned with!",
        "Blast off!",
        "Your work is truly stellar!",
        "It's a small step for man, but a giant leap for your career!",
        "You're a true star-gazer!",
        "You're a star among the constellations! Congratulations!",
        "Your achievements are truly out of this world!",
        "Rocketing towards success! Keep soaring!",
        "Your work is stellar, no pun intended!",
        "You've reached new heights, cosmic congrats!",
        "Launching into celebration mode, blast off!",
        "Your talent shines like a supernova!",
        "A small step for you, a giant leap for success!",
        "Keep stargazing and chasing your dreams!"
    };

    string randomMessage = congratulatoryMessages[random.Next(congratulatoryMessages.Length)];

    // Add the word to the set of previous words
    previousWords.Add(word);
    score++;

    onWordValid?.Invoke(randomMessage); // Invoke the event with the randomly selected message
    return true; // Word is made up of characters from the list, is in the dictionary, and is not a repeated word
}

private bool IsWordRepeated(string word)
{
    return previousWords.Contains(word);
}

}