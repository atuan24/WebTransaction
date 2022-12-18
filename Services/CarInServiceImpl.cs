
using WebTransaction.Models;

namespace Buoi8_Use_DatabaseFirst.Services
{
    public class CarInServiceImpl : ICarInService
    {

        private DatabaseContext _db;

        public CarInServiceImpl(DatabaseContext db)
        {
            _db = db;
        }
        public void CreateCarIn(AcsTransactionCarIn carIn)
        {
            _db.AcsTransactionCarIns.Add(carIn);
            _db.SaveChanges();
        }

        public void CreateCarOut(AcsTransactionCarOut carOut)
        {
            _db.AcsTransactionCarOuts.Add(carOut);
            _db.SaveChanges();
        }

        public void CreateMotorIn(AcsTransactionMotorIn motorIn)
        {
            _db.AcsTransactionMotorIns.Add(motorIn);
            _db.SaveChanges();
        }

        public void CreateMotorOut(AcsTransactionMotorOut motorOut)
        {
            _db.AcsTransactionMotorOuts.Add(motorOut);
            _db.SaveChanges();
        }
    }
}
