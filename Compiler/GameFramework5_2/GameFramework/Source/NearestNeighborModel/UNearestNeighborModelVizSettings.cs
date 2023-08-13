namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The vizualization settings specific to the the vertex delta model.</summary>
[CppInclude("NearestNeighborModelVizSettings.h")]
public partial class UNearestNeighborModelVizSettings : UMLDeformerMorphModelVizSettings {
	public static UClass StaticClass() {return default;}
	///<summary>NearestNeighborActorsOffset</summary>
	public float NearestNeighborActorsOffset;
	///<summary>NearestNeighborIds</summary>
	public TArray<uint> NearestNeighborIds;
}
