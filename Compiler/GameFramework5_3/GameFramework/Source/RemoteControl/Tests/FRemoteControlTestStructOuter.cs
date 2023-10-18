namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/RemoteControlPropertyHandleTestData.h")]
public partial struct FRemoteControlTestStructOuter {
	public short Int8Value;
	public TSet<FRemoteControlTestStructInner> StructInnerSet;
	public int Int32Value;
	public FRemoteControlTestStructInner RemoteControlTestStructInner;
}
