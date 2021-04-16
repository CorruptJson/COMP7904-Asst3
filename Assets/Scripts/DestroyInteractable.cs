using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInteractable : Interactable
{
    public override void Activate() {
        Object.Destroy(gameObject);
    }
}
