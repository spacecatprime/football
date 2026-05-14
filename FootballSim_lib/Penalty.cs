using System;

namespace FootballSim_lib;

public class Penalty
{
    public string Description { get; init; } = ""; 
    public int PenaltyYards { get; init; } = 0; 
    public bool AutomaticFirstDown { get; init; } = false; 
    public bool LossOfDown { get; init; } = true; 
    public bool DuringPlay { get; init; } = true; 
    public bool Accepted { get; init; } = true; 
}
