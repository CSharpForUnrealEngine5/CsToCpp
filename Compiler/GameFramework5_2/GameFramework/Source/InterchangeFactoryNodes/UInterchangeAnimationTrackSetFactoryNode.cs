#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimationTrackSetFactoryNode.h")]
public partial class UInterchangeAnimationTrackSetFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeAnimationTrackSetFactoryNode
	public  UClass GetObjectClass() { return default; }
	public  int GetCustomAnimationTrackUidCount() { return default; }
	public  void GetCustomAnimationTrackUids(TArray<string> OutAnimationTrackUids) {}
	public  void GetCustomAnimationTrackUid(int Index,string OutAnimationTrackUid) {}
	public  bool AddCustomAnimationTrackUid(string AnimationTrackUid) { return default; }
	public  bool RemoveCustomAnimationTrackUid(string AnimationTrackUid) { return default; }
	public  bool SetCustomFrameRate(float AttributeValue) { return default; }
	public  bool GetCustomFrameRate(float AttributeValue) { return default; }
}
