using UnityEngine;
using System.Collections.Generic;
using System.Collections;

namespace VHS

{
public class DestroyInteractable : InteractableBase
  {

    public override void OnInteract()
    {
        base.OnInteract();

        Destroy(gameObject);
    }
  }
}