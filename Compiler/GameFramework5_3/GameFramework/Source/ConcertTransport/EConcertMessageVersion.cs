namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertTransportMessages.h")]
///<summary>Versioning for concert message protocol</summary>
public enum EConcertMessageVersion {
	BeforeVersioning=0,
	Initial=1,
	VersionPlusOne=2,
	LatestVersion=-1,
}
