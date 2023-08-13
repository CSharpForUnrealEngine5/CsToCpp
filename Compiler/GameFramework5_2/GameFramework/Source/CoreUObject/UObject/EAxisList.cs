namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UObject/NoExportTypes.h")]
///<summary>Generic axis list enum (mirrored for native use in Axis.h).</summary>
[CppEnumInNamespace]
public enum EAxisList {
	None=0,
	X=1,
	Y=2,
	Z=4,
	Screen=8,
	XY=-1,
	XZ=-1,
	YZ=-1,
	XYZ=-1,
	All=-1,
	ZRotation=-1,
	Rotate2D=-1,
}
