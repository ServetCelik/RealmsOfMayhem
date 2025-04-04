﻿using RealmsOfMayhem.Core.Entities.Buildings;

namespace RealmsOfMayhem.Core.Entities
{
    public class User
    {
        public int Id { get; private set; }
        public int AccountId { get; private set; }
        public Account Account { get; private set; } = null!;

        public string Username { get; private set; }
        public int TotalPoints { get; private set; } = 0;
        public int Gold { get; private set; }
        public int Wheat { get; private set; }
        public int LandSize { get; private set; }
        public int Population { get; private set; }
        public List<UserBuilding> Buildings { get; private set; } = new();
        public int LocationX { get; private set; }
        public int LocationY { get; private set; }

        public Army Army { get; private set; } = new Army();


        public User(Account account, int locationX, int locationY)
        {
            if (account == null) throw new ArgumentNullException(nameof(account));
            if (locationX < 0 || locationX >= 100 || locationY < 0 || locationY >= 100)
                throw new ArgumentException("Location must be within the 100x100 grid.");

            Account = account;
            AccountId = account.Id;
            Username = account.Username;
            LocationX = locationX;
            LocationY = locationY;
        }

        public void AddGold(int amount)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
            Gold += amount;
        }

        public void SpendGold(int amount)
        {
            if (amount < 0 || Gold < amount) throw new ArgumentException("Not enough gold.");
            Gold -= amount;
        }

        public void HarvestWheat(int amount)
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
            Wheat += amount;
        }

        public void UseWheat(int amount)
        {
            if (amount < 0 || Wheat < amount) throw new ArgumentException("Not enough wheat.");
            Wheat -= amount;
        }

        public void Build(Building building, int count = 1)
        {
            var existing = Buildings.FirstOrDefault(b => b.Building.GetType() == building.GetType());

            if (existing != null)
            {
                existing.Add(count);
            }
            else
            {
                Buildings.Add(new UserBuilding(building, count));
            }

            Gold -= building.Price * count;
        }

        public int GetBuildingCount<T>() where T : Building
        {
            return Buildings
                .FirstOrDefault(b => b.Building is T)?.Count ?? 0;
        }
    }
}

