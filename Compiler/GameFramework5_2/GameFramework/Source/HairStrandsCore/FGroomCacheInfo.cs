namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about the GroomCache itself</summary>
[CppInclude("GroomCacheData.h")]
public partial struct FGroomCacheInfo {
	public int Version;
	public EGroomCacheType Type;
	public FGroomAnimationInfo AnimationInfo;
}
