using Sirenix.OdinInspector;
using UnityEngine;

public class FinishGame : MonoBehaviour, IConstractListener
{
    [SerializeField] private EventReceiver_Trigger _deathZoneTrigger;
    [SerializeField] private GameContext _context;

    //private IGetPlayerPhysicsComponent _getPlayerColliderComponent;

    private void OnEnable()
    {
        _deathZoneTrigger.OnTriggerEntered += Finish;
    }

    private void OnDestroy()
    {
        _deathZoneTrigger.OnTriggerEntered -= Finish;
    }

    public void Construct(GameContext context)
    {
       // _getPlayerColliderComponent = context.GetService<CharacterService>().GetCharacter().Get<IGetPlayerPhysicsComponent>();
    }

    private void Finish(Collider obj)
    {
        //if (obj != _getPlayerColliderComponent.GetPlayerCollider())
        //{
        //    return;
        //}

        _context.FinishGame();
    }
}
