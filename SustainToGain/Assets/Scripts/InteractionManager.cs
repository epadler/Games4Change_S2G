using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public GameObject crop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            GameObject obj = GameObject.Instantiate<GameObject>(crop, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
            obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, -1);
        }
    }
}
