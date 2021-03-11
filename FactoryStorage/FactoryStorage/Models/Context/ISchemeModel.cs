﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryStorage.Models.Context
{
    public interface ISchemeModel
    {
        string Topic { get; set; }

        string Description { get; set; }

        List<StorageModel> Elements { get; set; }
    }
}
