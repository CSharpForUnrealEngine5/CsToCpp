namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a TArray&lt;bool&gt; to a FDataflowFaceSelection</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FBoolArrayToFaceSelectionDataflowNode {
	public TArray<bool> BoolAttributeData;
	public FDataflowFaceSelection FaceSelection;
}
