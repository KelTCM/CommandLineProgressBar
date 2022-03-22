This wasn't originally intended to be publically availible, so it's not intended to be read normally, but here's some info about this
# Which version to download
For most cases, download ProgressBar.cs as per it being slightly less bloated, both are NOT intended for the same project.
# Documentation
To make a progress bar, make a variable under the type ProgressBar (If your using the version with the easter egg, it's ProgressBarWithEE,  
and declare it as a ProgressBar with this constructor:  
public ProgressBar(int length, int StartingProgress)  
  
How to use:  
The default character to label the end of the bar is |, if you want to change it, use this  
public void ProgressBar.ChangeEndChar(char NewChar)  
  
It at this state will always be at the top of the command line, this is not great for all cases, to change the Y position, run this:  
public void ProgressBar.MoveProgressBar(int NewY)  
  
Now to actually, set the progress on the progress bar, there are 2 ways to do this  
1: You can manually set the exact value, if you want to make the value go down, this is the only way  
public bool ProgressBar.ChangePercentageValue(int NewPercentageValue)  
2: You can also increment the value  
public bool ProgressBar.IncreaseProgress(int amount)  
  
Those both return boolean values stating weather or not it's at 100%  
