using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //wiadomoœæ przy patrzeniu na interactable
    public string promptMessage;
    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        //kod do nadpisania przez subklasy
    }
}
