#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeomModifier_Clip.h")]
public partial class UGeomModifier_Clip : UGeomModifier_Edit {
// GeomModifier_Clip
	public bool bFlipNormal;
	public bool bSplit;
	public TArray<FVector> ClipMarkers;
	public FVector SnappedMouseWorldSpacePos;
}
