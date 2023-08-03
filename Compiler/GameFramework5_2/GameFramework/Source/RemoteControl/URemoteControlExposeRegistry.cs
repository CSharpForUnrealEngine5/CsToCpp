#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RemoteControlExposeRegistry.h")]
public partial class URemoteControlExposeRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Holds the exposed entities.</summary>
	public TSet<FRCEntityWrapper> ExposedEntities;
	///<summary>Cache of label to ids.</summary>
	public TMap<string,FGuid> LabelToIdCache;
	///<summary>Holds the types of entities exposed in the registry.</summary>
	public TSet<UScriptStruct> ExposedTypes;
}
