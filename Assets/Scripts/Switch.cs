using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public List<GameObject> item;
    public GameObject active;

    void Awake() {
        ActivateObject();
    }

    //Choose
    public void Change(GameObject obj) {
        active = obj;
        ActivateObject();
    }
    
    void ActivateObject() {
        foreach(GameObject obj in item) {
            if (obj == active) {
                obj.SetActive(true);
            }
            else {
                obj.SetActive(false);
            }
        }
    }
}
