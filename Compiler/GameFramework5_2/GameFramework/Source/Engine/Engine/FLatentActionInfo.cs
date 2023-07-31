#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Latent action info</summary>
[CppInclude("Engine/LatentActionManager.h")]
public partial struct FLatentActionInfo {
	public int Linkage;
	public int UUID;
	public string ExecutionFunction;
	public UObject CallbackTarget;
}
