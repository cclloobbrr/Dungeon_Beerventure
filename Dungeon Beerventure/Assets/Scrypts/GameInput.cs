using UnityEngine;
using UnityEngine.InputSystem;


public class GameInput : MonoBehaviour
{
    public static GameInput Instanse { get; private set; }
    private PlayerInputActions _playerInpytActions;

    private void Awake()
    {
        Instanse = this;
        _playerInpytActions = new PlayerInputActions();
    }
    private void OnEnable()
    {
        _playerInpytActions.Enable();
    }
    private void OnDisable()
    {
        _playerInpytActions.Disable();
    }
    public Vector2 GetMovementVector(){
        Vector2 _inputVector = _playerInpytActions.Player.Move.ReadValue<Vector2>();

        return _inputVector;
    }

        public Vector3 GetMousePosition(){
        Vector3 _mousPos = Mouse.current.position.ReadValue();

        return _mousPos;
    }
}
