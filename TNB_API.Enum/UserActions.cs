using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNB_API.Enum
{
	[Flags]
	public enum UserActions
	{
		None = 0x0,
		Delete = 0x1,
		Update = 0x2,
		Read = 0x4,
		Create = 0x8
	}
}
