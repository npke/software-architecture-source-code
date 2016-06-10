using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuffDemo
{
    public class Hero: IBuff
    {
        public int HP = 100;
        public string Name = "";
        public Hero(int hp, string name)
        {
            HP = hp;
            Name = name;
        }

        public void IncreaseHP(int val)
        {
            HP += val;
        }

        public IBuff target = null;
        public void SetTarget(IBuff newTarget)
        {
            target = newTarget;
        }

        public bool OnBuff()
        {
            if (target !=null)
                if (this.HP > 10)
                {
                    this.HP -= 10;
                    target.IncreaseHP(10);
                    return true;
                }
            return false;
        }






    }
}