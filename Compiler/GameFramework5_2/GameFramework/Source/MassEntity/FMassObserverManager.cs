#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A type that encapsulates logic related to notifying interested parties of entity composition changes. Upon creation it</summary>
[CppInclude("MassObserverManager.h")]
public partial struct FMassObserverManager {
	public FMassObserversMap FragmentObservers;
	public FMassObserversMap TagObservers;
}
