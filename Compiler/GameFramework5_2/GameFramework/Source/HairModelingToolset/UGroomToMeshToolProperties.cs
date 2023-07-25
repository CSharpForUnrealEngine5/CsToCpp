#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomToMeshTool.h")]
public partial class UGroomToMeshToolProperties : UInteractiveToolPropertySet {
// GroomToMeshToolProperties
	public int VoxelCount;
	public float BlendPower;
	public float RadiusScale;
	public bool bApplyMorphology;
	public float ClosingDist;
	public float OpeningDist;
	public bool bClipToHead;
	public TLazyObjectPtr<AStaticMeshActor> ClipMeshActor;
	public bool bSmooth;
	public float Smoothness;
	public float VolumeCorrection;
	public bool bSimplify;
	public int VertexCount;
	public EGroomToMeshUVMode UVMode;
	public bool bShowSideBySide;
	public bool bShowGuides;
	public bool bShowUVs;
}
