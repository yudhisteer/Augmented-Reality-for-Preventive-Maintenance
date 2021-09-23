using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PumpCOntroller : MonoBehaviour
{
    public Transform[] transform;
    public Button btn;
    public Vector3[] tempPos;
    public Transform[] EndPoint;
    public bool[] turn;
    public float speed;
    public int Counter;
    public bool isExplode;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        Counter = 0;
        for(int i = 0; i < 10; i++)
        {
            tempPos[i].x = transform[i].position.x;
            tempPos[i].y = transform[i].position.y;
            tempPos[i].z = transform[i].position.z;
        }        
    }

    public void onExplode()
    {
        if (isExplode)
        {
            isExplode = false;
            btn.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Explode";
        }
        else if (!isExplode)
        {
            isExplode = true;
            btn.gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Combine";
        }
        turn[Counter] = true;
    }
    // Update is called once per frame
    void Update()
    {        
        if (turn[Counter])
        {
            if (isExplode)
            {
                transform[Counter].position = Vector3.MoveTowards(transform[Counter].position, EndPoint[Counter].position, speed * Time.deltaTime);
                if (transform[Counter].position == EndPoint[Counter].position)
                {
                    Counter++;
                    if (Counter >= 10)
                    {
                        turn[Counter - 1] = false;
                        for(int i = 0; i < Counter; i++)
                        {
                            transform[i].GetChild((transform[i].childCount) - 1).gameObject.SetActive(true);
                        }
                        Panel.SetActive(true);
                        Counter = 9;
                    }
                    else
                    {
                        turn[Counter] = true;
                        turn[Counter - 1] = false;
                    }
                }
            }
            else if (!isExplode)
            {
                for (int i = 0; i < Counter+1; i++)
                {
                    transform[i].GetChild(transform[i].childCount - 1).gameObject.SetActive(false);
                }
                Panel.SetActive(false);
                transform[Counter].position = Vector3.MoveTowards(transform[Counter].position, tempPos[Counter], speed * Time.deltaTime);
                if (transform[Counter].position == tempPos[Counter])
                {
                    Counter--;
                    if (Counter <= -1)
                    {
                        turn[Counter + 1] = false;
                        Counter = 0;
                    }
                    else
                    {
                        turn[Counter] = true;
                        turn[Counter + 1] = false;
                    }
                }
            }
            
        }        
    }
}
