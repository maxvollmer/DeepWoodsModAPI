using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xTile.Dimensions;

namespace DeepWoodsMod.API
{
    public interface IDeepWoodsExit
    {
        int ExitDirection { get; }
        Location Location { get; }
        string TargetLocationName { get; set; }
        Location TargetLocation { get; set; }
    }
}
