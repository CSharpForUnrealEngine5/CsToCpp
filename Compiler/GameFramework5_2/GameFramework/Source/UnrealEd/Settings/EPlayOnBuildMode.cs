#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorPlaySettings.h")]
///<summary>Determines whether to build the executable when launching on device. Note the equivalence between these settings and EProjectPackagingBuild.</summary>
public enum EPlayOnBuildMode {
	PlayOnBuild_Always=0,
	PlayOnBuild_Never=1,
	PlayOnBuild_Default=2,
	PlayOnBuild_IfEditorBuiltLocally=3,
}
