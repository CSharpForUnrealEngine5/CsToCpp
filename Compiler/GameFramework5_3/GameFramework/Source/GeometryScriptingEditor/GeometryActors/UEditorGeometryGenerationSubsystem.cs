namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UEditorGeometryGenerationSubsystem manages recomputation of &quot;generated&quot; mesh actors, eg</summary>
[CppInclude("GeometryActors/EditorGeometryGenerationSubsystem.h")]
public partial class UEditorGeometryGenerationSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>GenerationManager</summary>
	public UEditorGeometryGenerationManager GenerationManager;
}
