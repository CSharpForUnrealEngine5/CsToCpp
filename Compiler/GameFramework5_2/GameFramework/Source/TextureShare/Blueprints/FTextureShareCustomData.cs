#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom data for sharing</summary>
[CppInclude("Blueprints/TextureShareBlueprintContainersBase.h")]
public partial struct FTextureShareCustomData {
	public TMap<string,string> SendParameters;
	public TMap<string,string> ReceivedParameters;
}
