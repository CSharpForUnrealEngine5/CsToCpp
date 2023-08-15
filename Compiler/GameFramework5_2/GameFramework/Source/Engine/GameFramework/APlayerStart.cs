namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class indicates a location where a player can spawn when the game begins.</summary>
[CppInclude("GameFramework/PlayerStart.h")]
public partial class APlayerStart : ANavigationObjectBase {
	public static UClass StaticClass() {return default;}
	///<summary>Used when searching for which playerstart to use.</summary>
	public FName PlayerStartTag;
	///<summary>ArrowComponent</summary>
	public UArrowComponent ArrowComponent;
}
