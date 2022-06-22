using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinding : MonoBehaviour
{
    public GameObject currentFruit;
    public GameObject targetFruit;

    public Transform[] fruits;

    // Start is called before the first frame update
    void Start()
    {
        

        for (int i = 0; i < fruits.Length; i++)
        {
            float dist =  Vector3.Distance(fruits[i].position,targetFruit.transform.position);
            Debug.Log(fruits[i].name + dist);
            if (Vector3.Distance(fruits[i].position, targetFruit.transform.position) > Vector3.Distance(currentFruit.transform.position, targetFruit.transform.position))
            {
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
