Execution instructions:

1. Clone the solution to your local repository
2. This test solution was developed using JetBrains Rider IDE on Mac. Should work on Visual Studio on Windows as well.

To run from Windows:
 a. Go the SpecFlowlloydsbankTest directory and then look for runtests.cmd. Double click on this file.
 b. If above does not work, open the command prompt and navigate to the folder containing runtests.cmd. Then type runtests.cmd and enter
 c. From Visual Studio. Load the project folder. In the terminal type - 'dotnet test' and enter

To run from Mac:
1. load the project folder into Rider IDE 
2. Build the project
3. Go to Terminal and type 'dotnet test' and enter

Test results will be available under SpecFlowlloydsbankTest/TestResults folder. We do get log file for each run and Specrun html report. Both file names will have run timestamp appended in filename.

Notes:
1. Please go to SpecFlowlloydsbankTest/bin and delete all existing file under 'Debug' and 'Release' folder. This is especially resolves the issue if there is any issue of failing test runs due to cached test profile files and compiler files generated from previous runs/builds.
2. I am using Chrome version 100.0.4896 which is the latest one. If it is not matching with the version do you have currently, please update it to current version.