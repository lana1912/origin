﻿int max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2> result) result = arg2;
    if (arg3>result) result = arg3;
    return result;

}

int max1 = max(a1, b1, c1);
