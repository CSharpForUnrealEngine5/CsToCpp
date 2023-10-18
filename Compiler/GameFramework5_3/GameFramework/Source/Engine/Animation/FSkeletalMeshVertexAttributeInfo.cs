namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A structure to store user-controllable settings for attributes</summary>
[CppInclude("Animation/SkeletalMeshVertexAttribute.h")]
public partial struct FSkeletalMeshVertexAttributeInfo {
	public FPerPlatformBool EnabledForRender;
	public FName Name;
	public ESkeletalMeshVertexAttributeDataType DataType;
}
