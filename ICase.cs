﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Monopoly
{
    public interface ICase {

        public void GetEvenement(IJoueur j);
        public string ToString();
    }
}
