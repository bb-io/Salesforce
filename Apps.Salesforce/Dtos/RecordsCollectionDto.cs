﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Salesforce.Crm.Dtos
{
    public class RecordsCollectionDto<T>
    {
        public IEnumerable<T> Records { get; set; }
    }
}
