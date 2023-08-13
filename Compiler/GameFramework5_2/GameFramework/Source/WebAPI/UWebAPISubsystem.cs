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
