#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>For each static mesh to process, retessellate the mesh if the object contains the required data</summary>
[CppInclude("DataprepTessellationOperation.h")]
public partial class UDataprepTessellationOperation : UDataprepOperation {
	///<summary>Maximum distance between any generated triangle and the original surface. Smaller values make more triangles.</summary>
	public float ChordTolerance;
	///<summary>Maximum length of any edge in the generated triangles. Smaller values make more triangles.</summary>
	public float MaxEdgeLength;
	///<summary>Maximum angle between adjacent triangles. Smaller values make more triangles.</summary>
	public float NormalTolerance;
	///<summary>Version 4.24 : Deprecated - not serialized anymore</summary>
	public FDatasmithTessellationOptions TessellationSettings_DEPRECATED;
}
