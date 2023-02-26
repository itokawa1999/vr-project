using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baibain : MonoBehaviour
{
    [SerializeField]
    GameObject ballObj;

    float timer = 0f;

    // 1秒ごとに処理を実行
    const float INTERVAL = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= INTERVAL)
        {
            GameObject gameObject = Instantiate(ballObj);
            gameObject.transform.parent = this.transform;
            timer = 0f;
        }
    }
}