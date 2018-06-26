﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace BasicWebSite.Models
{
    public class DerivedPerson : Person, IPerson
    {
        [Required]
        [StringLength(10)]
        public string DerivedProperty { get; set; }
    }
}
