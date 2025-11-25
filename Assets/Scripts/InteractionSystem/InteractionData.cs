using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{
    [CreateAssetMenu(fileName = "InteractionData", menuName = "InteractionSystem/InteractionData")]
    public class InteractionData : ScriptableObject
    {
        private InteractableBase m_interactable;

        public InteractableBase Interactable
        {
            get => m_interactable;
            set => m_interactable = value;
        }

        public void Interact()
        {
            m_interactable.OnInteract();
            ResetData();
        }

        public bool IsSameInteractable(InteractableBase newInteractable)
            => m_interactable == newInteractable;

        public void ResetData()
            => m_interactable = null;
        public bool IsEmpty()
            => m_interactable == null;
    }
}
