#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory with enough info to spawn the background-thread Operator to do a chunk of work for the tool</summary>
[CppInclude("UVProjectionTool.h")]
public partial class UUVProjectionOperatorFactory : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Tool</summary>
	public UUVProjectionTool Tool;
}
