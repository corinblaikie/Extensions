// include Fake lib
#r "packages/FAKE/tools/FakeLib.dll"
open Fake
open Fake.FixieHelper

RestorePackages()

// Properties
let buildDir = "./build/"

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir]
)

Target "BuildApp" (fun _ ->
   !! "*.sln"
     |> MSBuildRelease buildDir "Build"
     |> Log "AppBuild-Output: "
)

Target "Test" (fun _ ->
    !! (buildDir + "*.Tests.dll")
     |> Fixie (fun p -> { p with CustomOptions = [] })
)

Target "Default" (fun _ ->
    trace "Hello World from FAKE"
)

// Dependencies
"Clean"
  ==> "BuildApp"
  ==> "Test"
  ==> "Default"

// Start build
RunTargetOrDefault "Default"