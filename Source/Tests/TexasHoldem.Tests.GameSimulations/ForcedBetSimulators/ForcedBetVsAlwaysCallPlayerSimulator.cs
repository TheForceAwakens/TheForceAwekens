namespace TexasHoldem.Tests.GameSimulations.ForcedBetSimulators
{
    using AI.ForcedBetPlayer;
    using AI.DummyPlayer;
    using TexasHoldem.Logic.Players;
    using GameSimulators;

    internal class ForcedBetVsAlwaysCallPlayerSimulator : BaseGameSimulator
    {
        private readonly IPlayer firstPlayer = new ForcedBetPlayer();

        private readonly IPlayer secondPlayer = new AlwaysCallDummyPlayer();

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
