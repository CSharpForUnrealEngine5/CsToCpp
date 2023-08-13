namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple controller that replaces or adds to the translation/rotation of a single bone.</summary>
[CppInclude("BoneControllers/AnimNode_SpringBone.h")]
public partial struct FAnimNode_SpringBone {
	public FBoneReference SpringBone;
	public double MaxDisplacement;
	public double SpringStiffness;
	public double SpringDamping;
	public double ErrorResetThresh;
	public bool bNoZSpring_DEPRECATED;
	public bool bLimitDisplacement;
	public bool bTranslateX;
	public bool bTranslateY;
	public bool bTranslateZ;
	public bool bRotateX;
	public bool bRotateY;
	public bool bRotateZ;
}
