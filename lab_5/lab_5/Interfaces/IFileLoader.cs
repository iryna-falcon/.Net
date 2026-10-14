using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5.Interfaces
{
    public interface IFileLoader
    {
        Task<List<T>?> LoadAsync<T>(string filePath);
    }
}
