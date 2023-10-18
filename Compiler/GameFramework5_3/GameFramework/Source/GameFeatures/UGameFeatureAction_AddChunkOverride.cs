namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to cook assets from a GFP into a specified chunkId.</summary>
[CppInclude("GameFeatureAction_AddChunkOverride.h")]
public partial class UGameFeatureAction_AddChunkOverride : UGameFeatureAction {
	public static UClass StaticClass() {return default;}
	///<summary>Should this GFP have their packages cooked into the specified ChunkId</summary>
	public bool bShouldOverrideChunk;
	///<summary>What ChunkId to place the packages inside for this particular GFP.</summary>
	public int ChunkId;
	///<summary>Config defined value for what is the smallest chunk index the autogeneration code can generate.</summary>
	public int LowestAllowedChunkIndexForAutoGeneration;
}
