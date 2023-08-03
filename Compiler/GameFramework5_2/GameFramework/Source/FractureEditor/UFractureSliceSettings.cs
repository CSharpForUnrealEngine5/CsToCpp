#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolSlice.h")]
public partial class UFractureSliceSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Number of slices along the X axis</summary>
	public int SlicesX;
	///<summary>Number of slices along the Y axis</summary>
	public int SlicesY;
	///<summary>Number of slices along the Z axis</summary>
	public int SlicesZ;
	///<summary>Maximum angle (in degrees) to randomly rotate each slicing plane</summary>
	public float SliceAngleVariation;
	///<summary>Maximum distance (in cm) to randomly shift each slicing plane</summary>
	public float SliceOffsetVariation;
}
