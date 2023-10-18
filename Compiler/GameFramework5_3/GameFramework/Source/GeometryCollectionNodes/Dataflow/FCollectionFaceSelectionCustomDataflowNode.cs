namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Selects specified faces in the GeometryCollection by using a</summary>
[CppInclude("Dataflow/GeometryCollectionSelectionNodes.h")]
public partial struct FCollectionFaceSelectionCustomDataflowNode {
	public FManagedArrayCollection Collection;
	public string FaceIndicies;
	public FDataflowFaceSelection FaceSelection;
}
