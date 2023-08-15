namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Get Animation Channel is used to retrieve a control&#39;s animation channel value</summary>
[CppInclude("Units/Hierarchy/RigUnit_ControlChannel.h")]
public partial struct FRigUnit_GetAnimationChannelBase {
	public FName Control;
	public FName Channel;
	public bool bInitial;
	public FRigElementKey CachedChannelKey;
	public int CachedChannelHash;
}
