namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 4x4 matrix.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FMatrix44d {
	public FPlane4d XPlane;
	public FPlane4d YPlane;
	public FPlane4d ZPlane;
	public FPlane4d WPlane;
}
