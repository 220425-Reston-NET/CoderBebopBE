using CoderBebopModel;

namespace CoderBebopDL
{
    public interface iCoderBebopDL<T>
    {
        void AddCus(T p_resource);

        void AddJoin(T p_resource);

        void AddPin(T p_resource);

        List<Customer> GetAll();

        void verify(decimal p_resource, int p_resource1);
    }
}