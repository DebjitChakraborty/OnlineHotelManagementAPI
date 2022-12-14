using OnlineHotelManagementAPI.Models;

namespace OnlineHotelManagementAPI.Repositories
{
    public class PaymentRepo : IPayment
    {
        private HotelContext _context;

        public PaymentRepo(HotelContext context)
        {
            _context = context;
        }

        #region GetAllPayment
        public List<Payment> GetAllPayment()
        {
            try
            {
                List<Payment> payment = _context.Payments.ToList();
                return payment;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region InsertPayment
        public string InsertPayment(Payment payment)
        {
            string stcode = string.Empty;
            try
            {
                _context.Payments.Add(payment);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion

        #region SavePayment
        public void SavePayment(Payment payment)
        {
            _context.SaveChanges();
        }
        #endregion

        #region UpdatePayment
        public string UpdatePayment(Payment payment)
        {
            string stcode = string.Empty;
            try
            {
                _context.Payments.Update(payment);
                _context.SaveChanges();
                stcode = "200";

            }
            catch (Exception e)
            {
                stcode = "400";
            }
            return stcode;
        }
        #endregion
    }
}
