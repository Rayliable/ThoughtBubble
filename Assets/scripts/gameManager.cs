using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//
// @kurtdekker
//
// ULTRA-simple fully-static GameManager for simple arcade-style games.
//
// NOTE: you DO NOT place this file into any scene! It is a pure static data container.
//
// Usage:
//	- at start of game call GM.InitGame()
//	- when you earn points, call GM.AddPoints(1234);
//	- when you want to display score, get it from GM.Score (see GMShowScore.cs below)
//	- when you want to display lives, get it from GM.Lives
//
// To persistently store high scores, see https://pastebin.com/VmngEK05
//

public class gameManager
{
    public static int dreamNum = -1;
    public static int strikes = 0;
    // TODO: go nuts if you want to add more stuff like health and wave and coins, etc.!

    // i dont know if these functions need to be static so i removed that - Z
    public static void InitGame()
    {
        dreamNum = -1;
        strikes = 0;
    }

}