using System;
using System.Collections.Generic;
using System.Text;
using SungSiKyung.Data;
using SungSiKyung.Interfaces;

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
        
        /*public void EnemyisAttacked()
        {
            if (_Player.Attacked)
            {
                NowHp -= _Player.AttackDamage;
                _Player.Attacked = false;

            }
        }*/



    }
}
