﻿#pragma once

namespace TestWindowsRuntimeComponent
{
    public ref class Class1 sealed
    {
    public:
        Class1();

        int Add(int a, int b)
        {
            return a + b;
        }
    };
}
