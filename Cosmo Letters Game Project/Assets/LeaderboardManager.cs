using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LeaderboardManager : MonoBehaviour
{
    private List<LeaderboardEntry> leaderboard; // List to store leaderboard entries
    public TMP_Text easyText, mediumText, hardText;

    // Start is called before the first frame update
    void Start()
    {
        leaderboard = new List<LeaderboardEntry>(); // Initialize the leaderboard list
        GameManage gameManage = GameManage.Instance;

        // Example usage
        string name = gameManage.UserName;
        int score = gameManage.Score;
        string difficultyLevel = gameManage.LOD;

        LeaderboardEntry entry = new LeaderboardEntry(name, score, difficultyLevel);
        leaderboard.Add(entry); // Add the entry to the leaderboard list

        // Print leaderboard entries
        foreach (LeaderboardEntry leaderboardEntry in leaderboard)
        {
            Debug.Log(leaderboardEntry.ToString());
        }
    }

    // Updates the UI
    void LateUpdate()
    {
        var easyEntry = "";
        var mediumEntry = "";
        var hardEntry = "";

        for (int i = 0; i < leaderboard.Count; i++)
        {
            if (leaderboard[i].DifficultyLevel == "Easy")
            {
                easyEntry += $"{i + 1}. {leaderboard[i].Name} - {leaderboard[i].Score}";
                easyText.text = easyEntry;
            }
            if (leaderboard[i].DifficultyLevel == "Medium")
            {
                mediumEntry += $"{i + 1}. {leaderboard[i].Name} - {leaderboard[i].Score}";
                mediumText.text = mediumEntry;
            }
            if (leaderboard[i].DifficultyLevel == "Hard")
            {
                hardEntry += $"{i + 1}. {leaderboard[i].Name} - {leaderboard[i].Score}";
                hardText.text = hardEntry;
            }
        }
    }
}

public class LeaderboardEntry
{
    public string Name { get; private set; }
    public int Score { get; private set; }
    public string DifficultyLevel { get; private set; }

    public LeaderboardEntry(string name, int score, string difficultyLevel)
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
