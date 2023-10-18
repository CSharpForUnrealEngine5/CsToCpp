namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading animation attributes on skeletal mesh.</summary>
[CppInclude("DataInterfaces/OptimusDataInterfaceAnimAttribute.h")]
public partial class UOptimusAnimAttributeDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkeletalMesh</summary>
	public USkeletalMeshComponent SkeletalMesh;
}
