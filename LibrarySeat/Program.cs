using System;

// README.md를 읽고 코드를 작성하세요.

Seat s1 = new Seat("김민수");
Seat s2 = new Seat("이지영");
Seat s3 = new Seat("박서준");

s1.Study();
s2.Study();
s3.Study();

Seat.ShowStatus();

s1 = null;
s2 = null;
s3 = null;

GC.Collect();
GC.WaitForPendingFinalizers();

Seat.ShowStatus();