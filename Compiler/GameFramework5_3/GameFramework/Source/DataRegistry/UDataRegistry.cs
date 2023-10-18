namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Defines a place to efficiently store and retrieve structure data, can be used as a wrapper around Data/Curve Tables or extended with other sources</summary>
[CppInclude("DataRegistry.h")]
public partial class UDataRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Globally unique name used to identify this registry</summary>
	public FName RegistryType;
	///<summary>Rules for specifying valid item Ids, if default than any name can be used</summary>
	public FDataRegistryIdFormat IdFormat;
	///<summary>Structure type of all for items in this registry</summary>
	public UScriptStruct ItemStruct;
	///<summary>List of data sources to search for items</summary>
	public TArray<UDataRegistrySource> DataSources;
	///<summary>Runtime list of data sources, created from above list and includes sources added at runtime</summary>
	public TArray<UDataRegistrySource> RuntimeSources;
	///<summary>How often to check for cache updates</summary>
	public float TimerUpdateFrequency;
	///<summary>Editor-set cache policy</summary>
	public FDataRegistryCachePolicy DefaultCachePolicy;
}
