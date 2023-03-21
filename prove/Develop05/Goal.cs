using System;

namespace Develop05
{
    public class Goal
    {
        private string GoalName = "";
        private string Description = "";
        private int GoalPoints;
        private int TotalPoints;
        private int PointsEarned;
        private bool isCompleted;

        public string StartMessage()
        {
            return $"Your goal is {GoalName} and its description is {Description}";
        }
        protected virtual int AddPoints(int pointsEarned, int goalPoints)
        {
            int totalPoints = pointsEarned + goalPoints;
            return totalPoints;
        }

        protected virtual int RecordEvent(string fileName, string userGoal)
        {
            // We need to retrieve whatever goal the user has accomplished from a number
            string[] lines = System.IO.File.ReadAllLines(fileName);

            foreach (string line in lines)
            {   
                // Don't forget to skip the first line -- that contains the total points!
                string[] parts = line.Split(",");

                string goalType = parts[0];
                string goalName = parts[1];
                string goalDescription = parts[2];
                string points = parts[3];
                // string bonusPoints = parts[4]; (Checklist only!!) 
                
                int goalPoints = int.Parse(points);
            }
            // Then we are going to get the total amount of points from it

            return goalPoints;
        }

        //     if (!isCompleted)
        //     {
        //         if (isCompleted)
        //         {
        //             PointsEarned += GoalPoints;
        //             return GoalPoints;
        //         }
        //         return 0;
        //     }
        //     return 0;
        // }

        protected string IsCompleted(bool isCompleted)
        {
            // We will also remember how many times this goal has been completed, if necessary. 
            // (This will be specified in child classes)
            // +1 (0/10 --> 1/10)
            if (isCompleted == false)
            {
                string complete = "[ ]";
                return complete;
            }
            else
            {
                string complete = "[x]"; 
                return complete;
            }

            // ETERNAL WILL NOT UTILIZE THIS ONE
            // Checklist will. It will not be boolean. It will need to be overriden.
        }

    }
}


















// using System;

// namespace Develop05;

// public class Goal
// {
//     private string _goalName;
//     private string _goalDescription; 
//     protected int _goalPoints;

//     public string GetGoalName()
//     {
//         return _goalName;
//     }

//     public void SetGoalName(string goalName)
//     {
//         _goalName = goalName;
//     }

//     public string GetDescription()
//     {
//         return _goalDescription;
//     }

//     public void SetGoalDescription(string goalDescription)
//     {
//         _goalDescription = goalDescription;
//     }

//     public int GetPoints()
//     {
//         return _goalPoints;
//     }

//     public void SetPoints(int goalPoints)
//     {
//         _goalPoints = goalPoints;
//     }

//     virtual int AddPoints(int totalPoints, int pointsEarned)
//     {
//         return totalPoints + pointsEarned;
//     }
// }