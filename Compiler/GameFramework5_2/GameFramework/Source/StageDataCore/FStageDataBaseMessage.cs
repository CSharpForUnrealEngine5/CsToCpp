#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base structure for all stage monitoring messages</summary>
[CppInclude("StageMessages.h")]
public partial struct FStageDataBaseMessage {
	public int StageMessageVersion;
	public FGuid Identifier;
}
