namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor used to represent a Chaos Particle in the Visual Debugger&#39;s world</summary>
[CppInclude("ChaosVDParticleActor.h")]
public partial class AChaosVDParticleActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>LocalParticleDataVisualizationFlags</summary>
	public byte LocalParticleDataVisualizationFlags;
	///<summary>LocalCollisionDataVisualizationFlags</summary>
	public byte LocalCollisionDataVisualizationFlags;
	///<summary>bShowDebugText</summary>
	public bool bShowDebugText;
	///<summary>ParticleDataViewer</summary>
	public FChaosVDParticleDataWrapper ParticleDataViewer;
}
