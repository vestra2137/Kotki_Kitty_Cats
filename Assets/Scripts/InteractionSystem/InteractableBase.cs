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
    }
}
