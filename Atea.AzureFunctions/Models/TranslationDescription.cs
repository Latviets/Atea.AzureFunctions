﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atea.AzureFunctions.Models
{
    public class TranslationDescriptor
    {
        public required string Official { get; set; }
        public required string Common { get; set; }
    }
}
