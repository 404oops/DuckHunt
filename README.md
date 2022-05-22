# DuckHunt.NET

## Again, since this is a school project, localization is Serbian. It's up to you to change the code to fit your localization though. The UI is easy enough to understand, so language shouldn't be a problem

A small school project I (mostly) made because a surgery forced me to stay home. Communicating with my teammates isn't easy this way and since they can't learn anything from this experience, I took it upon myself to finish this.

Duck Hunt generally is a game made for the NES systems and the main point is shooting a moving target.

*if nintendo takes this down for DMCA I'd have no words.*

This edition of the game has 3 modes:

1. Easy
2. Hard
3. Carnage

The hard mode is just a faster version of the easy mode, meanwhile the Carnage mode is just the bird absolutely flying everywhere, with its positionj being absolutely random.

Upon clicking on the label enough (should be 5-6 times, do it slowly since winforms won't register your clicks properly (it sucks)) the credits screen will show up.

I made sure to add an extra "You beat the game!" text if you click on the bird in Carnage mode (should be easy enough if you spamclick in one place) and increase the points to the highest `long` number C# can take.

# Building

This is a simple WinForms app which uses no external NuGET packages. Meaning that your standard .NET Desktop Development package in Visual Studio 2022 is enough to build this. An unmodified installation will be just fine to build this.

I'm not sure why I'm putting build instructions on this repo since it's pretty easy to git-clone-then-build on VS 2022.
