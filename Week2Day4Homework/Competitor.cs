using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Week2Day4Homework
{
    class Competitor
    {

        private int age;
        public void SetAge(int value)
        {
            if (age > 100)
            {
                age = 100;
            }
            else if (age < 1)
            {
                age = 1;
            }
            else
            {
                age = value;
            }
        }
        public int GetAge()
        {
            return age;
        }

        private string firstName;
        public void SetFirstName(string inputFirst)
        {
            for (int i = 0; i < inputFirst.Length; i++)
            {
                if (Char.IsUpper(inputFirst[i]))
                {
                    Char.ToLower(inputFirst[i]);
                }
            }
            Char.ToUpper(inputFirst[0]);
        }
        public string GetFirstName()
        {
            return firstName;
        }

        private string lastName;
        public void SetLastName(string inputLast)
        {
            for (int i = 0; i < inputLast.Length; i++)
            {
                if (Char.IsUpper(inputLast[i]))
                {
                    Char.ToLower(inputLast[i]);
                }
            }
            Char.ToUpper(inputLast[0]);
        }
        public string GetLastName()
        {
            return lastName;
        }

        private string inGameName;
        public void SetInGameName(string ign)
        {
            for (int i = 0; i < ign.Length; i++)
            {
                if (Char.IsUpper(ign[i]))
                {
                    Char.ToLower(ign[i]);
                }
            }
            Char.ToUpper(ign[0]);
        }
        public string GetInGameName()
        {
            return inGameName;
        }
        private int playTime;
        public void SetPlayTime(int hours)
        {
            if (hours < 0)
            {
                hours = 0;
            }
            else
            {
                playTime = hours;
            }
        }
        public int GetPlayTime()
        {
            return playTime;
        }
        public virtual void PlayTimeInHours()
        {
            Console.WriteLine("This is my play time in hours: " + playTime);
        }


    }
    class Coach : Competitor
    {
        private string previousTeams;
        public void SetPreviousTeamName(string teamName)
        {
            for (int i = 0; i < teamName.Length; i++)
            {
                if (Char.IsUpper(teamName[i]))
                {
                    Char.ToLower(teamName[i]);
                }
            }
            Char.ToUpper(teamName[0]);
        }
        public string GetPreviousTeamName()
        {
            return previousTeams;
        }
        public override void PlayTimeInHours()
        {
            Console.WriteLine("This is my play time in hours: " + GetPlayTime());
        }
        string status = "I'm a coach";
    }
    class Player : Competitor
    {
        private string previousPlacements;
        public void SetPreviousPlacement(string placement)
        {
            for (int i = 0; i < placement.Length; i++)
            {
                if (Char.IsUpper(placement[i]))
                {
                    Char.ToLower(placement[i]);
                }
            }
            Char.ToUpper(placement[0]);
        }
        public string GetPreviousPlacement()
        {
            return previousPlacements;
        }

        private string location;
        public void SetLocation(string locationName)
        {
            for (int i = 0; i < locationName.Length; i++)
            {
                if (Char.IsUpper(locationName[i]))
                {
                    Char.ToLower(locationName[i]);
                }
            }
            Char.ToUpper(locationName[0]);
        }
        public string GetPreviousTeamName()
        {
            return location;
        }
        public override void PlayTimeInHours()
        {
            Console.WriteLine("This is my play time in hours: " + GetPlayTime());
        }


        private bool ableToTravel;
        string status = "I'm a player";
    }
}


