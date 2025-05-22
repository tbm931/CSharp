using BlApi;
using static BO.Tools;

namespace BlImplementation
{
    internal class CustomerImplementation : ICustomer
    {
        private readonly DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            try
            {
                return _dal.Customer.Create(item.CastCustomerFromBOToDO());
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public BO.Customer Read(int id)
        {
            try
            {
                return _dal.Customer.Read(id)!.CastCustomerFromDOToBO();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public BO.Customer? Read(Func<BO.Customer, bool> filter)
        {
            try
            {
                return _dal.Customer.Read(doCustomer => filter(doCustomer.CastCustomerFromDOToBO()))!.CastCustomerFromDOToBO();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                Func<DO.Customer, bool>? filterDO = filter == null ? null : (p => filter(p.CastCustomerFromDOToBO()));
                return [.. _dal.Customer.ReadAll(filterDO).Select(p => p!.CastCustomerFromDOToBO())];
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Update(BO.Customer item)
        {
            try
            {
                _dal.Customer.Update(item.CastCustomerFromBOToDO());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _dal.Customer.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool IsExist(int id)
        {
            try
            {
                DO.Customer? c = _dal.Customer.Read(cust => cust.Id == id);
                return !(c == null);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
    }
}
