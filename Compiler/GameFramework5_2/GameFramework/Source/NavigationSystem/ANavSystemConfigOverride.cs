#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavSystemConfigOverride.h")]
public partial class ANavSystemConfigOverride : AActor {
// NavSystemConfigOverride
	public UBillboardComponent SpriteComponent;
	public UNavigationSystemConfig NavigationSystemConfig;
	public ENavSystemOverridePolicy OverridePolicy;
	public bool bLoadOnClient;
	public void ApplyChanges() {}
}
