namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Processor to stop and uninitialize StateTrees on entities.</summary>
[CppInclude("MassStateTreeProcessors.h")]
public partial class UMassStateTreeFragmentDestructor : UMassObserverProcessor {
	public static UClass StaticClass() {return default;}
	///<summary>SignalSubsystem</summary>
	public UMassSignalSubsystem SignalSubsystem;
}
