using System;
using System.Collections.Generic;
using UnityEngine;

public class LearningModeWordChecker : MonoBehaviour
{
    public TextAsset ScrabbleWordDefinitionList;
    private Dictionary<string, string> wordDefinitions = new Dictionary<string, string>();

    private void Start()
    {
        LoadWordDefinitions();
    }

    private void LoadWordDefinitions()
    {
        string[] lines = ScrabbleWordDefinitionList.text.Split('\n');

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split('\t');
            if (parts.Length >= 2)
            {
                string word = parts[0].Trim();
                string definitionWithType = parts[1].Trim();

                int startIndex = definitionWithType.IndexOf('[');
                int endIndex = definitionWithType.LastIndexOf(']');
                if (startIndex >= 0 && endIndex >= 0)
                {
                    string definition = definitionWithType.Substring(0, startIndex).Trim();
                    string typeOfSpeech = definitionWithType.Substring(startIndex + 1, endIndex - startIndex - 1).Trim();
                    wordDefinitions[word] = definition + " [" + typeOfSpeech + "]";
                }
            }
        }
    }

    public string CheckWord(string word)
    {
        string formattedWord = word.ToUpper();
        if (wordDefinitions.ContainsKey(formattedWord))
        {
            return formattedWord + ": " + wordDefinitions[formattedWord];
        }
        else
        {
            return "Invalid word: " + word;
        }
    }
}
