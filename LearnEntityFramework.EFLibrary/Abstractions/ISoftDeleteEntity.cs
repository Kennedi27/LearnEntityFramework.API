using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityFramework.EFLibrary.Abstractions
{
    internal interface ISoftDeleteEntity
    {
        bool Deleted { get; set; }
        DateTime? DeleteTimeUtc { get; set; }
    }
}
