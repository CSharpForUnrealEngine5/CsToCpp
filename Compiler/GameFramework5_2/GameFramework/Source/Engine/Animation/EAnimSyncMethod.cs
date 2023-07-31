#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimationAsset.h")]
///<summary>How an asset will synchronize with other assets</summary>
public enum EAnimSyncMethod {
	DoNotSync=0,
	SyncGroup=1,
	Graph=2,
}
