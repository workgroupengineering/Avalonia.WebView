﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjCRuntime;
[Flags]
public enum PlatformArchitecture : byte
{
    None = 0,
    Arch32 = 1,
    Arch64 = 2,
    All = byte.MaxValue
}