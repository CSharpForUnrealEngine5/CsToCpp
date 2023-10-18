namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>On each actor to process, replace any meshes used with the specified one</summary>
[CppInclude("DataprepOperations.h")]
public partial class UDataprepSetMeshOperation : UDataprepOperation {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh to use as a substitute</summary>
	public UStaticMesh StaticMesh;
}
