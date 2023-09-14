namespace EfCore8Tests.Models
{
    public abstract class BaseCompanyIdentificationData<T>
    {
        public T Clone()
        {
            return (T)MemberwiseClone();
        }
    }
}
