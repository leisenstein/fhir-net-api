﻿/* 
 * Copyright (c) 2015, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Support;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Fhir.FhirPath
{
    internal class ConstantFhirPathValue : IFhirPathValue
    {
        public ConstantFhirPathValue(object value)
        {
            Value = value;
        }

        public object Value
        {
            get; private set;
        }
    }
}
