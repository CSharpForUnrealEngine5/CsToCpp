namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compute Framework Data Provider for reading skeletal mesh.</summary>
[CppInclude("DataInterfaces/DIFleshDeformer.h")]
public partial class UDIFleshDeformerDataProvider : UComputeDataProvider {
	public static UClass StaticClass() {return default;}
	///<summary>SkinnedMesh</summary>
	public USkinnedMeshComponent SkinnedMesh;
	///<summary>StaticMesh</summary>
	public UStaticMeshComponent StaticMesh;
	///<summary>FleshMesh</summary>
	public UFleshComponent FleshMesh;
	///<summary>FleshDeformerParameters</summary>
	public FFleshDeformerParameters FleshDeformerParameters;
}
