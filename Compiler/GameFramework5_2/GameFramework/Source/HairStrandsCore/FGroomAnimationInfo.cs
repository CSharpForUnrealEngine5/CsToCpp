#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomCacheData.h")]
///<summary>Relevant information about a groom animation</summary>
public partial struct FGroomAnimationInfo {
// GroomAnimationInfo
	public uint NumFrames;
	public float SecondsPerFrame;
	public float Duration;
	public float StartTime;
	public float EndTime;
	public int StartFrame;
	public int EndFrame;
	public EGroomCacheAttributes Attributes;
}
