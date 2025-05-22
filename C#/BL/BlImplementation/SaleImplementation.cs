using BlApi;
using static BO.Tools;

namespace BlImplementation
{
    internal class SaleImplementation: ISale
    {
        private readonly DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale item)
        {
            try
            {
                return _dal.Sale.Create(item.CastSaleFromBOToDO());
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
                _dal.Sale.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        } 

        public BO.Sale Read(int id)
        {
            try
            {
                return _dal.Sale.Read(id)!.CastSaleFromDOToBO();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(sale => filter(sale.CastSaleFromDOToBO()))!.CastSaleFromDOToBO();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }        

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {
                Func<DO.Sale, bool>? filterDO = filter == null ? null : (p => filter(p.CastSaleFromDOToBO()));
                return [.. _dal.Sale.ReadAll(filterDO).Select(p => p!.CastSaleFromDOToBO())];
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }        

        public void Update(BO.Sale item)
        {
            try
            {
                _dal.Sale.Update(item.CastSaleFromBOToDO());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
