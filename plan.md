Write a basic American football simulation system in C#.

Data Structures: Game, Drive, Half, Play, Team, Pass, Run, Penalty, Touchdown, First Down, Field Goal, Safety, Game Manager

Play Entity: The core unit of game progression. Each record includes:
 - Context: Down, distance, yard line, and game clock.
 - Result: Yards gained, play type (Run/Pass/Penalty), and the outcome (Touchdown, First Down).

```
Pseudo code

class Team
 - name

class Stadium
 - name
 - location
 - DateTime, kick off time

enum PlayType { Run, Pass, Punt, FieldGoal, Kickoff, Kneel, OnsideKick }

enum PlayOutcome { PassComplete, PassIncomplete, Touchdown, Interception, Fumble, MadeFieldGoal, MissedFieldGoal, Sacked, Safety, Penalty }

class PlayPenalty
 - description
 - penalty yards
 - bool, automatic first down
 - bool, loss of down
 - bool, during play

class PlayResult
 - int, Yards Gained
 - PlayOutcome
 - bool, is first down
 - bool, is a score
 - PlayPenalty
 - TimeSpan, time taken
 - bool, stopped clock
 - ??? turn over?

class Play
 - Quarter
 - Down
 - int, yards to first down
 - Team, possession team
 - Play Type
 - string, play name

class Drive
 - int, start yards to goal
 - Play[], play list
 - TimeSpan, time taken () 

class Quarter
 - int, period

class Game
 - Team, home team
 - Team, away team
 - Drive[], drive list

```

```
using System;

public class Play
{
    // --- Contextual Data (Pre-snap) ---
    public int Quarter { get; set; }
    public TimeSpan GameClock { get; set; } // Time remaining in the quarter
    public int Down { get; set; }           // 1, 2, 3, or 4
    public int YardsToFirstDown { get; set; }       // Yards to go for a first down
    public string YardLine { get; set; }    // e.g., "OWN 25" or "OPP 10"
    public int PossessionTeamId { get; set; }

    // --- Play Execution Data ---
    public PlayType Type { get; set; }
    public string PlayCall { get; set; }    // The name of the play from the playbook
    
    // --- Result Data (Post-play) ---
    public int YardsGained { get; set; }
    public PlayOutcome Outcome { get; set; }
    public bool IsFirstDown { get; set; }
    public bool IsScoringPlay { get; set; }
    public string PenaltyDetail { get; set; } // Null if no penalty occurred

    // Basic constructor
    public Play(int down, int distance, string yardLine, PlayType type)
    {
        Down = down;
        Distance = distance;
        YardLine = yardLine;
        Type = type;
    }

    // Helper to summarize the play for logs
    public override string string() 
    {
        string gainType = YardsGained >= 0 ? "gain" : "loss";
        return $"{Down} & {Distance}: {Type} for a {Math.Abs(YardsGained)} yard {gainType}. Outcome: {Outcome}";
    }
}

// Supporting Enums for Type-Safety
public enum PlayType { Run, Pass, Punt, FieldGoal, Kickoff, Penalty, Sack, Kneel }
public enum PlayOutcome { Complete, Incomplete, Touchdown, Interception, Fumble, MadeFG, MissedFG, Sacked }

```

