namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVDEditorSettings.h")]
public partial class UChaosVDEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GlobalParticleDataVisualizationFlags</summary>
	public byte GlobalParticleDataVisualizationFlags;
	///<summary>GlobalCollisionDataVisualizationFlags</summary>
	public byte GlobalCollisionDataVisualizationFlags;
	///<summary>bShowDebugText</summary>
	public bool bShowDebugText;
	///<summary>BasePhysicsVDWorld</summary>
	public TSoftObjectPtr<UWorld> BasePhysicsVDWorld;
}
