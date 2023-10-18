namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Parameters used to calculate a warp point when using &#39;Custom&#39; mode</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimWarpPointCustomParams {
	public FName Origin;
	public bool bAlongClosestDistance;
	public FName OtherRole;
	public float Weight;
}
