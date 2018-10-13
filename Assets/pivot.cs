using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivot : MonoBehaviour {
    public float gizmoSize = .75f;
    public Color gizmoColor = Color.yellow;
    
    void OnDrowGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }

}
