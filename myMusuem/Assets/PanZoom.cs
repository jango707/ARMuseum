using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanZoom : MonoBehaviour
{
    Vector3 touchstart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.orthographicSize < 20 && Camera.main.orthographicSize > 10)
        {
            float scroll = Input.GetAxis("Mouse ScrollWheel") * 2;

            
            Camera.main.orthographicSize -= scroll;
        }
        else
        {
            Camera.main.orthographicSize = 19.9f;
        }

        if (Input.GetMouseButtonDown(0)){
            touchstart = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        if (Input.GetMouseButton(0))
        {
            Vector3 direction = touchstart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
           
            Camera.main.transform.position += direction;
        }
    }
}
