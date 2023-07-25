#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistry.h")]
///<summary>Defines a place to efficiently store and retrieve structure data, can be used as a wrapper around Data/Curve Tables or extended with other sources</summary>
public partial class UDataRegistry : UObject {
// DataRegistry
	public string RegistryType;
	public FDataRegistryIdFormat IdFormat;
	public UScriptStruct ItemStruct;
	public TArray<UDataRegistrySource> DataSources;
	public TArray<UDataRegistrySource> RuntimeSources;
	public float TimerUpdateFrequency;
	public FDataRegistryCachePolicy DefaultCachePolicy;
}
