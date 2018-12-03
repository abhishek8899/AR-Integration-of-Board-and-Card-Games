using System.Collections;using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

    public Rigidbody rb;
    bool hasLanded;
    bool thrown;
    public Text display1;


    Vector3 initPosition;
    public int diceValue;
    public string dicesign;

    public diceside[] diceSides;
    void Start()
    {
        rb.GetComponent<Rigidbody>();
        initPosition = transform.position;
        rb.useGravity = false;
           
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RollDice();

        }
        if (rb.IsSleeping() && !hasLanded && thrown)
        {
            hasLanded = true;
            rb.useGravity = false;
            SideValueCheck();
        }
//                else if (rb.IsSleeping() && hasLanded )
 //               {
   //                 RollAgain();
     //           }
    }
    public void RollDice()
    {
        display1.text = "";
        if (!thrown && !hasLanded)
        {
            thrown = true;
            rb.useGravity = true;
            rb.AddTorque(Random.Range(0, 1000), Random.Range(0, 1000), Random.Range(0, 1000));
        }
        else if (thrown && hasLanded)
        {
            Reset();
        }
    }
    void Reset()
    {
        transform.position = initPosition;
        thrown = false;
        hasLanded = false;
        rb.useGravity = false;
    }
    void RollAgain()
    {
        Reset();
        thrown = true;
        rb.useGravity = true;
        rb.AddTorque(Random.Range(0, 1000), Random.Range(0, 1000), Random.Range(0, 1000));
    }

    void SideValueCheck()
    {
        diceValue = 0;
        dicesign = "";
        foreach (diceside side in diceSides)
        {
            if(side.OnGround())
            {
                if (side.sideValue <= 0)
                {
                    if (side.sideValue == -1)
                    {
                        dicesign = "-";
                    }
                    else
                    {
                        dicesign = "+";
                    }
                }
                else
                {
                    diceValue = side.sideValue;
                }
                Debug.Log(diceValue + "has been rolled!");
                Debug.Log(dicesign + "has been rolled!");

            }
        }
    }
}
