#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Builds context and creates GameplayTask that will control playback of a ContextualAnimScene</summary>
[CppInclude("StateTree/ContextualAnimStateTreeTask.h")]
public partial struct FContextualAnimStateTreeTask {
	public string Section;
	public string ExitSection;
	public bool bEnabled;
}
