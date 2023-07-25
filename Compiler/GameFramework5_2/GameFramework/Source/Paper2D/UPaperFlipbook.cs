#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperFlipbook.h")]
///<summary>Contains an animation sequence of sprite frames</summary>
public partial class UPaperFlipbook : UObject {
// PaperFlipbook
	public float FramesPerSecond;
	public TArray<FPaperFlipbookKeyFrame> KeyFrames;
	public UMaterialInterface DefaultMaterial;
	public byte CollisionSource;
	public int GetNumFrames() { return default; }
	public float GetTotalDuration() { return default; }
	public int GetKeyFrameIndexAtTime(float Time,bool bClampToEnds/*=false*/) { return default; }
	public UObject GetSpriteAtTime(float Time,bool bClampToEnds/*=false*/) { return default; }
	public UObject GetSpriteAtFrame(int FrameIndex) { return default; }
	public int GetNumKeyFrames() { return default; }
	public bool IsValidKeyFrameIndex(int Index) { return default; }
}
