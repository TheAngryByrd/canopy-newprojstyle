open System
open Expecto
open canopy
open OpenQA.Selenium

[<EntryPoint>]
let main args =
    start chrome
    let exitcode = runTestsInAssembly defaultConfig args
    quit()
    
    exitcode
