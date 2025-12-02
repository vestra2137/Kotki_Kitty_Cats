using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{
    public class InteractableBase : MonoBehaviour, IInteractable
    {
        [Header("Interactable Settings")]

        [Tooltip("Tekst wyœwietlany na UI przy patrzeniu na obiekt")]
        [SerializeField] private string tooltipMessage = "Interact";

        [Tooltip("Czy wymaga przytrzymania?")]
        [SerializeField] private bool holdInteract = false;

        [Tooltip("Czas przytrzymania")]
        [SerializeField] private float holdDuration = 1f;

        [Tooltip("Czy obiekt mo¿na u¿yæ wiele razy?")]
        [SerializeField] private bool multipleUse = true;

        [Tooltip("Czy interakcja jest w ogóle mo¿liwa?")]
        [SerializeField] private bool isInteractable = true;



        // --------- implementacja interfejsu IInteractable ----------

        public string TooltipMessage => tooltipMessage;
        public bool HoldInteract => holdInteract;
        public float HoldDuration => holdDuration;
        public bool MultipleUse => multipleUse;
        public bool IsInteractable => isInteractable;

        public virtual void OnInteract()
        {
            Debug.Log("INTERACTED: " + gameObject.name);
        }
    }
}
