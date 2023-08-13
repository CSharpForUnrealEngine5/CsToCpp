namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationAsset.h")]
///<summary>How an asset will synchronize with other assets</summary>
public enum EAnimSyncMethod {
	DoNotSync=0,
	SyncGroup=1,
	Graph=2,
}
