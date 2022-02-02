using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class l : MonoBehaviour
{
    public void Start(){
       StartCoroutine(ExecuteSomething());
}
    IEnumerator ExecuteSomething (){
        yield return new WaitForSeconds(10f);
        Debug.Log("It worked!");
    }
}