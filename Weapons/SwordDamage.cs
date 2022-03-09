using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace SwordDamageWFP // Chapter 5 - Encapsulation (specifically practiced using encapsulation due to some bugs)
{
    class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        private decimal magicMultiplier = 1M;
        private int flamingDamage = 0;
        public int Damage;

        private void CalculateDamage()
        {
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE + flamingDamage;
            Debug.WriteLine($"CalculatedDamage finished: {Damage} (roll: {Roll}) ");
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                magicMultiplier = 1.75M;
            }

            else
            {
                magicMultiplier = 1M; // what's the point of putting this here if the MagicMultiplier only ever gets changed if the bool isMagic = True??
            }

            CalculateDamage();
            Debug.WriteLine($"SetMagic finished: {Damage} (roll: {Roll}) ");
        }

        public void SetFlaming(bool isFlaming)
        {
            CalculateDamage();
            if(isFlaming)
            {
                Damage += FLAME_DAMAGE;
            }
            Debug.WriteLine($"SetFlaming finished: {Damage} (roll: {Roll}) ");
        }
    }
}
