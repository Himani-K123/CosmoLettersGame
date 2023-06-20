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

    // Check if the word has been inputted before
    if (IsWordRepeated(word))
    {
        onWordInvalid?.Invoke("Word has been entered before");
        return false; // Word has been entered before
    }

    System.Random random = new System.Random();
    string[] congratulatoryMessages = new string[]
    {
        "Out of this world! Congrats on your achievements in space exploration!",
        "You're a star! Your hard work and dedication have truly shone through. Congrats!",
        "You're the Pluto to my heart - always in a special place. Congratulations!",
        "It's rocket science, but you make it look easy! Congrats on your achievements in space.",
        "You're a cosmic force to be reckoned with! Congratulations on your success!",
        "Blast off! You've reached new heights in space exploration. Congrats!",
        "Your work is truly stellar! Congrats on your achievements in space.",
        "You're the astronaut to my mission control - together, we can achieve anything. Congrats!",
        "It's a small step for man, but a giant leap for your career. Congrats on your successes in space exploration!",
        "You're a true star-gazer! Congrats on your achievements in space."
    };

    string randomMessage = congratulatoryMessages[random.Next(congratulatoryMessages.Length)];
    onWordValid?.Invoke(randomMessage); // Invoke the event with the randomly selected message

    // Add the word to the set of previous words
    previousWords.Add(word);
    
    score++;
    return true; // Word is made up of characters from the list, is in the dictionary, and is not a repeated word
}

private bool IsWordRepeated(string word)
{
    return previousWords.Contains(word);
}

}