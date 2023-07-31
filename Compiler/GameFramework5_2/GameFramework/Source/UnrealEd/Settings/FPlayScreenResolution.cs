#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds information about a screen resolution to be used for playing.</summary>
[CppInclude("Settings/LevelEditorPlaySettings.h")]
public partial struct FPlayScreenResolution {
	public string Description;
	public int Width;
	public int Height;
	public string AspectRatio;
	public bool bCanSwapAspectRatio;
	public string ProfileName;
	public float ScaleFactor;
	public int LogicalHeight;
	public int LogicalWidth;
}
