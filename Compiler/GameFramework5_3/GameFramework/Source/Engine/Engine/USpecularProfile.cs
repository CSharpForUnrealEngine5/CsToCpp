namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Specular profile asset, can be specified at a material.</summary>
[CppInclude("Engine/SpecularProfile.h")]
public partial class USpecularProfile : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public FSpecularProfileStruct Settings;
	///<summary>Guid</summary>
	public FGuid Guid;
}
