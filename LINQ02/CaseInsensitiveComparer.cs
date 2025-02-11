﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ02
{
    internal class CaseInsensitiveComparer: IComparer<string>
    {
        public int Compare(string x, string y)

        {

            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);

        }

    }

}
