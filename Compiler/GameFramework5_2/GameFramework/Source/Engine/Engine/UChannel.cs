#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of communication channels.</summary>
[CppInclude("Engine/Channel.h")]
public partial class UChannel : UObject {
	///<summary>Connection</summary>
	public UNetConnection Connection;
}
