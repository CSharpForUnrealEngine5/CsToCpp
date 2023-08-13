namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNotifies/AnimNotifyState_Trail.h")]
public partial class UAnimNotifyState_Trail : UAnimNotifyState {
	public static UClass StaticClass() {return default;}
	///<summary>The particle system to use for this trail.</summary>
	public UParticleSystem PSTemplate;
	///<summary>OverridePSTemplate</summary>
	public UParticleSystem OverridePSTemplate(USkeletalMeshComponent MeshComp,UAnimSequenceBase Animation) { return default; }
	///<summary>Name of the first socket defining this trail.</summary>
	public string FirstSocketName;
	///<summary>Name of the second socket defining this trail.</summary>
	public string SecondSocketName;
	///<summary>Controls the way width scale is applied. In each method a width scale of 1.0 will mean the width is unchanged from the position of the sockets. A width scale of 0.0 will cause a trail of zero width.</summary>
	public ETrailWidthMode WidthScaleMode;
	///<summary>Name of the curve to drive the width scale.</summary>
	public string WidthScaleCurve;
	///<summary>bRecycleSpawnedSystems</summary>
	public bool bRecycleSpawnedSystems;
	///<summary>If true, render the trail geometry (this should typically be on)</summary>
	public bool bRenderGeometry;
	///<summary>If true, render stars at each spawned particle point along the trail</summary>
	public bool bRenderSpawnPoints;
	///<summary>If true, render a line showing the tangent at each spawned particle point along the trail</summary>
	public bool bRenderTangents;
	///<summary>If true, render the tessellated path between spawned particles</summary>
	public bool bRenderTessellation;
}
