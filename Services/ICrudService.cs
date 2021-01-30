﻿using System;
using System.Collections.Generic;

namespace FlowersStore.Services
{
    public interface ICRUDService<T> where T : class
    {
        IEnumerable<T> Get(Guid id);
        T GetById(Guid id);
        bool Create(T model);
        bool Update(T model);
        bool Update(IEnumerable<T> collection);
        bool Delete(Guid id);
    }
}
