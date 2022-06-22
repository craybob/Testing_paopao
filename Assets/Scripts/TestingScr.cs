using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScr : MonoBehaviour
{
    LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

        const int POINTS_COUNT = 4;
        Vector3[] pointsArray = new Vector3[POINTS_COUNT];
        lineRenderer.positionCount = POINTS_COUNT;
        for (int i = 0; i < POINTS_COUNT; i++)
        {
            float curSegment = Mathf.Deg2Rad * (i * 90f / POINTS_COUNT);
            pointsArray[i] = new Vector3(Mathf.Sin(90f) * 10, 0, Mathf.Cos(90f) * 10);
        }

        lineRenderer.SetPositions(pointsArray);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 currentPoint = GetWorldCoodinate(Input.mousePosition);
        }
    }

    private Vector2 GetWorldCoodinate(Vector3 mousePos)
    {
        Vector2 mousePoint = new Vector3(mousePos.x ,mousePos.y,1);
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}