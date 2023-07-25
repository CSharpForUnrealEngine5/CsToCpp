#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotifyState_Trail.h")]
public partial class UAnimNotifyState_Trail : UAnimNotifyState {
// AnimNotifyState_Trail
	public UParticleSystem PSTemplate;
	public UObject OverridePSTemplate(UObject MeshComp,UObject Animation) { return default; }
	public string FirstSocketName;
	public string SecondSocketName;
	public byte WidthScaleMode;
	public string WidthScaleCurve;
	public bool bRecycleSpawnedSystems;
	public bool bRenderGeometry;
	public bool bRenderSpawnPoints;
	public bool bRenderTangents;
	public bool bRenderTessellation;
}
