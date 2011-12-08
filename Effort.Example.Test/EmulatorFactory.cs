﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Effort.Example.Models;

namespace Effort.Example.Test
{
    public static class EmulatorFactory
    {
        public static Type Create()
        {
            string baseDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".\\..\\..\\..\\Effort.Example.Test\\Data");

            return ObjectContextFactory.CreateEmulator<NorthwindEntities>(baseDir, false);
        }
    }
}