namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Custom data for sharing</summary>
[CppInclude("Blueprints/TextureShareBlueprintContainersBase.h")]
public partial struct FTextureShareCustomData {
	public TMap<string,string> SendParameters;
	public TMap<string,string> ReceivedParameters;
}
