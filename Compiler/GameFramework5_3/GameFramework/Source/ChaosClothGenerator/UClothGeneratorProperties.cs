namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ClothGeneratorProperties.h")]
public partial class UClothGeneratorProperties : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Skeletal mesh that will be used in MLDeformer</summary>
	public USkinnedAsset SkeletalMeshAsset;
	///<summary>Chaos cloth asset used in simulation. This should be different from the skeletal mesh asset.</summary>
	public UChaosClothAsset ClothAsset;
	///<summary>Training poses.</summary>
	public UAnimSequence AnimationSequence;
	///<summary>e.g. &quot;0, 2, 5-10, 12-15&quot;. If left empty, all frames will be used</summary>
	public string FramesToSimulate;
	///<summary>Output meshes</summary>
	public UGeometryCache SimulatedCache;
	///<summary>Debug a single pose</summary>
	public bool bDebug;
	///<summary>The frame to inspect</summary>
	public uint DebugFrame;
	///<summary>The output sequence</summary>
	public UGeometryCache DebugCache;
	///<summary>TimeStep</summary>
	public float TimeStep;
	///<summary>NumSteps</summary>
	public int NumSteps;
	///<summary>NumThreads</summary>
	public int NumThreads;
}
