using System;
using System.Collections.Generic;
using System.Text;

class Seat
{
    private readonly int _id;

    private string _name;

    private static int count = 0;
    private static int now = 0;

    private static int _nextId = 1;

    public Seat(string name)
    {
        _id = _nextId++;
        _name = name;
        count++;
        now++;

        Console.WriteLine($"좌석 {_id}번 착석: {_name}");
    }

    ~Seat()
    {
        now--;
        Console.WriteLine($"좌석 {_id}번 반납: {_name}");
    }

    public void Study()
    {
        Console.WriteLine($"{_name}이(가) 좌석 {_id}번에서 공부 중...");
    }
    public static void ShowStatus()
    {
        Console.WriteLine($"총 이용: {count}명, 현재 착석: {now}명");
    }

}

