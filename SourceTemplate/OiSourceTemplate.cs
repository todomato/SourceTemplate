using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace SourceTemplate
{
    public static class OiSourceTemplate
    {
        [SourceTemplate]
        [Macro(Target = "expected", Editable = 1)]
        public static void ff<T>(this IEnumerable<T> x)
        {
            /*$for (int i = 0; i < $expected$; i++)
            {
                x;
            }*/
        }
        [SourceTemplate]
        public static void re(this string x)
        {
            //$return x;
        }
        [SourceTemplate]
        public static void r(this string x)
        {
            //$return x;
        }
    }
  
}
