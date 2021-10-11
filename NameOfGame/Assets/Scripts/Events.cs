/// <summary>
/// Events for EventManager
/// </summary>

/*
    // Example Event
    public class ExampleEvent : TEventBase
    {
        public GameObject ExamplePayload { get; set; }
        public int ExampleValue { get; set; }
        public ExampleEvent(GameObject examplePayload, int value)
        {
            ExamplePayload = examplePayload;
            ExampleValue = value;
        }
    }

    // Managing the Listener
    EventManager.AddListener<TopScoreRecievedEvent>(OnTopScoreRecievedEventHandler);
    EventManager.RemoveListener<TopScoreRecievedEvent>();

*/

using System.Collections.Generic;
using UnityEngine;

public class ScoreChangedEvent : TEventBase
{
    public int Score { get; set; }

    public ScoreChangedEvent(int score)
    {
        Score = score;
    }
}

public class RankRecievedEvent : TEventBase
{
    public int Rank { get; set; }

    public RankRecievedEvent(int rank)
    {
        Rank = rank;
    }
}

public class TopScoreRecievedEvent : TEventBase
{
    public List<ScoreRecord> TopScores { get; set; }

    public TopScoreRecievedEvent(List<ScoreRecord> topScores)
    {
        TopScores = topScores;
    }
}

public class PlayerNameChangedEvent : TEventBase
{
    public string PlayerName { get; set; }

    public PlayerNameChangedEvent(string playerName)
    {
        PlayerName = playerName;
    }
}

public class CustomerEvent : TEventBase
{
    public bool IsHappy { get; set; }

    public CustomerEvent(bool isHappy)
    {
        IsHappy = isHappy;
    }
}

public class NewOrderEvent : TEventBase 
{ 
}

public class LaunchedIngredientEvent : TEventBase
{
    public Transform Ingredient{ get; set; }

    public LaunchedIngredientEvent(Transform xform)
    {
        Ingredient = xform;
    }
}
public class IngredientUpgradedEvent : TEventBase
{
    public Transform Ingredient { get; set; }

    public IngredientUpgradedEvent(Transform xform)
    {
        Ingredient = xform;
    }
}

public class IngredientDeletedEvent : TEventBase
{
    public Transform Ingredient { get; set; }

    public IngredientDeletedEvent(Transform xform)
    {
        Ingredient = xform;
    }
}

