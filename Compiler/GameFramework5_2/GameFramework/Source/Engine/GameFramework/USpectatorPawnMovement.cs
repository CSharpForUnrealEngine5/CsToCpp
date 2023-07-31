#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/SpectatorPawnMovement.h")]
public partial class USpectatorPawnMovement : UFloatingPawnMovement {
	///<summary>If true, component moves at full speed no matter the time dilation. Default is false.</summary>
	public bool bIgnoreTimeDilation;
}
