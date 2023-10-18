namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JumpFloodComponent2D.h")]
public partial class UJumpFloodComponent2D : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>CreateMIDs</summary>
	public virtual bool CreateMIDs() { return default; }
	///<summary>AssignRenderTargets</summary>
	public void AssignRenderTargets(UTextureRenderTarget2D InRTA,UTextureRenderTarget2D InRTB) {}
	///<summary>JumpFlood</summary>
	public void JumpFlood(UTextureRenderTarget2D SeedRT,float SceneCaptureZ,FLinearColor Curl,bool UseDepth,float ZxLocationT) {}
	///<summary>SingleJumpStep</summary>
	public UTextureRenderTarget2D SingleJumpStep() { return default; }
	///<summary>FindEdges</summary>
	public UTextureRenderTarget2D FindEdges(UTextureRenderTarget2D SeedRT,float CaptureZ,FLinearColor Curl,bool UseDepth,float ZxLocationT) { return default; }
	///<summary>FindEdges_Debug</summary>
	public void FindEdges_Debug(UTextureRenderTarget2D SeedRT,float CaptureZ,FLinearColor Curl,UTextureRenderTarget2D DestRT,float ZOffset) {}
	///<summary>SingleBlurStep</summary>
	public UTextureRenderTarget2D SingleBlurStep() { return default; }
	///<summary>JumpStepMaterial</summary>
	public UMaterialInterface JumpStepMaterial;
	///<summary>FindEdgesMaterial</summary>
	public UMaterialInterface FindEdgesMaterial;
	///<summary>BlurEdgesMaterial</summary>
	public UMaterialInterface BlurEdgesMaterial;
	///<summary>UseBlur</summary>
	public bool UseBlur;
	///<summary>BlurPasses</summary>
	public int BlurPasses;
	///<summary>RTA</summary>
	public UTextureRenderTarget2D RTA;
	///<summary>RTB</summary>
	public UTextureRenderTarget2D RTB;
	///<summary>Transient properties (exposed only for debugging reasons) :</summary>
	public UMaterialInstanceDynamic JumpStepMID;
	///<summary>FindEdgesMID</summary>
	public UMaterialInstanceDynamic FindEdgesMID;
	///<summary>BlurEdgesMID</summary>
	public UMaterialInstanceDynamic BlurEdgesMID;
	///<summary>RequiredPasses</summary>
	public int RequiredPasses;
	///<summary>CompletedPasses</summary>
	public int CompletedPasses;
	///<summary>CompletedBlurPasses</summary>
	public int CompletedBlurPasses;
}
