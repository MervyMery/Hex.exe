using UnityEngine;

public class Parab : MonoBehaviour
{
    public float sped,a, b;
    public void Update()
        {
        float t = Time.time* sped;
        float x = t + a;
        float y = Mathf.Pow(t +6,2)+b ;
        transform.position= new Vector3(x,y,0);
    }
}
