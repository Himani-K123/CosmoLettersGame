using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderboardManager : MonoBehaviour
{
    private List<LeaderboardEntry> leaderboard; // List to store leaderboard entries

    // Start is called before the first frame update
    void Start()
    {
        leaderboard = new List<LeaderboardEntry>(); // Initialize the leaderboard list

        // Example usage
        string name = "John";
        int score = 100;
        int difficultyLevel = 2;

        LeaderboardEntry entry = new LeaderboardEntry(name, score, difficultyLevel);
        leaderboard.Add(entry); // Add the entry to the leaderboard list

        // Print leaderboard entries
        foreach (LeaderboardEntry leaderboardEntry in leaderboard)
        {
            Debug.Log(leaderboardEntry.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class LeaderboardEntry
{
    public string Name { get; private set; }
    public int Score { get; private set; }
    public int DifficultyLevel { get; private set; }

    public LeaderboardEntry(string name, int score, int difficultyLevel)
    {
        Name = name;
        Score = score;
        DifficultyLevel = difficultyLevel;
    }

    public override string ToString()
    {
        return $"{Name}, Score: {Score}, Level: {DifficultyLevel}";
    }
}
