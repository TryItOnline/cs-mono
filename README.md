# C#, F#, and VB.NET Mono project files for TIO

The compiler and runtime used by the languages *C# (Visual C# Compiler)*, *C# (Mono C# Compiler)*, *F# (Mono)*, *Visual Basic .NET (Mono)*, and *Visual Basic .NET (VBC)* on TIO come from [Mono](https://www.mono-project.com/). The Visual C# Compiler is the Roslyn compiler `csc` and the Mono C# Compiler is the older `mcs`, and the Mono VB.NET compiler is the older `vbnc` compiler (`vbc` is the newer Roslyn compiler).

All of these languages are built using the `msbuild` tool, the *Compiler flags* field specifies options passed to msbuild rather than the individual compilers. Certain msbuild options may cause problems with *Visual Basic .NET (Mono)*, which uses slightly different flags from the vbc compiler msbuild is intended to work with.

Each languages uses a similar `.csproj`/`.fsproj`/`.vbproj` file. 
These project files mostly resemble the defaults created by MonoDevelop, however C# is set to use the latest language version rather than the latest *major* version, F# has tail-call optimization enabled by default, VB.NET has certain imports enabled by default to match what Visual Studio 2017 uses, and all languages have unsafe code enabled.

Additionally, the following libraries from [Nuget](https://www.nuget.org/) are available to all 3 languages:

 - CsvHelper
 - DynamicExpresso.Core
 - FParsec
 - FSharp.Core
 - MathNet.Numerics
 - MathNet.Numerics.FSharp
 - MathNet.Symbolics
 - morelinq
 - NDesk.Options
 - Newtonsoft.Json
 - Superpower
 - System.Buffers
 - System.Collections.Immutable
 - System.Dynamic.Runtime
 - System.Globalization.Calendars
 - System.Globalization.Extensions
 - System.Memory
 - System.Numerics.Vectors
 - System.ObjectModel
 - System.Runtime.CompilerServices.Unsafe
 - System.Threading.Tasks.Extensions
 - System.ValueTuple

All libraries should be up-to-date to the most recent stable build.