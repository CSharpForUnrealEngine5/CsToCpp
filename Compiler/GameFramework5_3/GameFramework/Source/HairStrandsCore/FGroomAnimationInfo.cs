namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Relevant information about a groom animation</summary>
[CppInclude("GroomCacheData.h")]
public partial struct FGroomAnimationInfo {
	public uint NumFrames;
	public float SecondsPerFrame;
	public float Duration;
	public float StartTime;
	public float EndTime;
	public int StartFrame;
	public int EndFrame;
	public EGroomCacheAttributes Attributes;
}
