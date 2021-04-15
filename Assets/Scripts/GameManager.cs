using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Switch bathDoor;

    void Awake()
    {
        if (instance != null)
            GameObject.Destroy(instance);
        else
            instance = this;

        //DontDestroyOnLoad(this);
    }

    //handle interaction events
    public void Interaction(string interaction)
    {
        // too lazy to make enums for this tbh
        switch (interaction){
            case "test":
                print("test");
                break;

            case "bathroomDoor":
                bathDoor.Change(bathDoor.item[1]);
                SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);

                break;

            default:
                print("Invalid interaction string");
                break;
            
        }
    }


}
