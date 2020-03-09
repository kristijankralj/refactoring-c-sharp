using System.Collections.Generic;
using System.Text;

namespace MakingMethodCallsSimpler
{
    public class RefactoringSession_MakingMethodCallsSimpler
    {
        public class Player
        {
            public const string PLAYER1 = "Player 1";
            public const string PLAYER2 = "Player 2";
        }

        public class Move
        {
            public string Player { get; set; }
            public int Column { get; set; }
            public int Row { get; set; }
        }


        public class Game
        {
            public string GetMoves(IEnumerable<Move> moves)
            {
                var response = new StringBuilder();
                List<Move> player1Moves = PlayerOneMoves(moves);
                List<Move> player2Moves = PlayerTwoMoves(moves);

                //Extract method - then paramaterize method, then replace parameter with explicit methods
                foreach (var move in player1Moves)
                {
                    response.Append($"P1{move.Row} - {move.Column}");
                }

                response.Append("||");

                //Extract method - then paramaterize method, then replace parameter with explicit methods
                foreach (var move in player2Moves)
                {
                    response.Append($"P2{move.Row} - {move.Column}");
                }
                return response.ToString();
            }

            //Parameterize this method
            private List<Move> PlayerOneMoves(IEnumerable<Move> moves)
            {
                List<Move> player1Moves = new List<Move>();
                foreach (var move in moves)
                {
                    if (move.Player == Player.PLAYER1)
                    {
                        player1Moves.Add(move);
                    }
                }
                return player1Moves;
            }

            //Parameterize this method
            private List<Move> PlayerTwoMoves(IEnumerable<Move> moves)
            {
                List<Move> player2Moves = new List<Move>();
                foreach (var move in moves)
                {
                    if (move.Player == Player.PLAYER2)
                    {
                        player2Moves.Add(move);
                    }
                }
                return player2Moves;
            }
        }
    }
}
