
namespace MvcApplication1.Models
{
    public class CustomizableService: ICustomizableService
    {
        private readonly ICustomizableRepository _repository;

        public CustomizableService(ICustomizableRepository repository)
        {
            _repository = repository;
        }
        public CustomizedProduct Save(CustomizedProduct product)
        {
            if (_repository.IsCustomizable(product.ShortSku))
                return _repository.Save(product);
            return null;
        }
    }
}