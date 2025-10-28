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

        #region BuiltIn Methods

        private void Start()
        {
            cameraInputData.ResetInput();
            movementInputData.ResetInput();
            interactionInputData.ResetInput();
        }

        private void Update()
        {
            GetCameraInput();
            GetMovementInputData();
            GetInteractionInputData();
        }
        #endregion

        #region Custom Methods

        void InteractionInputData()
        {
            interactionInputData.InteractedClicked = Input.GetKeyDown(KeyCode.E);
            Debug.Log("E CLICKED" + interactionInputData.InteractedClicked);
            interactionInputData.InteractedRelase = Input.GetKeyUp(KeyCode.E);
            Debug.Log("E RELEASED" + interactionInputData.InteractedRelase);
        }


        void GetCameraInput()
        {
            cameraInputData.InputVectorX = Input.GetAxis("Mouse X");
            cameraInputData.InputVectorY = Input.GetAxis("Mouse Y");

            cameraInputData.ZoomClicked = Input.GetMouseButtonDown(1);
            cameraInputData.ZoomRelased = Input.GetMouseButtonUp(1);

        }

        void GetMovementInputData()
        {
            movementInputData.InputVectorX = Input.GetAxisRaw("Horizontal");
            movementInputData.InputVectorY = Input.GetAxisRaw("Vertical");

            //movementInputData.IsRunning = Input.GetKey(KeyCode.LeftShift);
            movementInputData.RunClicked = Input.GetKeyDown(KeyCode.LeftShift);
            movementInputData.RunReleased = Input.GetKeyUp(KeyCode.LeftShift);

            if (movementInputData.RunClicked)
                movementInputData.IsRunning = true;

            if (movementInputData.RunReleased)
                movementInputData.IsRunning = false;
        }
        #endregion
    }
}