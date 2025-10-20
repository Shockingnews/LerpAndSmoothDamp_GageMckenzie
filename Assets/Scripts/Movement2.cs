using UnityEngine;

public class Movement2 : MonoBehaviour
{
    
    static float timer = 0;
    public float duration = 9;
    public Vector3 v = new Vector3(0, 0, 9);
    public float smooth = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 startPos = new Vector3(0, 3, 0);
        Vector3 targetPos = transform.position + new Vector3(10, 0, 0);
        timer += Time.deltaTime;
        transform.position = Vector3.SmoothDamp(startPos, targetPos, ref v, smooth, 10, timer / duration);
        if (timer > duration)
        {
            timer = 0;
            
        }
    }
}
