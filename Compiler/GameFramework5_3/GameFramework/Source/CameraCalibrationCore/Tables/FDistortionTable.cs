namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distortion table containing list of points for each focus and zoom input</summary>
[CppInclude("Tables/DistortionParametersTable.h")]
public partial struct FDistortionTable {
	public TArray<FDistortionFocusPoint> FocusPoints;
}
