namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Return all actors overlapping the selected actors</summary>
[CppInclude("DataprepGeometrySelectionTransforms.h")]
public partial class UDataprepOverlappingActorsSelectionTransform : UDataprepSelectionTransform {
	public static UClass StaticClass() {return default;}
	///<summary>Accuracy of the distance field approximation</summary>
	public float JacketingAccuracy;
	///<summary>If checked, select fully inside + overlapping actors. Else, select only actors that are fully inside.</summary>
	public bool bSelectOverlapping;
}
