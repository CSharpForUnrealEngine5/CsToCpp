namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCrowdServerRepresentationLODProcessor.h")]
public partial class UMassCrowdServerRepresentationLODProcessor : UMassProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>Distance where each LOD becomes relevant</summary>
	public float LODDistance;
	///<summary>Hysteresis percentage on delta between the LOD distances</summary>
	public float BufferHysteresisOnDistancePercentage;
	///<summary>Maximum limit of entity per LOD</summary>
	public int LODMaxCount;
}
