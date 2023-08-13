namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TimecodeSynchronizer.h")]
///<summary>Defines the various modes that the synchronizer can use to try and achieve synchronization.</summary>
public enum ETimecodeSynchronizationSyncMode {
	UserDefinedOffset=0,
	Auto=1,
	AutoOldest=2,
}
