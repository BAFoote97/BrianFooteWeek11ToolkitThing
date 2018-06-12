using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTrigger : MonoBehaviour {

    public bool OneTime;
    private bool _triggered;

    //public UnityEvent Enter;
    //public UnityEvent Stay;
    //public UnityEvent Exit;

    public GameObject triggerPosition1;
    public GameObject triggerPosition2;

    public bool inPosition1;
    public bool inPosition2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && inPosition1 == true)
        {
            gameObject.transform.position = triggerPosition2.transform.position;
            inPosition2 = true;
            inPosition1 = false;
        }
        if (other.gameObject.tag == "Player" && inPosition2 == true)
        {
            gameObject.transform.position = triggerPosition1.transform.position;
            inPosition1 = true;
            inPosition2 = false;
        }
        //    return;

        //if (!_triggered)
        //{
        //   Enter.Invoke();
        //    if(OneTime)
        //        _triggered = true;
        //}
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject == gameObject || other.gameObject == gameObject.transform.parent)
    //        return;
        
    //    if (!_triggered)
    //    {
    //        Stay.Invoke();
    //        if (OneTime)
    //            _triggered = true;
    //    }
   // }

    //private void OnTriggerExit(Collider other)
    //{
     //   if (other.gameObject == gameObject || other.gameObject == gameObject.transform.parent)
      //      return;
        
    //    if (!_triggered)
    //    {
    //        Exit.Invoke();
    //        if (OneTime)
    //            _triggered = true;
    //    }
    //}

    //private void OnValidate()
    //{
    //    GetComponent<Collider>().isTrigger = true;
    //}
}
