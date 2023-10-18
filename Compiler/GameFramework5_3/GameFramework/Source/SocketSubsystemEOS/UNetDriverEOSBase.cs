namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NetDriverEOSBase.h")]
public partial class UNetDriverEOSBase : UIpNetDriver {
	public static UClass StaticClass() {return default;}
	///<summary>bIsPassthrough</summary>
	public bool bIsPassthrough;
	///<summary>bIsUsingP2PSockets</summary>
	public bool bIsUsingP2PSockets;
}
