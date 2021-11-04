using System.Collections;
using System.Collections.Generic;
using Interfaces.Models;
using UnityEngine;

public class MainLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //По нажатию ЛКМ
        if(Input.GetMouseButton(0)){
            RaycastHit2D rayHit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            IStandUser target = rayHit.transform?.GetComponent<IStandUser>();
    
            Debug.Log(target);

            if(target is IStandUser){
                target.Use();
            }
        }
    }
}
