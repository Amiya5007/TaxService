﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator.Dispather
{
    public interface IDispatcher<T> where T : ICommand
    {
        Task Send(T Command);
    }
}
