namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Builds context and creates GameplayTask that will control playback of a ContextualAnimScene</summary>
[CppInclude("StateTree/ContextualAnimStateTreeTask.h")]
public partial struct FContextualAnimStateTreeTask {
	public string Section;
	public string ExitSection;
	public bool bEnabled;
}
