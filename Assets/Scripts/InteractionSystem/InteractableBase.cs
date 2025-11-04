using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{
    public class InteractableBase : MonoBehaviour, IInteractable
    {
        [Header("Interactable Settings")]

        public float holdDuration;

        [Space]

        public bool holdInteract;

        public bool multipleUse;

        public bool isInteractable;

        public float HoldDuration => throw new System.NotImplementedException();

        public bool HoldInteract => throw new System.NotImplementedException();

        public bool MultipleUse => throw new System.NotImplementedException();

        public bool IsInteractable => throw new System.NotImplementedException();

        public void OnInteract()
        {
            throw new System.NotImplementedException();
        }
    }
}
