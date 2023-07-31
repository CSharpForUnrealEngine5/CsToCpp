#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MeshSimplificationSettings.h")]
public partial class UMeshSimplificationSettings : UDeveloperSettings {
	///<summary>Mesh reduction plugin to use when simplifying mesh geometry</summary>
	public string MeshReductionModuleName;
	///<summary>bMeshReductionBackwardCompatible</summary>
	public bool bMeshReductionBackwardCompatible;
}
