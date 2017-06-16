namespace UITests

module Stackoverflow =
    open canopy
    open Expecto

    [<Tests>]
    let uiTests = 
        testList "Stackoverflowtests" [
            testCase "Foo" <| fun () ->
                url "https://stackoverflow.com/"
                "h1#h-top-questions" == "Top Questions"
        ]