using System;

namespace Develop05;

public class Simple : Goal
{
    // private int _goalPoints;
    
    // public void SetPoints(int goalPoints)
    // {
    //     _goalPoints = goalPoints;
    // }
    protected override int AddPoints(int totalPoints, int pointsEarned)
    {
        return totalPoints + pointsEarned;
    }

    protected override int RecordEvent()
    {
        //
    }

}