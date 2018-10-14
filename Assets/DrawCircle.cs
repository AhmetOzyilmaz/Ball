using UnityEngine;
using System.Collections;

public class DrawCircle : MonoBehaviour
{
    public LineRenderer line;
    [Range(0.1f, 100f)]
    public float radius = 1.0f;

    [Range(3, 256)]
    public int numSegments = 1  ;

    void Start()
    {
        DoRenderer();
    }
    void Update()
    {
        //DoRenderer();
    }

    public void DoRenderer()
    {
        LineRenderer lineRenderer = gameObject.GetComponent<LineRenderer>();
        Color c1 = new Color(0.5f, 0.5f, 0.5f, 1);
        line.SetColors(c1, c1);
        line.SetWidth(0.1f, 0.1f);
        line.SetVertexCount(numSegments + 1);
        line.useWorldSpace = false;

        float deltaTheta = (float)(2.0 * Mathf.PI) / numSegments;
        float theta = 0f;

        for (int i = 0; i < numSegments + 1; i++)
        {
            float x = radius * Mathf.Cos(theta);
            float y = radius * Mathf.Sin(theta);
            Vector3 pos = new Vector3(x, y, 0);
            lineRenderer.SetPosition(i, pos);
            theta += deltaTheta;
        }
    }
}

