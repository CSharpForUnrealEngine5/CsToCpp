namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of communication channels.</summary>
[CppInclude("Engine/Channel.h")]
public partial class UChannel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Connection</summary>
	public UNetConnection Connection;
}
