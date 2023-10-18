namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Converts a TArray&lt;bool&gt; to a FDataflowFaceSelection</summary>
[CppInclude("Dataflow/GeometryCollectionArrayNodes.h")]
public partial struct FBoolArrayToFaceSelectionDataflowNode {
	public TArray<bool> BoolAttributeData;
	public FDataflowFaceSelection FaceSelection;
}
