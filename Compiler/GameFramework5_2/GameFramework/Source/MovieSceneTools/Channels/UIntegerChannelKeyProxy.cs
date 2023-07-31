#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/IntegerChannelKeyProxy.h")]
public partial class UIntegerChannelKeyProxy : UObject {
	///<summary>User-facing time of the key, applied to the actual key on PostEditChange, and updated every tick</summary>
	public FFrameNumber Time;
	///<summary>User-facing value of the key, applied to the actual key on PostEditChange, and updated every tick</summary>
	public int Value;
}
