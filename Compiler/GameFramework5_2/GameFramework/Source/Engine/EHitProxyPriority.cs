#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HitProxies.h")]
///<summary>The priority a hit proxy has when choosing between several hit proxies near the point the user clicked.</summary>
public enum EHitProxyPriority {
	HPP_World=0,
	HPP_Wireframe=1,
	HPP_Foreground=2,
	HPP_UI=3,
}
