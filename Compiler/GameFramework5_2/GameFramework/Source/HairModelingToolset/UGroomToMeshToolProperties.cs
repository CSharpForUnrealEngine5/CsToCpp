namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomToMeshTool.h")]
public partial class UGroomToMeshToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>The size of the geometry bounding box major axis measured in voxels</summary>
	public int VoxelCount;
	///<summary>BlendPower</summary>
	public float BlendPower;
	///<summary>RadiusScale</summary>
	public float RadiusScale;
	///<summary>bApplyMorphology</summary>
	public bool bApplyMorphology;
	///<summary>ClosingDist</summary>
	public float ClosingDist;
	///<summary>OpeningDist</summary>
	public float OpeningDist;
	///<summary>bClipToHead</summary>
	public bool bClipToHead;
	///<summary>todo: this probably also needs to support skeletal mesh</summary>
	public TLazyObjectPtr<AStaticMeshActor> ClipMeshActor;
	///<summary>bSmooth</summary>
	public bool bSmooth;
	///<summary>Smoothness</summary>
	public float Smoothness;
	///<summary>VolumeCorrection</summary>
	public float VolumeCorrection;
	///<summary>bSimplify</summary>
	public bool bSimplify;
	///<summary>Target triangle count</summary>
	public int VertexCount;
	///<summary>UVMode</summary>
	public EGroomToMeshUVMode UVMode;
	///<summary>bShowSideBySide</summary>
	public bool bShowSideBySide;
	///<summary>bShowGuides</summary>
	public bool bShowGuides;
	///<summary>bShowUVs</summary>
	public bool bShowUVs;
}
