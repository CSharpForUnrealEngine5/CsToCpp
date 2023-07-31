#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavSystemConfigOverride.h")]
public partial class ANavSystemConfigOverride : AActor {
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>NavigationSystemConfig</summary>
	public UNavigationSystemConfig NavigationSystemConfig;
	///<summary>If there&#39;s already a NavigationSystem instance in the world how should this nav override behave</summary>
	public ENavSystemOverridePolicy OverridePolicy;
	///<summary>bLoadOnClient</summary>
	public bool bLoadOnClient;
	///<summary>made an explicit function since rebuilding navigation system can be expensive</summary>
	public  void ApplyChanges() {}
}
