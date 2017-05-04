using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imbeggingyou : MonoBehaviour { private Vector3 screenPoint; private Vector3 offset; private float _lockedXPosition;

     void OnMouseDown() {
        //screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position); // I removed this line to prevent centring 
        _lockedXPosition = screenPoint.x;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        
         
         
               
     }
     
     void OnMouseDrag() 
     { 
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        curPosition.y = _lockedXPosition;
        transform.position = curPosition;
     }
     
     void OnMouseUp()
     {
        Cursor.visible = true;
     }
}
