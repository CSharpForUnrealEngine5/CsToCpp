#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Actor.h")]
///<summary>Enum defining how actor will be placed in the partition</summary>
public enum EActorGridPlacement {
	Bounds=0,
	Location=1,
	AlwaysLoaded=2,
	None=3,
}
