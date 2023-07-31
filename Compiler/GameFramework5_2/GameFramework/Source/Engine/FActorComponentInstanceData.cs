#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for component instance cached data of a particular type.</summary>
[CppInclude("ComponentInstanceDataCache.h")]
public partial struct FActorComponentInstanceData {
	public UObject SourceComponentTemplate;
	public EComponentCreationMethod SourceComponentCreationMethod;
	public int SourceComponentTypeSerializedIndex;
}
