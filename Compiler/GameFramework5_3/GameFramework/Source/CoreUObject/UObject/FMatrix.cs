namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 4x4 matrix.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FMatrix {
	public FPlane XPlane;
	public FPlane YPlane;
	public FPlane ZPlane;
	public FPlane WPlane;
}
