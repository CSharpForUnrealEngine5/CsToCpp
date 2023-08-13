namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Modeling Components plug-in. These settings are primarily used to configure two things:</summary>
[CppInclude("ModelingComponentsSettings.h")]
public partial class UModelingComponentsSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Enable Realtime Raytracing support for Mesh Editing Tools. This will impact performance of Tools with Real-Time feedback like 3D Sculpting.</summary>
	public bool bEnableRayTracingWhileEditing;
	///<summary>Enable Raytracing Support for new Mesh Objects created by Modeling Tools, if support is optional (eg DynamicMeshActors)</summary>
	public bool bEnableRayTracing;
	///<summary>Enable Collision Support for new Mesh Objects created by Modeling Tools</summary>
	public bool bEnableCollision;
	///<summary>Default Collision Mode set on new Mesh Objects created by Modeling Tools</summary>
	public ECollisionTraceFlag CollisionMode;
}
