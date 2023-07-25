#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ProjectPackagingSettings.h")]
///<summary>Determines whether to build the executable when packaging. Note the equivalence between these settings and EPlayOnBuildMode.</summary>
public enum EProjectPackagingBuild {
	Always=0,
	Never=1,
	IfProjectHasCode=2,
	IfEditorWasBuiltLocally=3,
}
