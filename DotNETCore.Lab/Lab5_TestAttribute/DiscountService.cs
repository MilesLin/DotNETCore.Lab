namespace DotNETCore.Lab.Lab5_TestAttribute
{
    public class DiscountService
    {
        public decimal GetDiscountPrice(decimal regularPrice, Membership membership, decimal eventDiscount = 1)
        {
            decimal discount = 1;

            switch (membership)
            {
                case Membership.Guest:
                    discount = 0.95m;
                    break;

                case Membership.Common:
                    discount = 0.90m;
                    break;

                case Membership.VIP:
                    discount = 0.8m;
                    break;
            }

            return regularPrice * discount * eventDiscount;
        }

        public void SetupEvent()
        {
            throw new System.NotImplementedException();
        }
    }
}