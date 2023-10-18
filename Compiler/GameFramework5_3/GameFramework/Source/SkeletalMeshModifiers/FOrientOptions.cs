namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FOrientOptions</summary>
[CppInclude("SkeletonModifier.h")]
public partial struct FOrientOptions {
	public EAxis Primary;
	public EAxis Secondary;
	public bool bUsePlaneAsSecondary;
	public FVector SecondaryTarget;
	public bool bOrientChildren;
}
