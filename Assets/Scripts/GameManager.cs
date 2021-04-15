using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Switch bathroomDoor;
    public Switch bedroomDoor;
    public Switch officeDoor;
    public Switch laundryDoor;

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

            case "laundryDoor":
                laundryDoor.Change(laundryDoor.item[1]);
                SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                break;

            case "bathroomDoor":
                bathroomDoor.Change(bathroomDoor.item[1]);
                SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                break;

            // todo: check keys
            case "bedroomDoor":
                bedroomDoor.Change(bedroomDoor.item[1]);
                SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                break;

            // todo: check keys
            case "officeDoor":
                officeDoor.Change(officeDoor.item[1]);
                SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                break;


            default:
                print("Invalid interaction string");
                break;
            
        }
    }


}
