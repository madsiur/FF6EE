namespace FF6EE.Interfaces
{
    public interface IDynamicProperties
    {
        T GetValue<T>(string propertyName);
        void SetValue<T>(string propertyName, T value);
    }
}
