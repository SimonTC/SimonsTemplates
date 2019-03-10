// Load dotnet standard to make sure we can interact with code based on this.
// The FSI runs on dotnet framework so by default it cannot interact with dotnet standard code.
#r "../../packages/scripting/NETStandard.Library/build/netstandard2.0/ref/netstandard.dll"

#load "Library.fs"

open SimonsTemplates.FSharp

Say.hello "world" 

