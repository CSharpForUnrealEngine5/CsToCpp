#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Hierarchy/RigUnit_ControlChannel.h")]
///<summary>Get Animation Channel is used to retrieve a control's animation channel value</summary>
public partial struct FRigUnit_GetAnimationChannelBase {
// RigUnit_GetAnimationChannelBase
	public string Control;
	public string Channel;
	public bool bInitial;
	public FRigElementKey CachedChannelKey;
	public int CachedChannelHash;
}
