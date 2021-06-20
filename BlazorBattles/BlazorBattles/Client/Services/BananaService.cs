using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Client.Services
{
    public class BananaService : IBananaService
    {
        public event Action OnChange;
        public int Bananas { get; set; } = 100;

        public void EatBananas(int amount)
        {
            this.Bananas -= amount;
            this.BananasChanged();
        }

        public void AddBananas(int amount)
        {
            Bananas += amount;
            BananasChanged();
        }

        private void BananasChanged() => OnChange.Invoke();
    }
}