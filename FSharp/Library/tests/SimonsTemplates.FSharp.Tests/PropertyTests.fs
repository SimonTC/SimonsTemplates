namespace SimonsTemplates.FSharp.Tests

open NUnit.Framework
open FsCheck.NUnit
open SimonsTemplates.FSharp

[<TestFixture>]
type PropertyTests () =

    [<Property>]
    let ``Can say all kinds of words`` (word: string) =
        Say.hello word

