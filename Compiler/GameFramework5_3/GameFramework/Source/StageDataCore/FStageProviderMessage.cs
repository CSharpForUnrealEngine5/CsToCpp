namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Provider messages listened by monitors</summary>
[CppInclude("StageMessages.h")]
public partial struct FStageProviderMessage {
	public FQualifiedFrameTime FrameTime;
	public FDateTime DateTime;
}
