using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Simulator
{
    public class WeeklySchedule
    {
        public Dictionary<DayOfWeek, List<string>> WeekdaysAndSubjects { get; set; }

        public WeeklySchedule(List<string> subjectsToFitIn)
        {
            WeekdaysAndSubjects = new Dictionary<DayOfWeek, List<string>>();
            for (int i = 0; i < 7; i++)
            {
                WeekdaysAndSubjects.Add( (DayOfWeek)(i), new List<string>() );
            }

            var rnd = new Random();
            var howManySubjects = subjectsToFitIn.Count;
            for (int i = 0; i < howManySubjects; i++)
            {
                WeekdaysAndSubjects[(DayOfWeek)rnd.Next(1, 6)].Add(subjectsToFitIn[0]);
                subjectsToFitIn.RemoveAt(0);
            }
        }

        public override string ToString()
        {
            var temp = new StringBuilder();
            foreach (var weekday in WeekdaysAndSubjects)
            {
                temp.AppendLine(weekday.Key.ToString());
                // if there's no classes that day
                if (weekday.Value.Count == 0)
                {
                    temp.AppendLine("-");
                    continue;
                }
                foreach (var subject in weekday.Value)
                {
                    temp.Append("\t- ");
                    temp.AppendLine(subject);
                }
            }
            return temp.ToString();
        }
    }
}
