#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OptimusSettings.h")]
public partial class UOptimusSettings : UDeveloperSettings {
	///<summary>Set when skinned meshes should have a default deformer applied.</summary>
	public EOptimusDefaultDeformerMode DefaultMode;
	///<summary>A default deformer that will be used on a skinned mesh if no other deformer has been set.</summary>
	public TSoftObjectPtr<UMeshDeformer> DefaultDeformer;
	///<summary>A default deformer that will be used on a skinned mesh if no other deformer has been set, and if the mesh has requested to recompute tangets.</summary>
	public TSoftObjectPtr<UMeshDeformer> DefaultRecomputeTangentDeformer;
}
