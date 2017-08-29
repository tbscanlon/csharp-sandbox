# Csharp Sandbox
A sandbox repo for learning and playing around with c#. Pretty much anything I've written here is solely for learning purposes.

## Observations
- As a compiled language, there is obviously significant differences between c# and interpreted languages like Ruby or JS. Speed is the obvious one; identical programs will run quicker as compiled c# compared to JS, for example, because there's no interpreter that needs to convert the human-readable code into machine code at runtime.
- The `dotnet new` and `dotnet run` commands that come with .NET Core seem to blur the lines between compiled and interpreted code. Pretty cool.
- Even though .NET Core was open-sourced by MS a while back and they now officially support Linux, it still feels like a second class citizen (especially compared to Windows). This is to be expected in my opinion, and from my extremely limited experience with VS Code it seems to do a pretty good job as a c# IDE on Linux.
- Having to wait for compilation before running code is annoying.
- I was concerned that fixed size arrays would be burdensome after using Ruby & JS so long. Lists seem to side-step this problem.