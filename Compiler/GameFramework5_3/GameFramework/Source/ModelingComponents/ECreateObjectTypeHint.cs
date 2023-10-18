namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingObjectsCreationAPI.h")]
///<summary>Hint for the type of mesh object a UModelingObjectsCreationAPI might create based</summary>
public enum ECreateObjectTypeHint {
	Undefined=0,
	StaticMesh=1,
	Volume=2,
	DynamicMeshActor=3,
}
