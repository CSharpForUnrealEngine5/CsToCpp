namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a secondary split screen connection that reroutes calls to the parent connection.</summary>
[CppInclude("Engine/ChildConnection.h")]
public partial class UChildConnection : UNetConnection {
	public static UClass StaticClass() {return default;}
	///<summary>Parent</summary>
	public UNetConnection Parent;
}
