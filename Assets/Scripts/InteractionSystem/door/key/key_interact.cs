using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{
    public class InteractableBase : MonoBehaviour, IInteractable
    {
        [Header("Interactable Settings")]

        [Tooltip("Klucz zdobyty")]
        [SerializeField] private string tooltipMessage = "Podnieœ";

        [Tooltip("Czy wymaga przytrzymania?")]
        [SerializeField] private bool holdInteract = false;

        [Tooltip("Czas przytrzymania")]
        [SerializeField] private float holdDuration = 1f;

        [Tooltip("Czy obiekt mo¿na u¿yæ wiele razy?")]
        [SerializeField] private bool multipleUse = false;

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
