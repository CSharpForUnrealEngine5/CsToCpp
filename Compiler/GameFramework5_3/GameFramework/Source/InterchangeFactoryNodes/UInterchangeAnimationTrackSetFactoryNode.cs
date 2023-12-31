namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimationTrackSetFactoryNode.h")]
public partial class UInterchangeAnimationTrackSetFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Get the class this node want to create</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>This function allow to retrieve the number of track dependencies for this object.</summary>
	public int GetCustomAnimationTrackUidCount() { return default; }
	///<summary>This function allow to retrieve the track dependency for this object.</summary>
	public void GetCustomAnimationTrackUids(TArray<string> OutAnimationTrackUids) {}
	///<summary>This function allow to retrieve one track dependency for this object.</summary>
	public void GetCustomAnimationTrackUid(int Index,string OutAnimationTrackUid) {}
	///<summary>Add one track dependency to this object.</summary>
	public bool AddCustomAnimationTrackUid(string AnimationTrackUid) { return default; }
	///<summary>Remove one track dependency from this object.</summary>
	public bool RemoveCustomAnimationTrackUid(string AnimationTrackUid) { return default; }
	///<summary>Set the frame rate for the animations in the level sequence.</summary>
	public bool SetCustomFrameRate(float AttributeValue) { return default; }
	///<summary>Get the frame rate for the animations in the level sequence.</summary>
	public bool GetCustomFrameRate(float AttributeValue) { return default; }
}
