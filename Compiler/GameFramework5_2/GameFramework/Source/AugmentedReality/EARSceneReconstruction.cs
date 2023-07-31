#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>Options for how the scene should be reconstructed. This feature is used by ARKit.</summary>
public enum EARSceneReconstruction {
	None=0,
	MeshOnly=1,
	MeshWithClassification=2,
}
