using System;
using System.Collections.Generic;

namespace SimplifyingConditional
{
    public class IntroduceNullObject
    {
        public class BattleRobot
        {
            public int Team { get; set; }
            public int Health { get; set; }
            public int XCoordinate { get; set; }
            public int YCoordinate { get; set; }

            #region Methods

            public void Attack(int x, int y)
            {
                //TODO shoot missiles
            }

            public List<Tuple<int, int>> GetPossibleMoves()
            {
                //TODO some complex implementation
                return null;
            }

            public List<Tuple<int, int>> GetEnemyLocations()
            {
                //TODO some complex implementation
                return null;
            }

            #endregion
        }

        private BattleRobot _robot;

        public BattleRobot Robot { get => _robot; set => _robot = value; }

        public bool CanStillFight()
        {
            if (_robot != null)
            {
                return true;
            }
            return false;
        }

        public void AttackPosition(int x, int y)
        {
            if (_robot != null)
            {
                _robot.Attack(x, y);
            }
        }

        public void UpdateStrategy()
        {
            if (_robot != null)
            {
                List<Tuple<int, int>> posssibleMoves = _robot.GetPossibleMoves();
                List<Tuple<int, int>> enemyLocations = _robot.GetEnemyLocations();

                foreach (var move in posssibleMoves)
                {
                    DevelopStrategy(move, enemyLocations);
                }
            }
        }

        #region Other methods
        private void DevelopStrategy(Tuple<int, int> move, List<Tuple<int, int>> locations)
        {

        }
        #endregion
    }
}
