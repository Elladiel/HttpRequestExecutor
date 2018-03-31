﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpExecutor.Design
{
    public interface IResponseDeserializer
    {
        Task<T> Deserialize<T>(HttpResponseMessage response);
    }
}
