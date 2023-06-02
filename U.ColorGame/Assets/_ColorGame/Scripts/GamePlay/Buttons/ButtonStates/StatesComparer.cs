namespace _ColorGame.Scripts.GamePlay.Buttons.ButtonStates
{
    public static class StatesComparer
    {
        // Compare two states
        public static bool Compare(this IButtonState state1, IButtonState state2)
        {
            return state1.GetType() == state2.GetType();
        }
    }
}
