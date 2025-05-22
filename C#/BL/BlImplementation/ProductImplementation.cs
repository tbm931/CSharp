using BlApi;
using BO;
using static BO.Tools;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
    {
        private readonly DalApi.IDal _dal = DalApi.Factory.Get;

        public List<BO.SaleInProduct>? AllRelevantSales(int productId, bool isPreffered)
        //return all the sales in force, for this product
        {
            Product thisP=Read(productId);
            return [.. _dal.Sale.ReadAll(sale => sale.ProdId == productId && (sale.IsToAll == true || isPreffered) && DateTime.Now >= sale.Begin && DateTime.Now <= sale.Finish).Select(s => s!.CastSaleFromDOToBO().CastFromSaleToSaleInOrder()).OrderBy(s => s.Price / s.Count)];
        }

        public int Create(BO.Product item)
        {
            try
            {
                return _dal.Product.Create(item.CastProductFromBOToDO());
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
                _dal.Product.Delete(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }       

        public BO.Product Read(int id)
        {
            try
            {
                return _dal.Product.Read(id)!.CastProductFromDOToBO();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(prod => filter(prod.CastProductFromDOToBO()))!.CastProductFromDOToBO();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        } 

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {
                Func<DO.Product, bool>? filterDO = filter == null ? null : (p => filter(p.CastProductFromDOToBO()));
                return [.. _dal.Product.ReadAll(filterDO).Select(p => p!.CastProductFromDOToBO())];
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Update(BO.Product item)
        {
            try
            {
                _dal.Product.Update(item!.CastProductFromBOToDO());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
