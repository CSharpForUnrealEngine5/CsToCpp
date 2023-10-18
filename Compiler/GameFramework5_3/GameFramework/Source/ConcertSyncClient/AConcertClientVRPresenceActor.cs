namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A ConcertClientVRPresenceActor is a child of AConcertClientPresenceActor that is used to represent users in VR</summary>
[CppInclude("ConcertClientVRPresenceActor.h")]
public partial class AConcertClientVRPresenceActor : AConcertClientPresenceActor {
	public static UClass StaticClass() {return default;}
	///<summary>The left controller mesh</summary>
	public UStaticMeshComponent LeftControllerMeshComponent;
	///<summary>The right controller mesh</summary>
	public UStaticMeshComponent RightControllerMeshComponent;
	///<summary>Dynamic material for the laser</summary>
	public UMaterialInstanceDynamic LaserMid;
	///<summary>Dynamic material for the laser</summary>
	public UMaterialInstanceDynamic LaserCoreMid;
	///<summary>LaserThickness</summary>
	public float LaserThickness;
	///<summary>Spline for the left laser pointer, if any</summary>
	public USplineComponent LeftLaserSplineComponent;
	///<summary>Spline meshes for the left curved laser, if any</summary>
	public TArray<USplineMeshComponent> LeftLaserSplineMeshComponents;
	///<summary>Spline for the right laser pointer, if any</summary>
	public USplineComponent RightLaserSplineComponent;
	///<summary>Spline meshes for the right curved laser, if any</summary>
	public TArray<USplineMeshComponent> RightLaserSplineMeshComponents;
	///<summary>bIsLeftControllerVisible</summary>
	public bool bIsLeftControllerVisible;
	///<summary>bIsRightControllerVisible</summary>
	public bool bIsRightControllerVisible;
	///<summary>bIsLeftLaserVisible</summary>
	public bool bIsLeftLaserVisible;
	///<summary>bIsRightLaserVisible</summary>
	public bool bIsRightLaserVisible;
}
