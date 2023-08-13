namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configurable net blob handler definitions.</summary>
[CppInclude("Iris/ReplicationSystem/NetBlob/NetBlobHandlerDefinitions.h")]
public partial class UNetBlobHandlerDefinitions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NetBlobHandlerDefinitions</summary>
	public TArray<FNetBlobHandlerDefinition> NetBlobHandlerDefinitions;
}
