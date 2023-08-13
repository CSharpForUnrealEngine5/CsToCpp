namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contains an animation sequence of sprite frames</summary>
[CppInclude("PaperFlipbook.h")]
public partial class UPaperFlipbook : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The nominal frame rate to play this flipbook animation back at</summary>
	public float FramesPerSecond;
	///<summary>The set of key frames for this flipbook animation (each one has a duration and a sprite to display)</summary>
	public TArray<FPaperFlipbookKeyFrame> KeyFrames;
	///<summary>The material to use on a flipbook player instance if not overridden</summary>
	public UMaterialInterface DefaultMaterial;
	///<summary>Collision source</summary>
	public EFlipbookCollisionMode CollisionSource;
	///<summary>Returns the total number of frames</summary>
	public int GetNumFrames() { return default; }
	///<summary>Returns the total duration in seconds</summary>
	public float GetTotalDuration() { return default; }
	///<summary>Returns the keyframe index that covers the specified time (in seconds), or INDEX_NONE if none exists.</summary>
	public int GetKeyFrameIndexAtTime(float Time,bool bClampToEnds/*=false*/) { return default; }
	///<summary>Returns the sprite at the specified time (in seconds), or nullptr if none exists.</summary>
	public UPaperSprite GetSpriteAtTime(float Time,bool bClampToEnds/*=false*/) { return default; }
	///<summary>Returns the sprite at the specified keyframe index, or nullptr if none exists</summary>
	public UPaperSprite GetSpriteAtFrame(int FrameIndex) { return default; }
	///<summary>Returns the number of key frames</summary>
	public int GetNumKeyFrames() { return default; }
	///<summary>Is the specified Index within the valid range of key frames?</summary>
	public bool IsValidKeyFrameIndex(int Index) { return default; }
}
