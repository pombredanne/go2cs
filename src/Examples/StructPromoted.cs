// package main -- go2cs converted at 2018 June 16 17:46:03 UTC
// Original source: C:\Projects\go2cs\src\Examples\StructPromoted.go

using fmt = go.fmt_package;

using static go.BuiltInFunctions;
using System.ComponentModel;

namespace go
{
    public static partial class main_package
    {
        public partial struct DoDad
        {
            public long I;
            public string O;
            public string["2"]["2"]["2"]["2"] a;
        }

        public partial struct Vertex
        {
            [Description("Hi")]
            public long X;
            [Description("Hi")]
            public long Y;
            public DoDad DoDad;
        }

        private static void Main() => func((defer, panic, recover) =>
        {
            v:=Vertex{1,2,DoDad{12,"Hello",[2][2]string{{"one","two"},{"three","four"}}}}v.X=4v.DoDad.O="Bye"v.a[1][0]="another"fmt.Println(v.X,v.O,v.a[1][0])
        });
    }
}