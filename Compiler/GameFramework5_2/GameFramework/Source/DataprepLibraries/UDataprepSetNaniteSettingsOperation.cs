#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, enables/disables Nanite build and if enabled update settings.</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetNaniteSettingsOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>If checked, Nanite data will be generated</summary>
	public bool bNaniteEnabled;
	///<summary>Step size is 2^(-PositionPrecision) cm. MIN_int32 is auto</summary>
	public int PositionPrecision;
	///<summary>Percentage of triangles to keep from LOD0. 100.0 = no reduction, 0.0 = no triangles</summary>
	public float PercentTriangles;
}
