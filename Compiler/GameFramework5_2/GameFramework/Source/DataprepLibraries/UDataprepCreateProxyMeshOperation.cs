#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Collect geometry from selected actors and merge them into single mesh with reduction.</summary>
[CppInclude("DataprepEditingOperations.h")]
public partial class UDataprepCreateProxyMeshOperation : UDataprepEditingOperation {
	///<summary>Settings to use for the create proxy operation</summary>
	public string NewActorLabel;
	///<summary>Quality</summary>
	public float Quality;
}
