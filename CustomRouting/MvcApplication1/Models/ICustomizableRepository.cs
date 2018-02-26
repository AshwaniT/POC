
namespace MvcApplication1.Models
{
   public interface ICustomizableRepository
    {
        bool IsCustomizable(string sku);
        CustomizedProduct Save(CustomizedProduct product);
    }
}
