using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioProcessHelper;

internal class LaunchArguments
{
    private readonly string[] _noGUIArguments = new[] { "nogui", "silent" };

    public LaunchArguments(string[] args)
    {
        NoGUI = !args.Any(x => _noGUIArguments.Contains(x.ToLower()));
    }

    public bool NoGUI { get; set; }
}
