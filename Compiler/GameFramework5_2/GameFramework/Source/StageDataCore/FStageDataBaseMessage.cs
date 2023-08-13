namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base structure for all stage monitoring messages</summary>
[CppInclude("StageMessages.h")]
public partial struct FStageDataBaseMessage {
	public int StageMessageVersion;
	public FGuid Identifier;
}
