namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading skeletal mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceSkinnedMeshVertexAttribute.h")]
public partial class UOptimusSkinnedMeshVertexAttributeDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkinnedMeshComponent</summary>
	public USkinnedMeshComponent SkinnedMeshComponent;
	///<summary>AttributeName</summary>
	public FName AttributeName;
}
