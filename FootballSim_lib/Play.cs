using System;

namespace FootballSim_lib;

/*
enum PlayType { Run, Pass, Punt, FieldGoal, Kickoff, Kneel, OnsideKick }

enum PlayOutcome { PassComplete, PassIncomplete, Touchdown, Interception, Fumble, MadeFieldGoal, MissedFieldGoal, Sacked, Safety, Penalty }

class PlayPenalty
 - description
 - penalty yards
 - bool, automatic first down
 - bool, loss of down
 - bool, during play
 - bool, accepted

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
*/
public class Play
{
    public enum Type
    {
       Run, 
       Pass, 
       Punt, 
       FieldGoal, 
       Kickoff, 
       Kneel, 
       OnsideKick 
    }

    enum PlayOutcome
    { 
        PassComplete, 
        PassIncomplete,
        Touchdown, 
        Interception, 
        Fumble, 
        MadeFieldGoal, 
        MissedFieldGoal, 
        Sacked, 
        Safety, 
        Penalty 
    }
}
