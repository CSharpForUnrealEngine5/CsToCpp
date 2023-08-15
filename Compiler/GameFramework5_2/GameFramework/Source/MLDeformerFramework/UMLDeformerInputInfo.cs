namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The neural network input information.</summary>
[CppInclude("MLDeformerInputInfo.h")]
public partial class UMLDeformerInputInfo : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The path to the skeletal mesh that this model was trained on.</summary>
	public FSoftObjectPath SkeletalMesh;
	///<summary>The list of bone names, but as string. This is deprecated since UE 5.2.</summary>
	public TArray<string> BoneNameStrings_DEPRECATED;
	///<summary>The list of curve names, but as string. This is deprecated since UE 5.2.</summary>
	public TArray<string> CurveNameStrings_DEPRECATED;
	///<summary>The name of each bone. The inputs to the network are in the order of this array.</summary>
	public TArray<FName> BoneNames;
	///<summary>The name of each curve. The inputs to the network are in the order of this array.</summary>
	public TArray<FName> CurveNames;
	///<summary>Number of imported base mesh vertices, so not render vertices.</summary>
	public int NumBaseMeshVertices;
	///<summary>Number of imported target mesh vertices, so not render vertices.</summary>
	public int NumTargetMeshVertices;
}
