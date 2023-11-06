using System;
namespace Application
{
	public class PaintballGun
	{
		public PaintballGun(int balls, int magazineSize, bool loaded)
		{
            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
		}

        // Removed constant and made a property; you can still intialize by adding an assignment to the end of the declaration.
        public int MagazineSize { get; private set; } = 16;

        private int balls = 0;
        // Removed the property and made a new one using an auto-implemented property
        public int BallsLoaded { get; private set; }

        public bool IsEmpty() { return BallsLoaded == 0; }

        // Removed GetBalls() and SetBalls() methods and created a 'Balls' property instead

        public int Balls
        {
            get { return balls; }

            set
            {
                if (value > 0)
                    balls = value;
                Reload();
            }
        }

        public void Reload()
        {
            if (balls > MagazineSize)
                BallsLoaded = MagazineSize;
            else
                BallsLoaded = balls;
        }

        public bool Shoot()
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }
	}
}

