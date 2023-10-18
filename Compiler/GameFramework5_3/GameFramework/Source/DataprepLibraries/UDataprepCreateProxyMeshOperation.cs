namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Collect geometry from selected actors and merge them into single mesh with reduction.</summary>
[CppInclude("DataprepEditingOperations.h")]
public partial class UDataprepCreateProxyMeshOperation : UDataprepEditingOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Settings to use for the create proxy operation</summary>
	public string NewActorLabel;
	///<summary>Quality</summary>
	public float Quality;
}
