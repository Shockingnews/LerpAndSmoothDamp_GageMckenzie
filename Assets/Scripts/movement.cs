using UnityEngine;
using UnityEngine.UIElements;

public class movement : MonoBehaviour
{
    Vector3 startPosition;
    static float timer = 0;
    public float duration = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.position = Vector3.Lerp(startPosition, startPosition + Vector3.right * 10, timer / duration);
        if (timer > duration)
        {
            timer = 0;
        }
        
    }
}
