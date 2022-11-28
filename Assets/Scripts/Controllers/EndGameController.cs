using UnityEngine;

public class EndGameController : MonoBehaviour, IConstructListener
{
    private GameContext _context;

    public void Construct(GameContext context)
    {
        _context = context;
        _context.GetService<CharacterService>().GetCharacter().Get<ITriggerComponent>().PlayerTriggerEntered += OnTriggerEntered;
    }

    private void OnDestroy()
    {
        _context.GetService<CharacterService>().GetCharacter().Get<ITriggerComponent>().PlayerTriggerEntered -= OnTriggerEntered;
    }

    private void OnTriggerEntered(Collider obj)
    {
        if (obj.CompareTag("Finish"))
        {
            _context.FinishGame();
        }
    }
}