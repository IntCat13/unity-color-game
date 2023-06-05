using JetBrains.Annotations;

namespace _ColorGame.Scripts.GamePlay.Buttons.ButtonStates
{
    // This interface is responsible for getting random button state
    public interface IRandomButtonState
    {
        ButtonState GetRandomState([CanBeNull] ButtonState previousState);
        ButtonState GetRandomState();
    }
}
