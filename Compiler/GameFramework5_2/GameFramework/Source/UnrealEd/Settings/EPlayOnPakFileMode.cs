#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/LevelEditorPlaySettings.h")]
///<summary>Whether to content should be stored in pak files when launching on device.</summary>
public enum EPlayOnPakFileMode {
	NoPak=0,
	PakNoCompress=1,
	PakCompress=2,
}
