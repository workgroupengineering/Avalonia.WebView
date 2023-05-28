using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum PHCollectionEditOperation : long
{
	None,
	DeleteContent,
	RemoveContent,
	AddContent,
	CreateContent,
	RearrangeContent,
	Delete,
	Rename
}