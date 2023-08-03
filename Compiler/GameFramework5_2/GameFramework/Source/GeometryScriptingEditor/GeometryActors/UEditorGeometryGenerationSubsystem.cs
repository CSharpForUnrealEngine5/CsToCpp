#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEditorGeometryGenerationSubsystem manages recomputation of &quot;generated&quot; mesh actors, eg</summary>
[CppInclude("GeometryActors/EditorGeometryGenerationSubsystem.h")]
public partial class UEditorGeometryGenerationSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>GenerationManager</summary>
	public UEditorGeometryGenerationManager GenerationManager;
}
