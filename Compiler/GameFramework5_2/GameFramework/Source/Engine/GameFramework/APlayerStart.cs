#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class indicates a location where a player can spawn when the game begins.</summary>
[CppInclude("GameFramework/PlayerStart.h")]
public partial class APlayerStart : ANavigationObjectBase {
	///<summary>Used when searching for which playerstart to use.</summary>
	public string PlayerStartTag;
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
}
