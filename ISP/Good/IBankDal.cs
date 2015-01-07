using ISP.Common;

namespace ISP.Good
{
    public interface IBankDal : IBaseDalContract<Bank>
    {
        void Delete(Bank bank);
    }
}
