using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);//sana key verdiğimde ban T türünde T objesi ver
        object Get(string key);
        void Add(string key, object value, int duration);//duration kaç dk duracak cachede
        bool IsAdd(string key);
        void Remove(string key);
        void RemoveByPattern(string pattern);
    }
}
