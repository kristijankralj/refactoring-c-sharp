using System;

namespace ComposingMethods
{
    #region Other Classes
    public class Ship
    {
        public int ShootDelay { get { return 2; } }

        public void ShootRocket()
        {

        }

        public void ShootMissile()
        {

        }
    }

    static class Keyboard
    {
        internal static KeyboardState GetState()
        {
            return new KeyboardState();
        }

        internal static void QuitCurrentApplication()
        {

        }
    }

    class KeyboardState
    {
        internal bool IsKeyDown(Keys key)
        {
            return key == Keys.Space;
        }
    }

    enum Keys
    {
        Escape,
        Space
    }

    #endregion

    public class ReplaceTempWithQuery
    {
        private int _shootTime;
        private int _missileTime;
        private Ship _spaceShip;

        public ReplaceTempWithQuery(Ship ship)
        {
            _spaceShip = ship;
        }

        public void CheckControls(DateTime gameTime)
        {
            KeyboardState keyBoardState = Keyboard.GetState();
            if (keyBoardState.IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            _shootTime -= gameTime.Millisecond;
            //Shoot rocket
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                if (_shootTime >= 6)
                {
                    _spaceShip.ShootRocket();
                    _shootTime = _spaceShip.ShootDelay;
                }
            }
            else
            {
                _shootTime = 0;
            }

            //Shoot missile
            _missileTime -= gameTime.Millisecond;
            if (keyBoardState.IsKeyDown(Keys.Space))
            {
                if (_missileTime > 10)
                {
                    _spaceShip.ShootMissile();
                }
            }
            else
            {
                _missileTime = 0;
            }
        }

        private void Exit()
        {
            Keyboard.QuitCurrentApplication();
        }
    }
}
