using System;
using GObject;

namespace Gio
{
    public partial class SimpleAction
    {
        public SimpleAction(string name) : this(Sys.SimpleAction.@new(name, IntPtr.Zero)) { }
    }
}
