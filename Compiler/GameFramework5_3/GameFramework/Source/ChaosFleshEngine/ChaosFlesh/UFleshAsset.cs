namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UFleshAsset (UObject)</summary>
[CppInclude("ChaosFlesh/FleshAsset.h")]
public partial class UFleshAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Dataflow</summary>
	public UDataflow DataflowAsset;
	///<summary>DataflowTerminal</summary>
	public string DataflowTerminal;
	///<summary>Overrides</summary>
	public TArray<FStringValuePair> Overrides;
	///<summary>SkeletalMesh</summary>
	public USkeletalMesh SkeletalMesh;
	///<summary>Skeleton</summary>
	public USkeleton Skeleton;
	///<summary>Skeleton to use with the flesh deformer or \c GetSkeletalMeshEmbeddedPositions() on the flesh component.</summary>
	public USkeletalMesh TargetDeformationSkeleton;
	///<summary>SkeletalMesh</summary>
	public UStaticMesh StaticMesh;
	///<summary>bRenderInEditor</summary>
	public bool bRenderInEditor;
	///<summary>Information for thumbnail rendering</summary>
	public UThumbnailInfo ThumbnailInfo;
}
