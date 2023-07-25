#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("JumpFloodComponent2D.h")]
public partial class UJumpFloodComponent2D : UActorComponent {
// JumpFloodComponent2D
	public bool CreateMIDs() { return default; }
	public void AssignRenderTargets(UObject InRTA,UObject InRTB) {}
	public void JumpFlood(UObject SeedRT,float SceneCaptureZ,FLinearColor Curl,bool UseDepth,float ZxLocationT) {}
	public UObject SingleJumpStep() { return default; }
	public UObject FindEdges(UObject SeedRT,float CaptureZ,FLinearColor Curl,bool UseDepth,float ZxLocationT) { return default; }
	public void FindEdges_Debug(UObject SeedRT,float CaptureZ,FLinearColor Curl,UObject DestRT,float ZOffset) {}
	public UObject SingleBlurStep() { return default; }
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
