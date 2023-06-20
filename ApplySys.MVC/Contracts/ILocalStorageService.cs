namespace ApplySys.MVC.Contracts
{
    public interface ILocalStorageService
    {
        void ClearStorage(List<string> storageIds);
        bool Exists(string storageId);
        T GetStorageValue<T>(string storageId);
        void SetStorageValue<T>(string key, T value);
    }
}
