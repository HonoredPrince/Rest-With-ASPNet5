﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.Converter.Contract
{
    public interface IParser<D, O>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
