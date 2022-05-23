using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformScript : MonoBehaviour
{
    public float xMovementSpeed;
    public float posLim;
    public float leftLim;
    public bool toRight;


    public GameObject prefab1;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
       
        if (toRight == true)
        {
            transform.position += new Vector3(xMovementSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xMovementSpeed, 0, 0);
        }

        if (transform.position.x > posLim)

        {
            toRight = false;
            Instantiate(prefab1);
        }
       else if (transform.position.x < leftLim)
        {
            toRight = true;
            Instantiate(prefab2);
        }

    }
}
