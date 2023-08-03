#pragma warning disable CS8618,CS8603,CS1587,CS1591
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
