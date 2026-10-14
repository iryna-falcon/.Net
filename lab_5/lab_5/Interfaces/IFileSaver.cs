using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5.Interfaces
{
    public interface IFileSaver
    {
        Task SaveAsync<T>(string filePath, List<T> data);
    }
}
