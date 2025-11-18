using UnityEngine;
using NaughtyAttributes;

namespace VHS
{
    public class InputHandler : MonoBehaviour
    {
        #region Data
        [BoxGroup("Input Data")]

        public CameraInputData cameraInputData;
        [BoxGroup("Input Data")]

        public MovementInputData movementInputData;
        [BoxGroup("Input Data")]

        public InteractionInputData interactionInputData;
        #endregion
        private void Update()
        {

            GetCameraInputData();
            GetMovementInputData();
            GetInteractionInputData();
        }

        private void GetCameraInputData()
        {
            cameraInputData.InputVectorX = Input.GetAxis("Mouse X");
            cameraInputData.InputVectorY = Input.GetAxis("Mouse Y");

        }

        private void GetMovementInputData()
        {
            movementInputData.InputVector.x = Input.GetAxis("Horizontal");
            movementInputData.InputVector.y = Input.GetAxis("Vertical");

            movementInputData.Jumped = Input.GetKeyDown(KeyCode.Space);
        }

        private void GetInteractionInputData()
        {
            interactionInputData.InteractedClicked = Input.GetKeyDown(KeyCode.E);
            interactionInputData.InteractedRelease = Input.GetKeyUp(KeyCode.E);

        }
    }
}
