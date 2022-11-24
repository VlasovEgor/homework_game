using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour, IConstructListener, IStartGameListener, IFinishGameListener
{
    private Transform _targetCamera;
    private IGetPlayerPhysicsComponent _getPositionComponent;

    private void Awake()
    {
        enabled = false;
    }

    private void LateUpdate()
    {
        _targetCamera.position = _getPositionComponent.GetPlayerPosition();
    }

    public void Construct(GameContext context)
    {
        _targetCamera = context.GetService<CameraService>().CameraTransfrom;
        _getPositionComponent = context.GetService<CharacterService>().GetCharacter().Get<IGetPlayerPhysicsComponent>();
    }

    public void OnStartGame()
    {
        enabled = true;
    }

    public void OnFinishGame()
    {
        enabled = false;
    }
}
