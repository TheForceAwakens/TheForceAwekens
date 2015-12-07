namespace TexasHoldem.AI.ForcedBetPlayer
{
    using System;

    using TexasHoldem.Logic.Players;

    public class ForcedBetPlayer : BasePlayer
    {
        private const int ForcedBet = 300;

        public override string Name { get; } = "ForcedBetPlayer_" + Guid.NewGuid();

        public override PlayerAction GetTurn(GetTurnContext context)
        {
            return PlayerAction.Raise(ForcedBet);
        }
    }
}
