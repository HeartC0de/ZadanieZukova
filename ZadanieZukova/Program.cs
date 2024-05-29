

using ZadanieZukova;

List<Interval> Hold_intervals = new List<Interval>();

Hold_intervals.Add(new Interval("12:30", "13:00"));
Hold_intervals.Add(new Interval("15:50", "16:20"));
Hold_intervals.Add(new Interval("17:30", "18:00"));
Hold_intervals.Add(new Interval("18:05", "19:25"));
Hold_intervals.Add(new Interval("19:30", "20:00"));

for (int i = 0; i < Hold_intervals.Count-1; i++)
{
    string[] timeEnd;
    string[] timeStr;
    Interval intervalE = Hold_intervals[i];
    Interval intervalS = Hold_intervals[i+1];
    int End;
    int Start;
    int free = 0;
    timeEnd = intervalE.EndTime.Split(':');
    End = int.Parse(timeEnd[0])*60 + int.Parse(timeEnd[1]);
    timeStr = intervalS.StartTime.Split(':');
    Start = int.Parse(timeStr[0])* 60 + int.Parse(timeStr[1]);
    for (int j = End+30; j < Start; j += 30)
    {
        Console.WriteLine(intervalE.StartTime);
    }

}


List<Interval> Free_intervals = new List<Interval>();
