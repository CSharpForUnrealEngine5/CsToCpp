#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComponentInstanceDataCache.h")]
///<summary>Base class for component instance cached data of a particular type.</summary>
public partial struct FActorComponentInstanceData {
// ActorComponentInstanceData
	public UObject SourceComponentTemplate;
	public EComponentCreationMethod SourceComponentCreationMethod;
	public int SourceComponentTypeSerializedIndex;
}
