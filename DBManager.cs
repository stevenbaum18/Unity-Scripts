using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DBManager
{
    public static string username;
    public static int score;
    public static int level;
    public static int timePlayed;
    public static int levelOneScore;
    public static int levelTwoScore;
    public static int levelThreeScore;
    public static bool LoggedIn
    {
        get { return username != null; }
    }
    public static void LogOut()
    {
        username = null;
    }
}
