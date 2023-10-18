namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Contain the params necessary to calculate a warp point for the scene.</summary>
[CppInclude("ContextualAnimTypes.h")]
public partial struct FContextualAnimWarpPointDefinition {
	public FName WarpTargetName;
	public EContextualAnimWarpPointDefinitionMode Mode;
	public FName SocketName;
	public FContextualAnimWarpPointCustomParams Params;
}
