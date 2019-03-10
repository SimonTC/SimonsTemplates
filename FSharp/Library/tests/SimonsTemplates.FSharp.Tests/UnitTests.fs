namespace SimonsTemplates.FSharp.Tests
open SimonsTemplates.FSharp
open NUnit.Framework

[<TestFixture>]
type UnitTests () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.``Test is passing`` () =
        Assert.DoesNotThrow (fun () ->Say.hello "world")
