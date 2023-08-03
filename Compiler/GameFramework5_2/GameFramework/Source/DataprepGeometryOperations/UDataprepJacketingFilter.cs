#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Apply mesh jacketing to selected objects</summary>
[CppInclude("DataprepGeometryFilters.h")]
public partial class UDataprepJacketingFilter : UDataprepFilterNoFetcher {
	public static UClass StaticClass() {return default;}
	///<summary>Accuracy of the distance field approximation, in cm.</summary>
	public float VoxelPrecision;
	///<summary>Merge distance used to fill gap, in cm.</summary>
	public float GapMaxDiameter;
}
