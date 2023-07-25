#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepTessellationOperation.h")]
///<summary>For each static mesh to process, retessellate the mesh if the object contains the required data</summary>
public partial class UDataprepTessellationOperation : UDataprepOperation {
// DataprepTessellationOperation
	public float ChordTolerance;
	public float MaxEdgeLength;
	public float NormalTolerance;
	public FDatasmithTessellationOptions TessellationSettings_DEPRECATED;
}
