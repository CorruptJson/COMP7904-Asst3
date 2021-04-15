using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    private Character player;
    public string interaction;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Character>();

    }

    void Update()
    {
        if (player.camera.GetComponent<Eyes>().obj == this.gameObject)
        {
            GetComponent<cakeslice.Outline>().enabled = true;
            if (Input.GetMouseButtonDown(0))
            {
                Activate();
            }
        }
        else
        {
            GetComponent<cakeslice.Outline>().enabled = false;
        }
    }


    public virtual void Activate()
    {
        GameManager.instance.Interaction(interaction);
    }


}
