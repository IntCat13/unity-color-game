namespace _ColorGame.Scripts.GamePlay.Buttons.ButtonStates
{
    public interface IButtonState
    {
        // Set button color on state enter
        void OnEnter(GameButton button);
    }
}
