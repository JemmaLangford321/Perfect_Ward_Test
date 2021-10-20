# Perfect_Ward_Test

to build and run, assuming you have VS 2019 installed 
+ clone repo 
+ open solution `PerfectWardChallenge.sln`
+ once the solution is loaded right click the solution node and select restore Nuget Packages
+ open test explorer 
+ build solution 
+ once test have been discovered 
  + right click PrefectWardChallenge test node 
  + Select Run

## Appraoch

+ converted the test description in to BDDD Gherkin format
+ created a Page Object infrastructure to module the site
+ implemented steps and assertions 

 

## Improvements 
+ move hardcoded URL into configuration
+ refactor redundant code