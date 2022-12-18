using Buoi8_Use_DatabaseFirst.Models;
using WebTransaction.Models;

namespace Buoi8_Use_DatabaseFirst.Services
{
    public interface ICarInService
    {
        public void CreateCarIn(AcsTransactionCarIn carIn);
        public void CreateCarOut(AcsTransactionCarOut carOut);
        public void CreateMotorIn(AcsTransactionMotorIn motorIn);
        public void CreateMotorOut(AcsTransactionMotorOut motorOut);
    }
}
