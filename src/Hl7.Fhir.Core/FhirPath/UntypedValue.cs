﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Fhir.FhirPath
{
    public class UntypedValue
    {
        public string Representation { get; private set; }
        public UntypedValue(string representation)
        {
            Representation = representation;
        }
    }
}
