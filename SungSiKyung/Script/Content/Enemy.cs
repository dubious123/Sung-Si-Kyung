using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Components;
using SungSiKyung.Data;
using SungSiKyung.Interfaces;
using SungSiKyung.Script.Rendering;
using SungSiKyung.Script.Utils;

namespace SungSiKyung.Script.Content
{
    public class Enemy : BaseUnit, IUseGravity
    {
        public string enemyName;
        public int MaxHp;
        public int NowHp;
        public int AtkDamage;

        private void SetEnemyStatus(string _enemyName, int _maxHp, int _atkDamage)
        {
            enemyName = _enemyName;
            MaxHp = _maxHp;
            NowHp = _maxHp;
            AtkDamage = _atkDamage;
        }

        public Enemy()
        {

        }



    }
}
