using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Rigidbody Player1;
    int pos1=0;
    int Score1 = 0;
    public Text display1;
    public Text S1;
    public Rigidbody Player2;
    int pos2=0;
    int Score2 = 0;
    public Dice D1;
    public Dice D2;
    public Text S2;
    int turn = 1; //player1 turns
    int userInput;
    float actualAns;
    Dictionary<int, Vector3> ActualPositions;
    Dictionary<int, Vector3> ChangePositions;

    Vector3 v1;
    Vector3 v2;
    
    public void Start()
    {
        ActualPositions = new Dictionary<int, Vector3>();
        ChangePositions = new Dictionary<int, Vector3>();
        display1.text = "GAME START";
        S1.text = "PLAYER1 : 0";
        S2.text = "PLAYER2 : 0";
        Debug.Log(display1);
        Player1.GetComponent<Rigidbody>();
        Player2.GetComponent<Rigidbody>();
        Vector3 temp;

        if (turn == 1)
            temp = Player1.transform.position;

        else
            temp = Player2.transform.position;

        ActualPositions.Add(0, temp);
        v1.Set(1, 0, 0);
        ActualPositions.Add(1, temp + v1);
        v1.Set(2, 0, 0);
        ActualPositions.Add(2, temp + v1);
        v1.Set(3, 0, 0);
        ActualPositions.Add(3, temp + v1);
        v1.Set(4, 0, 0);
        ActualPositions.Add(4, temp + v1);
        v1.Set(5, 0, 0);
        ActualPositions.Add(5, temp + v1);
        v1.Set(6, 0, 0);
        ActualPositions.Add(6, temp + v1);
        v1.Set(7, 0, 0);
        ActualPositions.Add(7, temp + v1);
        v1.Set(8, 0, 0);
        ActualPositions.Add(8, temp + v1);
        v1.Set(9, 0, 0);
        ActualPositions.Add(9, temp + v1);
        v1.Set(9, 0, 1);
        ActualPositions.Add(10, temp + v1);
        v1.Set(8, 0, 1);
        ActualPositions.Add(11, temp + v1);
        v1.Set(7, 0, 1);
        ActualPositions.Add(12, temp + v1);
        v1.Set(6, 0, 1);
        ActualPositions.Add(13, temp + v1);
        v1.Set(5, 0, 1);
        ActualPositions.Add(14, temp + v1);
        v1.Set(4, 0, 1);
        ActualPositions.Add(15, temp + v1);
        v1.Set(3, 0, 1);
        ActualPositions.Add(16, temp + v1);
        v1.Set(2, 0, 1);
        ActualPositions.Add(17, temp + v1);
        v1.Set(1, 0, 1);
        ActualPositions.Add(18, temp + v1);
        v1.Set(0, 0, 1);
        ActualPositions.Add(19, temp + v1);
        v1.Set(0, 0, -1);
        ActualPositions.Add(-1, temp + v1);
        v1.Set(1, 0, -1);
        ActualPositions.Add(-2, temp + v1);
        v1.Set(2, 0, -1);
        ActualPositions.Add(-3, temp + v1);
        v1.Set(3, 0, -1);
        ActualPositions.Add(-4, temp + v1);
        v1.Set(4, 0, -1);
        ActualPositions.Add(-5, temp + v1);
        v1.Set(5, 0, -1);
        ActualPositions.Add(-6, temp + v1);
        v1.Set(6, 0, -1);
        ActualPositions.Add(-7, temp + v1);
        v1.Set(7, 0, -1);
        ActualPositions.Add(-8, temp + v1);
        v1.Set(8, 0, -1);
        ActualPositions.Add(-9, temp + v1);
        v1.Set(9, 0, -1);
        ActualPositions.Add(-10, temp + v1);
        v1.Set(9, 0, -2);
        ActualPositions.Add(-11, temp + v1);
        v1.Set(8, 0, -2);
        ActualPositions.Add(-12, temp + v1);
        v1.Set(7, 0, -2);
        ActualPositions.Add(-13, temp + v1);
        v1.Set(6, 0, -2);
        ActualPositions.Add(-14, temp + v1);
        v1.Set(5, 0, -2);
        ActualPositions.Add(-15, temp + v1);
        v1.Set(4, 0, -2);
        ActualPositions.Add(-16, temp + v1);
        v1.Set(3, 0, -2);
        ActualPositions.Add(-17, temp + v1);
        v1.Set(2, 0, -2);
        ActualPositions.Add(-18, temp + v1);
        v1.Set(1, 0, -2);
        ActualPositions.Add(-19, temp + v1);

        v2.Set(1, 0, 0);
        ChangePositions.Add(16, temp + v2);
        v2.Set(4, 0, 0);
        ChangePositions.Add(13, temp + v2);
        v2.Set(6, 0, -2);
        ChangePositions.Add(-10, temp + v2);
        v2.Set(1, 0, -2);
        ChangePositions.Add(-4, temp + v2);
        v2.Set(3, 0, 0);
        ChangePositions.Add(-15, temp + v2);
    }
    public void UserInput(GameObject B1)
    {
        if (D1.diceValue == 0 || D2.dicesign == "")
            return;

        Debug.Log("Got it");
        if (turn == 1)
        {
            if(D2.dicesign == "+")
            actualAns = pos1 + D1.diceValue;
            else
            actualAns = pos1 - D1.diceValue;
        }
        else
        {
            if (D2.dicesign == "+")
                actualAns = pos2 + D1.diceValue;
            else
                actualAns = pos2 - D1.diceValue;
        }
        D1.diceValue = 0;
        D2.dicesign = "";
        int.TryParse(B1.name, out userInput);
        Debug.Log(userInput + " buttonclick vs act " + actualAns);
        if (actualAns == userInput)
        {
            if (turn == 1)
            {
                Debug.Log("CORRECT ANS!!" + Score1);
                Score1 += 5;
                display1.text = "CORRECT";
                Debug.Log(Score1);
                S1.text = "PLAYER1 : " + Score1.ToString();


                Player1.MovePosition(ActualPositions[userInput]);
                pos1 = userInput;
                if (userInput == 19)
                {
                    Debug.Log("PLAYER1 WON" + Score1);
                    display1.text = "PLAYER1 WON";
                    Player1.MovePosition(ActualPositions[0]);
                    Player2.MovePosition(ActualPositions[0]);
                }
                turn = 2;
                Player1.MovePosition(ChangePositions[userInput]);
                if (userInput == -15)
                {
                    pos1 = 3;
                    Debug.Log("Got a Ladder at " + userInput);
                    Score1 += 10;
                    S1.text = "PLAYER1 : " + Score1.ToString();

                    //                   turn = 1;
                }

                Player1.MovePosition(ChangePositions[userInput]);
                if (userInput == 13)
                {
                    pos1 = 4;
                    Debug.Log(" Bit by a Snake at " + userInput);
                    Score1 -= 2;
                    S1.text = "PLAYER1 : " + Score1.ToString();

                }
                if (userInput == 16)
                {
                    Debug.Log("Bit by a Snake at " + userInput);
                    pos1 = 1;
                    Score1 -= 2;
                    S1.text = "PLAYER1 : " + Score1.ToString();

                }
                if (userInput == -10)
                {
                    Debug.Log("Bit by a Snake at " + userInput);
                    pos1 = -14;
                    Score1 -= 2;
                    S1.text = "PLAYER1 : " + Score1.ToString();

                }
                if (userInput == -4)
                {
                    Debug.Log("Bit by a Snake at " + userInput);
                    pos1 = -19;
                    Score1 -= 2;
                    S1.text = "PLAYER1 : " + Score1.ToString();

                }
                //  S1.text = "PLAYER : 1 " + Score1.ToString();
            }

            else
            {
                Debug.Log("CORRECT ANS!!" + Score2);
                display1.text = "CORRECT";
                Score2 += 5;
                S2.text = "PLAYER2 : " + Score2.ToString();
                Player2.MovePosition(ActualPositions[userInput]);
                pos2 = userInput;
                turn = 1;
                if (userInput == 19)
                {
                    Debug.Log("PLAYER2 WON" + Score2);
                    display1.text = "PLAYER2 WON";
                    Player1.MovePosition(ActualPositions[0]);
                    Player2.MovePosition(ActualPositions[0]);
                }

                Player2.MovePosition(ChangePositions[userInput]);
                if (userInput == -15)
                {
                    pos2 = 3;
                    Debug.Log("Got a Ladder at " + userInput);
                    Score2 += 10;
                    S2.text = "PLAYER2 : " + Score2.ToString();
                    //turn = 2;
                }

                Player2.MovePosition(ChangePositions[userInput]);
                if (userInput == 13)
                {
                    pos2 = 4;
                    Debug.Log(" Bit by a Snake at " + userInput);
                    Score2 -= 2;
                    S2.text = "PLAYER2 : " + Score2.ToString();
                }
                if (userInput == 16)
                {
                    Debug.Log("Bit by a Snake at " + userInput);
                    pos2 = 1;
                    Score2 -= 2;
                    S2.text = "PLAYER2 : " + Score2.ToString();
                }
                if (userInput == -10)
                {
                    Debug.Log("Bit by a Snake at " + userInput);
                    pos2 = -14;
                    Score2 -= 2;
                    S2.text = "PLAYER2 : " + Score2.ToString();
                }
                if (userInput == -4)
                {
                    Debug.Log("Bit by a Snake at " + userInput);
                    pos2 = -19;
                    Score2 -= 2;
                    S2.text = "PLAYER2 : " + Score2.ToString();
                }
                S2.text = "PLAYER2 : " + Score2.ToString();

            }
            //make the gameobjet display1ing the result activate
        }

        else
        {
            Debug.Log("WRONG ANS!!" + Score1);
            display1.text = "WRONG";
            if (turn == 1)
            {
                Debug.Log("Change Player!!");
                turn = 2;
            }
            if (turn == 2)
            {
                Debug.Log("Change Player!!");
                turn = 1;
            }
            //make the gameobject display1ing the result activate
            Debug.Log("TURN Player" + turn);
        }
    }
    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }

}
