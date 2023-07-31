#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a secondary split screen connection that reroutes calls to the parent connection.</summary>
[CppInclude("Engine/ChildConnection.h")]
public partial class UChildConnection : UNetConnection {
	///<summary>Parent</summary>
	public UNetConnection Parent;
}
