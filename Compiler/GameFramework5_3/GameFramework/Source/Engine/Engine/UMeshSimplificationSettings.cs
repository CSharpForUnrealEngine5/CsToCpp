namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshSimplificationSettings.h")]
public partial class UMeshSimplificationSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Mesh reduction plugin to use when simplifying mesh geometry</summary>
	public FName MeshReductionModuleName;
	///<summary>bMeshReductionBackwardCompatible</summary>
	public bool bMeshReductionBackwardCompatible;
}
