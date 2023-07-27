#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimationTrackSetNode.h")]
///<summary>Class to represent a set of animation track nodes sharing the same frame rate</summary>
public partial class UInterchangeAnimationTrackSetNode : UInterchangeBaseNode {
// InterchangeAnimationTrackSetNode
	public  int GetCustomAnimationTrackUidCount() { return default; }
	public  void GetCustomAnimationTrackUids(TArray<string> OutAnimationTrackUids) {}
	public  void GetCustomAnimationTrackUid(int Index,string OutAnimationTrackUid) {}
	public  bool AddCustomAnimationTrackUid(string AnimationTrackUid) { return default; }
	public  bool RemoveCustomAnimationTrackUid(string AnimationTrackUid) { return default; }
	public  bool SetCustomFrameRate(float AttributeValue) { return default; }
	public  bool GetCustomFrameRate(float AttributeValue) { return default; }
}
