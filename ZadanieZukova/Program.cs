

using ZadanieZukova;

List<Interval> Hold_intervals = new List<Interval>();

Hold_intervals.Add(new Interval("12:30", "13:00"));
Hold_intervals.Add(new Interval("15:50", "16:20"));
Hold_intervals.Add(new Interval("17:30", "18:00"));
Hold_intervals.Add(new Interval("18:05", "19:25"));
Hold_intervals.Add(new Interval("19:30", "20:00"));
Hold_intervals.Add(new Interval("23:30", "24:00"));
Hold_intervals.Add(new Interval("0:00", "12:30"));

List<Interval> Free_intervals = new List<Interval>();

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
        Free_intervals.Add(new Interval((End / 60).ToString() + ":" + (End % 60).ToString(), (j/ 60).ToString() + ":" + (j % 60).ToString()));
    }

}

foreach (Interval interval in Free_intervals)
{
    Console.WriteLine(interval.StartTime + " "  + interval.EndTime);
}

