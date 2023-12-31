namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/SpectatorPawnMovement.h")]
public partial class USpectatorPawnMovement : UFloatingPawnMovement {
	public static UClass StaticClass() {return default;}
	///<summary>If true, component moves at full speed no matter the time dilation. Default is false.</summary>
	public bool bIgnoreTimeDilation;
}
