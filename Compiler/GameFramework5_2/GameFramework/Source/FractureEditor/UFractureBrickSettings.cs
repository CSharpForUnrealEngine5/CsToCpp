#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolBrick.h")]
public partial class UFractureBrickSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The brick bond pattern defines how the bricks are arranged</summary>
	public EFractureBrickBond Bond;
	///<summary>Brick length (in cm)</summary>
	public float BrickLength;
	///<summary>Brick height (in cm)</summary>
	public float BrickHeight;
	///<summary>Brick depth (in cm)</summary>
	public float BrickDepth;
}
