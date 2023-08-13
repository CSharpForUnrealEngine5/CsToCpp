namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Elements/PCGSelfPruning.h")]
public partial class UPCGSelfPruningSettings : UPCGSettings {
	public static UClass StaticClass() {return default;}
	///<summary>PruningType</summary>
	public EPCGSelfPruningType PruningType;
	///<summary>RadiusSimilarityFactor</summary>
	public float RadiusSimilarityFactor;
	///<summary>bRandomizedPruning</summary>
	public bool bRandomizedPruning;
}
