using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{


    public class InteractionController : MonoBehaviour
    {
        #region Variables

        [Header("Data")]

        public InteractionInputData interactionInputData;

        public InteractionData interactionData;

        [Space]
        [Header("Ray Settings")]

        public float rayDistance;

        public float raySphereRadius;

        public LayerMask interactableLayer;

        private Camera m_cam;
        #endregion

        #region Built In Methods
        void Awake()
        {
            m_cam = Object.FindFirstObjectByType<Camera>();
        } 

        void Update()
        {
            CheckForInteractable();
            CheckForInteractableInput();
        }
        #endregion

        #region Custom methods
        void CheckForInteractable()
        {

        }

        void CheckForInteractableInput()
        {

        }
        #endregion
    }   

}
