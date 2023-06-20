using ApplySys.MVC.Contracts;
using Hanssens.Net;

namespace ApplySys.MVC.Services
{
    public class LocalStorageService : ILocalStorageService
    {
        private LocalStorage _storage;

        public LocalStorageService()
        {
            var config = new LocalStorageConfiguration()
            {
                AutoLoad = true,
                AutoSave = true,
                Filename = "Applys"
            };
            _storage = new LocalStorage(config);
        }

        public void ClearStorage(List<string> storageIds)
        {
            foreach (var storageId in storageIds)
            {
                _storage.Remove(storageId);
            }
        }

        public bool Exists(string storageId)
        {
            return _storage.Exists(storageId);
        }

        public T GetStorageValue<T>(string storageId)
        {
            return _storage.Get<T>(storageId);
        }

        public void SetStorageValue<T>(string key, T value)
        {
            _storage.Store(key, value);
            _storage.Persist();
        }
    }
}
