#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepOperations.h")]
///<summary>For each static mesh to process, enables/disables Nanite build and if enabled update settings.</summary>
public partial class UDataprepSetNaniteSettingsOperation : UDataprepOperation {
// DataprepSetNaniteSettingsOperation
	public bool bNaniteEnabled;
	public int PositionPrecision;
	public float PercentTriangles;
}
