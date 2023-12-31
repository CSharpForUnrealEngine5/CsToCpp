namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Extended game engine</summary>
[CppInclude("DisplayClusterGameEngine.h")]
public partial class UDisplayClusterGameEngine : UGameEngine {
	public static UClass StaticClass() {return default;}
	///<summary>WorldContextObject</summary>
	public UObject WorldContextObject;
}
