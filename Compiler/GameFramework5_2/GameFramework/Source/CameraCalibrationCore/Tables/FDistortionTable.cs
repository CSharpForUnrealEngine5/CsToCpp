#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Distortion table containing list of points for each focus and zoom input</summary>
[CppInclude("Tables/DistortionParametersTable.h")]
public partial struct FDistortionTable {
	public TArray<FDistortionFocusPoint> FocusPoints;
}
