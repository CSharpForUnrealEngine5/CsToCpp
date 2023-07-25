#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebAPISubsystem.h")]
///<summary>Common functionality and top-level parent for shared objects.</summary>
public partial class UWebAPISubsystem : UEngineSubsystem {
// WebAPISubsystem
	public bool bUsePooling;
	public TMap<string,FWebAPIPooledOperation> OperationPool;
}
