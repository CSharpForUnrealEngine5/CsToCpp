#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JumpFloodComponent2D.h")]
public partial class UJumpFloodComponent2D : UActorComponent {
// JumpFloodComponent2D
	public  bool CreateMIDs() { return default; }
	public  void AssignRenderTargets(UTextureRenderTarget2D InRTA,UTextureRenderTarget2D InRTB) {}
	public  void JumpFlood(UTextureRenderTarget2D SeedRT,float SceneCaptureZ,FLinearColor Curl,bool UseDepth,float ZxLocationT) {}
	public  UTextureRenderTarget2D SingleJumpStep() { return default; }
	public  UTextureRenderTarget2D FindEdges(UTextureRenderTarget2D SeedRT,float CaptureZ,FLinearColor Curl,bool UseDepth,float ZxLocationT) { return default; }
	public  void FindEdges_Debug(UTextureRenderTarget2D SeedRT,float CaptureZ,FLinearColor Curl,UTextureRenderTarget2D DestRT,float ZOffset) {}
	public  UTextureRenderTarget2D SingleBlurStep() { return default; }
	public UMaterialInterface JumpStepMaterial;
	public UMaterialInterface FindEdgesMaterial;
	public UMaterialInterface BlurEdgesMaterial;
	public bool UseBlur;
	public int BlurPasses;
	public UTextureRenderTarget2D RTA;
	public UTextureRenderTarget2D RTB;
	public UMaterialInstanceDynamic JumpStepMID;
	public UMaterialInstanceDynamic FindEdgesMID;
	public UMaterialInstanceDynamic BlurEdgesMID;
	public int RequiredPasses;
	public int CompletedPasses;
	public int CompletedBlurPasses;
}
