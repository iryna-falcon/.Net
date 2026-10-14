using lab_5.Interfaces;
using System.Collections.ObjectModel;

namespace lab_5.Toys
{
    public class ToyCatalog
    {
        private readonly IFileSaver _fileSaver;
        private readonly IFileLoader _fileLoader;
        private readonly string _filePath;

        public ObservableCollection<Toy> Toys { get; }
        private List<Toy> _allToys;

        public ToyCatalog(IFileSaver fileSaver, IFileLoader fileLoader, string filePath)
        {
            _fileSaver = fileSaver;
            _fileLoader = fileLoader;
            _filePath = filePath;
            Toys = new ObservableCollection<Toy>();
            _allToys = new List<Toy>();
        }

        public void AddToy(Toy toy)
        {
            Toys.Add(toy);
            _allToys.Add(toy);
        }

        public void DeleteToy(Toy toy)
        {
            if (toy != null)
            {
                Toys.Remove(toy);
                _allToys.Remove(toy);
            }
        }

        public void SortByCost()
        {
            var sorted = new List<Toy>(Toys);
            sorted.Sort();
            UpdateVisibleCollection(sorted);
        }

        public void FilterByAgeRange(int n, int m)
        {
            var filtered = _allToys.Where(t => t.MinAge >= n && t.MaxAge <= m).ToList();
            UpdateVisibleCollection(filtered);
        }

        public void ResetFilter()
        {
            UpdateVisibleCollection(_allToys);
        }

        private void UpdateVisibleCollection(List<Toy> newList)
        {
            Toys.Clear();
            foreach (var toy in newList)
            {
                Toys.Add(toy);
            }
        }

        public async Task SaveAsync()
        {
            await _fileSaver.SaveAsync(_filePath, _allToys);
        }

        public async Task LoadAsync()
        {
            var loaded = await _fileLoader.LoadAsync<Toy>(_filePath);
            if (loaded != null)
            {
                _allToys = loaded;
                UpdateVisibleCollection(_allToys);
            }
        }
    }
}
