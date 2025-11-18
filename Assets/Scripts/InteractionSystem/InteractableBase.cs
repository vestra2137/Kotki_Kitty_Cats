using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{
    public class InteractableBase : MonoBehaviour, IInteractable
    {
        #region Variables
        [Header("Interactable Settings")]

        public float holdDuration;

        [Space]

        public bool holdInteract;

        public bool multipleUse;

        public bool isInteractable;

        public float HoldDuration => throw new System.NotImplementedException();

        #endregion

        #region Properties
        public bool HoldInteract => throw new System.NotImplementedException();
        public bool MultipleUse => throw new System.NotImplementedException();
        public bool IsInteractable => throw new System.NotImplementedException();
        #endregion

        #region Methods
        public void OnInteract()
        {
            Debug.Log("INTERACTED: " + gameObject.name);
        }
        #endregion
    }
}
