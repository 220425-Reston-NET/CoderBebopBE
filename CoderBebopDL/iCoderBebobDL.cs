using CoderBebopModel;

namespace CoderBebopDL
{
    public interface iCoderBebopDL<T>
    {
        void Add(T p_resource);

        void AddPin(T p_resource);

        List<T> GetAll();

        void verify(decimal p_resource, int p_resource1);
    }
}