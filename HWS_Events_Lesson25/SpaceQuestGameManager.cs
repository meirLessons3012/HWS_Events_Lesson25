using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWS_Events_Lesson25
{
    internal class SpaceQuestGameManager
    {
        private int hitPoint;
        private int xLocation;
        private int yLocation;
        private int badShipsCounter;

        public event EventHandler<PointEventArgs> HpChanged;
        public event EventHandler<LocationEventArgs> LocationChanged;

        public SpaceQuestGameManager(int hitPoint, int xLocation, int yLocation, int badShipsCounter)
        {
            this.hitPoint = hitPoint;
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.badShipsCounter = badShipsCounter;
        }

        public void Move(int newX, int newY)
        {
            xLocation = newX;
            yLocation = newY;
            OnLocationChanged(newX, newY);
        }

        public void ShipGotDamaged(int damage)
        {
            hitPoint -= damage;
            OnHpChanged(damage);
        }

        public void ShipGotExtraHP(int extraHP)
        {
            hitPoint += extraHP;
            OnHpChanged(extraHP);
        }

        private void OnHpChanged(int hp)
        {
            HpChanged?.Invoke(this, new PointEventArgs(hp));
        }

        private void OnLocationChanged(int x, int y)
        {
            LocationChanged?.Invoke(this, new LocationEventArgs(x,y));
        }
    }
}
