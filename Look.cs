using UnityEngine;
using UnityEngine.UI;

public class script_limpadorTudo : MonoBehaviour
{
    Vector2 posTarget; //posTarget can be any position you want.
    
    void Update()
    {
        Vector2 _dir = posTarget - transform.position;
        float angle = Mathf.Atan2(_dir.y, _dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
