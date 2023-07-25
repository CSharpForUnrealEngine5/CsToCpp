#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ChildConnection.h")]
///<summary>Represents a secondary split screen connection that reroutes calls to the parent connection.</summary>
public partial class UChildConnection : UNetConnection {
// ChildConnection
	public UNetConnection Parent;
}
