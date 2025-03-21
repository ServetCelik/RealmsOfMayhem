namespace RealmsOfMayhem.Core.Entities.Buildings
{
    public abstract class Building
    {
        public int Size { get; protected set; }
        public int Price { get; protected set; }
        public int Hp { get; protected set; }



        protected Building(int size, int price, int hp)
        {
            Size = size;
            Price = price;
            Hp = hp;
        }

    }

    public class Farm : Building
    {
        public Farm() : base(10,100, 50)
        {

        }
    }

    public class House : Building
    {
        public House() : base(5,10, 50)
        {

        }
    }

    public class Wall : Building
    {
        public Wall() : base(1,1, 50)
        {
        }
    }
}
