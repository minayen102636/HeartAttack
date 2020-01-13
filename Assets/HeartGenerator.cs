using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour
{
	public GameObject Heart;
    public GameObject Bad;
    public GameObject Heart2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreatHeart",1,1);
        InvokeRepeating("CreatBad",1,1);
        InvokeRepeating("CreatHeart2",1,1);
    }

    public void CreatHeart(){
    	int HeartNum;
    	HeartNum = Random.Range(0,5);

    	for (int i = 0; i < HeartNum; i++){
    		float x;
    		float y;
    		x = Random.Range(-6, 6);
    		y = Random.Range(-1, 1.5f);
    		Instantiate(Heart, new Vector3(x, y, 0), Quaternion.identity );
    	}
    }

    public void CreatBad(){
        float BadNum;
        BadNum = Random.Range(0,2);

        for (int i = 0; i < BadNum; i++){
            float x;
            float y;
            x = Random.Range(-6, 6);
            y = Random.Range(-1, 1.5f);
            Instantiate(Bad, new Vector3(x, y, 0), Quaternion.identity );
        }
    }

    public void CreatHeart2(){
        int HeartNum2;
        HeartNum2 = Random.Range(0,3);

        for (int i = 0; i < HeartNum2; i++){
            float x;
            float y;
            x = Random.Range(-6, 6);
            y = Random.Range(-1, 1.5f);
            Instantiate(Heart2, new Vector3(x, y, 0), Quaternion.identity );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
