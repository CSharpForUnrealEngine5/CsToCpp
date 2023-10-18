namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeGizmoActor.h")]
public partial class ALandscapeGizmoActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Width</summary>
	public float Width;
	///<summary>Height</summary>
	public float Height;
	///<summary>LengthZ</summary>
	public float LengthZ;
	///<summary>MarginZ</summary>
	public float MarginZ;
	///<summary>MinRelativeZ</summary>
	public float MinRelativeZ;
	///<summary>RelativeScaleZ</summary>
	public float RelativeScaleZ;
	///<summary>TargetLandscapeInfo</summary>
	public ULandscapeInfo TargetLandscapeInfo;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
}
