#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassCommands.h")]
///<summary>Enum used by MassBatchCommands to declare their "type". This data is later used to group commands so that command</summary>
public enum EMassCommandOperationType {
	None=0,
	Create=1,
	Add=2,
	Remove=3,
	ChangeComposition=4,
	Set=5,
	Destroy=6,
	MAX=7,
}
