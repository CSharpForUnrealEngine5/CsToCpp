#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ModelingComponentsSettings.h")]
///<summary>Settings for the Modeling Components plug-in. These settings are primarily used to configure two things:</summary>
public partial class UModelingComponentsSettings : UDeveloperSettings {
// ModelingComponentsSettings
	public bool bEnableRayTracingWhileEditing;
	public bool bEnableRayTracing;
	public bool bEnableCollision;
	public ECollisionTraceFlag CollisionMode;
}
