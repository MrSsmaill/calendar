﻿Console.Write("Введите число ");
int DD = int.Parse(Console.ReadLine());
Console.Write("Введите месяц ");
int MM = int.Parse(Console.ReadLine());
Console.Write("Введите год ");
int GG = int.Parse(Console.ReadLine());

int day = 0;
int d = 0;

if (DD < 0 || MM < 0 || GG < 0) Console.Write("Вы ввели не правильную дату");

int Day(int i)
{
    if (i == 365)
    {if (MM == 1) day = DD;
    else if (MM == 2) day = DD+31;
    else if (MM == 3) day = DD+59;
    else if (MM == 4) day = DD+90;
    else if (MM == 5) day = DD+120;
    else if (MM == 6) day = DD+151;
    else if (MM == 7) day = DD+181;
    else if (MM == 8) day = DD+212;
    else if (MM == 9) day = DD+243;
    else if (MM == 10) day = DD+273;
    else if (MM == 11) day = DD+304;
    else if (MM == 12) day = DD+334;
    }
    else
    {
    if (MM == 1) day = DD;
    else if (MM == 2) day = DD+31;
    else if (MM == 3) day = DD+60;
    else if (MM == 4) day = DD+91;
    else if (MM == 5) day = DD+121;
    else if (MM == 6) day = DD+152;
    else if (MM == 7) day = DD+182;
    else if (MM == 8) day = DD+213;
    else if (MM == 9) day = DD+244;
    else if (MM == 10) day = DD+274;
    else if (MM == 11) day = DD+305;
    else if (MM == 12) day = DD+335;
    }
    return day;
}

int[] Week = {4,6,0,1,2,4,5,6,0,2,3,4,5,0,1,2,3,5,6,0,1,3,4,5,6,1,2,3};

int g1 = GG%100;  //год в десятках
int g2 = GG%28;   // недели каждые 28лет
int g3 = GG%4;    //проверка на високосный
int g4 = GG%400;  //каждый 400 год високосный

 if ( g1 == 0 & g4 != 0) d = 365;
else
{
    if ( g4 == 0 || g3 == 0) d = 366;
    else d = 365;
}
        
 day = Day(d);

int week = day%7;

week = week + Week[g2];

if (GG <= 1900) week++;

if (week == 1 || week == 8 ) Console.WriteLine("Понедельник");
else if (week == 2 || week == 9 ) Console.WriteLine("Вторник");
else if (week == 3 || week == 10 ) Console.WriteLine("Среда");
else if (week == 4 || week == 11 ) Console.WriteLine("Четверг");
else if (week == 5 || week == 12 ) Console.WriteLine("Пятница");
else if (week == 6 || week == 13 ) Console.WriteLine("Суббота");
else if (week == 7 || week == 14 ) Console.WriteLine("Воскресенье");
