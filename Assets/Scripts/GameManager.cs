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
    public Switch kitchenLight;
    public Switch kitchenLight2;
    public Switch entryLight;
    public Switch computerLight;
    public Switch bedroomLight;
    public Switch livingRoomLight;
    public Switch washroomLight;
    public Switch otherAreaLights;
    public Switch safeDoor;

    private bool bedroomKeyPickedUp;
    private bool computerRoomKeyPickedUp;
    private bool safeKeyPickedUp;

    private bool bedroomUnlocked;
    private bool computerRoomUnlocked;
    private bool safeUnlocked;


    public GameObject bedKey;
    public GameObject compKey;
    public GameObject safeKey;
    public GameObject bedKeyHole;
    public GameObject compKeyHole;
    public GameObject safeKeyHole;
    public GameObject note;

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
        switch (interaction)
        {
            case "test":
                print("test");
                break;

            case "lockedDoor":
                SoundManager.PlayOneClip(AudioClips.singleton.doorLocked, 1);
                break;
                
            case "laundryDoor":
                laundryDoor.Change(laundryDoor.item[1]);
                SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                break;

            case "ransomNote":
                note.SetActive(true);
                SoundManager.PlayOneClip(AudioClips.singleton.pickupNote, 1);
                break;

            case "bathroomDoor":
                bathroomDoor.Change(bathroomDoor.item[1]);
                SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                break;

            // todo: check keys
            case "bedroomDoor":
                if (bedroomUnlocked)
                {
                    bedroomDoor.Change(bedroomDoor.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                }
                else
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.doorLocked, 1);
                }
                break;

            case "safeUnlocked":
                if (safeUnlocked)
                {
                    safeDoor.Change(safeDoor.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.openSafe, 1);
                }
                else
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.safeLocked, 1);
                }
                break;

            // todo: check keys
            case "officeDoor":
                if (computerRoomUnlocked)
                {
                    officeDoor.Change(officeDoor.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.openDoor, 1);
                }
                else
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.doorLocked, 1);
                }
                break;

            case "kitchenLight":
                if (kitchenLight.active == kitchenLight.item[1])
                {
                    kitchenLight.Change(kitchenLight.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    kitchenLight.Change(kitchenLight.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }

            case "kitchenLight2":
                if (kitchenLight2.active == kitchenLight2.item[1])
                {
                    kitchenLight2.Change(kitchenLight2.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    kitchenLight2.Change(kitchenLight2.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }

            case "entryLight":
                if (entryLight.active == entryLight.item[1])
                {
                    entryLight.Change(entryLight.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    entryLight.Change(entryLight.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }

            case "computerLight":
                if (computerLight.active == computerLight.item[1])
                {
                    computerLight.Change(computerLight.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    computerLight.Change(computerLight.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }


            case "bedroomLight":
                if (bedroomLight.active == bedroomLight.item[1])
                {
                    bedroomLight.Change(bedroomLight.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    bedroomLight.Change(bedroomLight.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }

            case "washroomLight":
                if (washroomLight.active == washroomLight.item[1])
                {
                    washroomLight.Change(washroomLight.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    washroomLight.Change(washroomLight.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }

            case "livingRoomLight":
                if (livingRoomLight.active == livingRoomLight.item[1])
                {
                    livingRoomLight.Change(livingRoomLight.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    livingRoomLight.Change(livingRoomLight.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }

            case "otherAreaLights":
                if (otherAreaLights.active == otherAreaLights.item[1])
                {
                    otherAreaLights.Change(otherAreaLights.item[0]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }
                else
                {
                    otherAreaLights.Change(otherAreaLights.item[1]);
                    SoundManager.PlayOneClip(AudioClips.singleton.switchFlip, 1);
                    break;
                }

            case "bedKeyPickup":
                bedroomKeyPickedUp = true;
                SoundManager.PlayOneClip(AudioClips.singleton.pickupKey, 1);
                Destroy(bedKey);
                break;

            case "compKeyPickup":
                computerRoomKeyPickedUp = true;
                SoundManager.PlayOneClip(AudioClips.singleton.pickupKey, 1);
                Destroy(compKey);
                break;

            case "safeKeyPickup":
                safeKeyPickedUp = true;
                SoundManager.PlayOneClip(AudioClips.singleton.pickupKey, 1);
                Destroy(safeKey);
                break;


            case "unlockBedDoor":
                if (bedroomKeyPickedUp)
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.unlock, 1);
                    bedroomUnlocked = true;
                }
                else
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.doorLocked, 1);
                }
                break;

            case "unlockCompDoor":
                if (computerRoomKeyPickedUp)
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.unlock, 1);
                    computerRoomUnlocked = true;
                }
                else
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.doorLocked, 1);
                }
                break;

            case "unlockSafeDoor":
                if (safeKeyPickedUp)
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.unlock, 1);
                    safeUnlocked = true;
                }
                else
                {
                    SoundManager.PlayOneClip(AudioClips.singleton.safeLocked, 1);
                }
                break;







            default:
                print("Invalid interaction string");
                break;

        }
    }


}
