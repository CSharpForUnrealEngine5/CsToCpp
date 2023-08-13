namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A 4x4 matrix.</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FMatrix44f {
	public FPlane4f XPlane;
	public FPlane4f YPlane;
	public FPlane4f ZPlane;
	public FPlane4f WPlane;
}
