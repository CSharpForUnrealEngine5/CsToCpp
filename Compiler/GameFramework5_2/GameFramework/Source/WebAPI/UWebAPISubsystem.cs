#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Common functionality and top-level parent for shared objects.</summary>
[CppInclude("WebAPISubsystem.h")]
public partial class UWebAPISubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>bUsePooling</summary>
	public bool bUsePooling;
	///<summary>OperationPool</summary>
	public TMap<string,FWebAPIPooledOperation> OperationPool;
}
