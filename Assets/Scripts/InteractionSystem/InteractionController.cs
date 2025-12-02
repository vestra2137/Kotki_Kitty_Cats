using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace VHS
{
    public class InteractionController : MonoBehaviour
    {
        [Header("Data")]
        [SerializeField] private InteractionInputData interactionInputData;
        [SerializeField] private InteractionData interactionData;

        [Header("UI")]
        [SerializeField] private InteractionUI uiPanel;

        [Header("Ray Settings")]
        [SerializeField] private float rayDistance = 3f;
        [SerializeField] private float raySphereRadius = 0.3f;
        [SerializeField] private LayerMask interactableLayer;

        private Camera m_cam;
        private bool m_interacting = false;
        private float m_holdTimer = 0f;

        private void Awake()
        {
            m_cam = Camera.main;
        }

        private void Update()
        {
            CheckForInteractable();
            CheckForInteractableInput();
        }

        private void CheckForInteractable()
        {
            Ray _ray = new Ray(m_cam.transform.position, m_cam.transform.forward);
            RaycastHit _hitInfo;

            bool _hitSomething = Physics.SphereCast(
                _ray,
                raySphereRadius,
                out _hitInfo,
                rayDistance,
                interactableLayer
            );

            Debug.DrawRay(_ray.origin, _ray.direction * rayDistance, _hitSomething ? Color.green : Color.red);

            if (_hitSomething)
            {
                InteractableBase interactable = _hitInfo.transform.GetComponent<InteractableBase>();

                if (interactable != null)
                {
                    if (interactionData.IsEmpty())
                    {
                        interactionData.Interactable = interactable;
                        uiPanel.SetTooltip("Interact");
                    }
                    else if (!interactionData.IsSameInteractable(interactable))
                    {
                        interactionData.Interactable = interactable;
                        uiPanel.SetTooltip(interactable.TooltipMessage);
                    }
                }
            }
            else
            {
                uiPanel.ResetUI();
                interactionData.ResetData();
            }
        }

        private void CheckForInteractableInput()
        {
            if (interactionData.IsEmpty())
                return;

            // Wciœniêcie
            if (interactionInputData.InteractedClicked)
            {
                m_interacting = true;
                m_holdTimer = 0f;
                interactionInputData.InteractedClicked = false;
            }

            // Puszczenie
            if (interactionInputData.InteractedRelease)
            {
                m_interacting = false;
                m_holdTimer = 0f;
                interactionInputData.InteractedRelease = false;
                uiPanel.UpdateProgressBar(0f);
            }

            if (!m_interacting)
                return;

            InteractableBase interactable = interactionData.Interactable;

            if (!interactable.IsInteractable)
                return;

            if (interactable.HoldInteract)
            {
                // Trzymanie przycisku
                m_holdTimer += Time.deltaTime;

                float percent = m_holdTimer / interactable.HoldDuration;
                uiPanel.UpdateProgressBar(percent);

                if (percent >= 1f)
                {
                    interactionData.Interact();
                    m_interacting = false;
                    uiPanel.ResetUI();
                }
            }
            else
            {
                // Klikniêcie
                interactionData.Interact();
                m_interacting = false;
                uiPanel.ResetUI();
            }
        }
    }
}
