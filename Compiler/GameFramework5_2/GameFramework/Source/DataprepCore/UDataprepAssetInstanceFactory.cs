namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataprepFactories.h")]
public partial class UDataprepAssetInstanceFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The parent of the of the instance to create</summary>
	public UDataprepAsset Parent;
}
