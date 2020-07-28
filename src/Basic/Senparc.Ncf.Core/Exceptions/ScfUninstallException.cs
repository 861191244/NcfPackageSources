﻿using Senparc.Ncf.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Ncf.Core
{
    /// <summary>
    /// NCF 未安装
    /// </summary>
    public class NcfUninstallException : NCFExceptionBase
    {
        public NcfUninstallException(string message, bool logged = false) : base(message, logged)
        {
        }
    }
}
