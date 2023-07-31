#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Blueprint.h")]
///<summary>Enumerates types of blueprints.</summary>
public enum EBlueprintType {
	BPTYPE_Normal=0,
	BPTYPE_Const=1,
	BPTYPE_MacroLibrary=2,
	BPTYPE_Interface=3,
	BPTYPE_LevelScript=4,
	BPTYPE_FunctionLibrary=5,
	BPTYPE_MAX=6,
}
