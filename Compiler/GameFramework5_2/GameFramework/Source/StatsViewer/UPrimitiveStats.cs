#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PrimitiveStats.h")]
///<summary>Statistics page for primitives.</summary>
public partial class UPrimitiveStats : UObject {
// PrimitiveStats
	public TWeakObjectPtr<UObject> Object;
	public TArray<TWeakObjectPtr<AActor>> Actors;
	public string Type;
	public int Count;
	public int Sections;
	public int HWInstances;
	public int InstSections;
	public int Triangles;
	public int InstTriangles;
	public float ResourceSize;
	public float VertexColorMem;
	public float InstVertexColorMem;
	public int LightsLM;
	public float LightsOther;
	public float LightsTotal;
	public float ObjLightCost;
	public float LightMapData;
	public float LMSMResolution;
	public double RadiusMin;
	public double RadiusMax;
	public double RadiusAvg;
}
