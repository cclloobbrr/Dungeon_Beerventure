using UnityEngine;


public class PlayerVisual : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRender;
    
    private const string IS_RUNNING = "IsRunning";

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRender = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        _animator.SetBool(IS_RUNNING, Player.Instance.IsRunning());
        Mouse_plauer();
    }

    private void Mouse_plauer(){
        Vector3 _mousePos = GameInput.Instanse.GetMousePosition();
        Vector3 _playerPos = Player.Instance.GetPlayerPosition();

        if(_mousePos.x < _playerPos.x){
            _spriteRender.flipX = true;
        } else{
            _spriteRender.flipX = false;
        }
    }    

}
