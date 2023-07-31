#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The vizualization settings specific to the the vertex delta model.</summary>
[CppInclude("NearestNeighborModelVizSettings.h")]
public partial class UNearestNeighborModelVizSettings : UMLDeformerMorphModelVizSettings {
	///<summary>NearestNeighborActorsOffset</summary>
	public float NearestNeighborActorsOffset;
	///<summary>NearestNeighborIds</summary>
	public TArray<uint> NearestNeighborIds;
}
