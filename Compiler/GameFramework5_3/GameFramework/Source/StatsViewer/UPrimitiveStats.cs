namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Statistics page for primitives.</summary>
[CppInclude("PrimitiveStats.h")]
public partial class UPrimitiveStats : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Resource (e.g. UStaticMesh, USkeletalMesh, UModelComponent, UTerrainComponent, etc</summary>
	public TWeakObjectPtr<UObject> Object;
	///<summary>Actor(s) that use the resource - click to select &amp; zoom Actor(s)</summary>
	public TArray<TWeakObjectPtr<AActor>> Actors;
	///<summary>Type name</summary>
	public string Type;
	///<summary>Number of occurrences in map</summary>
	public int Count;
	///<summary>Section count of mesh</summary>
	public int Sections;
	///<summary>Hardware instances</summary>
	public int HWInstances;
	///<summary>Instanced section count of mesh</summary>
	public int InstSections;
	///<summary>Triangle count of mesh</summary>
	public int Triangles;
	///<summary>Triangle count of all mesh occurances (Count * Tris)</summary>
	public int InstTriangles;
	///<summary>Resource size in KB</summary>
	public float ResourceSize;
	///<summary>Vertex color stat for static and skeletal meshes in KB</summary>
	public float VertexColorMem;
	///<summary>Per component vertex color stat for static meshes in KB</summary>
	public float InstVertexColorMem;
	///<summary>Average number of lightmap lights relevant to each instance</summary>
	public int LightsLM;
	///<summary>Average number of other lights relevant to each instance</summary>
	public float LightsOther;
	///<summary>(Avg OL + Avg LM) / Count</summary>
	public float LightsTotal;
	///<summary>Avg OL * Sections</summary>
	public float ObjLightCost;
	///<summary>Light map data in KB</summary>
	public float LightMapData;
	///<summary>Light/shadow map resolution</summary>
	public float LMSMResolution;
	///<summary>Minimum radius of bounding sphere of instance in map</summary>
	public double RadiusMin;
	///<summary>Maximum radius of bounding sphere of instance in map</summary>
	public double RadiusMax;
	///<summary>Average radius of bounding sphere of instance in map</summary>
	public double RadiusAvg;
}
