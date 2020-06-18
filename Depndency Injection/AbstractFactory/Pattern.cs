using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{

    abstract class PayementStrategy
    {     
        public abstract void GetPayementForProduct();
    }



    class PhysicalProduct : PayementStrategy

    {
        public override void GetPayementForProduct()
        {
            Console.WriteLine(
              "Receive payemnt for the Product");
        }
        public void GeneraratepackingSlip()
        {
            Console.WriteLine(
             "Generate packing Slip");
        }
    }







    public interface IRepository<TEntity> where TEntity : class
    {              void GetPayementForProduct(TEntity entity);
        
    }




    public interface IphysicalProduct<TEntity> where TEntity : class
    {

        string GaneratepackingSlip();
        string CreateDuplicatePakingSlip();
    }
    public interface IDigitalroduct<TEntity> where TEntity : class
    {

        string UpdateMembership();
        string ActivateupdateMembership();

    }
    class Pattern
    {
    }
}
