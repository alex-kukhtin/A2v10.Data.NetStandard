﻿// Copyright © 2015-2020 Alex Kukhtin. All rights reserved.

using System;

namespace A2v10.Data.Interfaces
{
	public interface IDataConfiguration
	{
		String ConnectionString(String source);
		TimeSpan CommandTimeout { get; }
	}
}
