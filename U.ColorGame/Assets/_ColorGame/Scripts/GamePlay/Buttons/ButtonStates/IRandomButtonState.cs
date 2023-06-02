using JetBrains.Annotations;

namespace _ColorGame.Scripts.GamePlay.Buttons.ButtonStates
{
    public interface IRandomButtonState
    {
        ButtonState GetRandomState([CanBeNull] ButtonState previousState);
        ButtonState GetRandomState();
    }
}
