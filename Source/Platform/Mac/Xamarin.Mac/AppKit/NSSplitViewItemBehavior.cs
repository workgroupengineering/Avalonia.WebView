using ObjCRuntime;

namespace AppKit;

[Mac(10, 11)]
[Native]
public enum NSSplitViewItemBehavior : long
{
	Default,
	Sidebar,
	ContentList
}