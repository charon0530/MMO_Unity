using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision");
    }
    private void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Trigger");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f);
            int mask = (1 << 8) | (1 << 9);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f, mask))
            {
               // Debug.Log($"RayCast Camera @ {hit.collider.gameObject.name}");
            }
        }
        #region 마우스 레이케스트 원리 주석
        /*
        Vector3 look = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position + Vector3.up, look * 10, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, look, out hit, 10))
        {
            Debug.Log($"RayCast! {hit.collider.gameObject.name}");
        }
        */
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        //    Vector3 dir = mousePos - Camera.main.transform.position;
        //    dir = dir.normalized;

        //    Debug.DrawRay(Camera.main.transform.position, dir * 100.0f, Color.red, 1.0f);
        //    RaycastHit hit;
        //    if (Physics.Raycast(Camera.main.transform.position, dir, out hit, 100.0f))
        //    {
        //        Debug.Log($"RayCast Camera @ {hit.collider.gameObject.name}");
        //    }
        //}  
        #endregion
    }
}
