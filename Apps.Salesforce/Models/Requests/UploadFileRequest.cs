﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Salesforce.Crm.Models.Requests
{
    public class UploadFileRequest
    {
        public byte[] File { get; set; }

        public string Filename { get; set; }

        public string Title { get; set; }
    }
}
