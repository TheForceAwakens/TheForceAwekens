namespace TexasHoldem.Tests.GameSimulations.ForcedBetSimulators
{
    using AI.ForcedBetPlayer;
    using TexasHoldem.AI.SmartPlayer;
    using TexasHoldem.Logic.Players;
    using GameSimulators;

    internal class ForcedBetVsSmartPlayerSimulator : BaseGameSimulator
    {
        private readonly IPlayer firstPlayer = new ForcedBetPlayer();

        private readonly IPlayer secondPlayer = new SmartPlayer();

        protected override IPlayer GetFirstPlayer()
        {
            return this.firstPlayer;
        }

        protected override IPlayer GetSecondPlayer()
        {
            return this.secondPlayer;
        }
    }
}
