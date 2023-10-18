namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier_Clip.h")]
public partial class UGeomModifier_Clip : UGeomModifier_Edit {
	public static UClass StaticClass() {return default;}
	///<summary>bFlipNormal</summary>
	public bool bFlipNormal;
	///<summary>bSplit</summary>
	public bool bSplit;
	///<summary>The clip markers that the user has dropped down in the world so far.</summary>
	public TArray<FVector> ClipMarkers;
	///<summary>The mouse position, in world space, where the user currently is hovering.</summary>
	public FVector SnappedMouseWorldSpacePos;
}
